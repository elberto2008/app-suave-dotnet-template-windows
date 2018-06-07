open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Operators
open Suave.Filters
open OrderTaking.Common
open OrderTaking.PlaceOrder
open OrderTaking.PlaceOrder.Api


let requestBody:JsonString =  "request body"

let request =  {
    Action = "Place Order"
    Uri = "api/v1/place-order"
    Body = requestBody
    }



let app = 
    choose [ GET >=> choose
                [ path "/" >=> OK "This is my Home Page"
                  path "/hello" >=> OK "This is my GET Hello Page" ]
             POST >=> choose
                [ path "/hello" >=> OK "This is my POST Hello Page"
                  path "/place-order" >=> OK "This is my place-order" ]
    ]

startWebServer defaultConfig app
