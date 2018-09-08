module OrderTaking.PlaceOrder.WithoutEffects.Api

// ======================================================
// This file contains the JSON API interface to the PlaceOrder workflow
//
// 1) The HttpRequest is turned into a DTO, which is then turned into a Domain object
// 2) The main workflow function is called
// 3) The output is turned into a DTO which is turned into a HttpResponse
// ======================================================


open Newtonsoft.Json
open OrderTaking.Common
open OrderTaking.PlaceOrder


type JsonString = string

/// Very simplified version!
type HttpRequest = {
    Action : string
    Uri : string
    Body : JsonString 
    }

/// Very simplified version!
type HttpResponse = {
    HttpStatusCode : int
    Body : JsonString 
    }

/// An API takes a HttpRequest as input and returns a async response
type PlaceOrderApi = HttpRequest -> Async<HttpResponse>


// =============================
// Implementation
// =============================

// setup dummy dependencies            

let checkProductExists : ImplementationWithoutEffects.CheckProductCodeExists =
    fun productCode -> 
        true // dummy implementation

let checkAddressExists : ImplementationWithoutEffects.CheckAddressExists =
    fun unvalidatedAddress -> 
        let checkedAddress = ImplementationWithoutEffects.CheckedAddress unvalidatedAddress 
        checkedAddress 

let getProductPrice : ImplementationWithoutEffects.GetProductPrice =
    fun productCode -> 
        Price.unsafeCreate 1M  // dummy implementation


let createOrderAcknowledgmentLetter : ImplementationWithoutEffects.CreateOrderAcknowledgmentLetter =
    fun pricedOrder ->
        let letterTest = ImplementationWithoutEffects.HtmlString "some text"
        letterTest 

let sendOrderAcknowledgment : ImplementationWithoutEffects.SendOrderAcknowledgment =
    fun orderAcknowledgement ->
        ImplementationWithoutEffects.Sent 


// -------------------------------
// workflow
// -------------------------------

/// This function converts the workflow output into a HttpResponse
let workflowResultToHttpReponse result = 

        // turn domain events into dtos
        let dtos = 
            result 
            |> List.map PlaceOrderEventDto.fromDomain
            |> List.toArray // arrays are json friendly
        // and serialize to JSON
        let json = JsonConvert.SerializeObject(dtos)
        let response = 
            {
            HttpStatusCode = 200
            Body = json
            }
        response

let placeOrderApiWithoutEffect : PlaceOrderApi =
    fun request ->
        // following the approach in "A Complete Serialization Pipeline" in chapter 11

        // start with a string
        let orderFormJson = request.Body
        let orderForm = JsonConvert.DeserializeObject<OrderFormDto>(orderFormJson)
        // convert to domain object
        let unvalidatedOrder = orderForm |> OrderFormDto.toUnvalidatedOrder

        //printfn "unvalidatedOrder %A" unvalidatedOrder

        // setup the dependencies. See "Injecting Dependencies" in chapter 9
        let workflow = 
            ImplementationWithoutEffects.placeOrder 
                checkProductExists // dependency
                checkAddressExists // dependency
                getProductPrice    // dependency
                createOrderAcknowledgmentLetter  // dependency
                sendOrderAcknowledgment // dependency

        // now we are in the pure domain
        let asyncResult = workflow unvalidatedOrder 

        //printfn "HERE " asyncResult.
        


        // now convert from the pure domain back to a HttpResponse
        let result = asyncResult |> workflowResultToHttpReponse

        result |> Async.retn
