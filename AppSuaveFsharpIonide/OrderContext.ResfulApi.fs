module OrderContext.RestApi

open OrderTaking.PlaceOrder.Api

open Newtonsoft.Json
open Newtonsoft.Json.Serialization
open Suave
open Suave.Successful
open Suave.Operators
open Suave.Filters
open System.Collections.Generic


[<AutoOpen>]


module RestFul = 

    type RestResource<'a> = {
        GetAll: unit -> 'a seq
        Create: 'a -> 'a 
    }

    type Person = {
        Id : int
        Name : string
        Age : int
        Email : string
    }

let person1 = {Id=1; Name="Felix M. Fotio"; Age=33; Email="felix@gmail.com"}
let person2 = {Id=2; Name="Megan A. Hess"; Age=28; Email="felix@gmail.com"}

module Db = 
    let private peopleStorage = new Dictionary<int, Person>()
    peopleStorage.Add(person1.Id, person1)
    peopleStorage.Add(person2.Id, person2)
    let getPeople () = 
        peopleStorage.Values :> seq<Person>
    let createPerson person = 
        let id = peopleStorage.Values.Count + 1
        let newPerson = {person with Id = id}
        peopleStorage.Add(newPerson.Id, newPerson)
        newPerson


//Helper Functions
//JSON GLOBAL HELPER FUNTION to transform any generic type 'a into a type HttpContext->Async<HttpContext>
let JSON v = 
    let settings = new JsonSerializerSettings()
    settings.ContractResolver <- new CamelCasePropertyNamesContractResolver()
    JsonConvert.SerializeObject(v, settings)
    |> OK
    >=> Writers.setMimeType "application/json; charset=utf-8"

let fromJson<'a> json = 
    JsonConvert.DeserializeObject(json, typeof<'a>) :?> 'a
    
let getResourceFromReq<'a> (req: HttpRequest) = 
    let getString rawForm = 
        System.Text.Encoding.UTF8.GetString(rawForm)
    req.rawForm |> getString |> fromJson<'a>
   

let rest restResourceName resource = 
    let resourcePath = "/" + restResourceName
    let getAll = warbler(fun _ ->resource.GetAll () |> JSON)
    path resourcePath >=> choose [
        Filters.GET >=> getAll
        Filters.POST >=> request (getResourceFromReq >> resource.Create >> JSON)
    ]


let peopleWebPart = rest "place-order" {
    GetAll = Db.getPeople
    Create = Db.createPerson    
}