#r @"/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/SQLProvider/lib/net451/FSharp.Data.SqlProvider.dll"
open System.Web.UI.WebControls
open System.Reflection
open FSharp.Data.Sql



FSharp.Data.Sql.Common.QueryEvents.SqlQueryEvent |> Event.add (printfn "Executing SQL: %O")

[<Literal>]
let connString  = "Server=localhost;Database=Test;User=root;Password=mysql"

[<Literal>]
let ResPath = "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MySql.Data/lib/net452/MySql.Data.dll"

[<Literal>]
let Owner = "Test"
let DbVendor    = Common.DatabaseProviderTypes.MYSQL

let indivAmount = 1000

let useOptTypes = true

type DbProvider = SqlDataProvider<
                            Common.DatabaseProviderTypes.MYSQL, 
                            connString, 
                            ResolutionPath = ResPath,
                            IndividualsAmount = 1000,
                            UseOptionTypes = true,
                            Owner = Owner>
 
type ContactInfo ={

  CustomerId: string
  EmailAddress: string
  Phone: string

}                        

type Customer = {
    CustomerId : string
    Name : string
    BirthDate : string
}


type DbWriteError = 
    | DuplicateRecord of string
  

type DbReadError = 
    | InvalidRecord of string
    | MissingRecord of string
    | InvalidRecordCount of string




let readOneCustomer (connectionString:string) customerId : Result<Customer, DbReadError> =

    let ctx = DbProvider.GetDataContext connectionString

    let dbCustomers = query { 
                                for nextCustomer in ctx.Test.Customer do
                                where (nextCustomer.CustomerId = customerId)
                                select (nextCustomer)
                            } 
                            |> Seq.map (fun x -> x.MapTo<Customer>())
                            |> Seq.toList
    match dbCustomers with 
    | [] -> 
      let msg = sprintf "Not found. CustomerId=%A" customerId
      Error (MissingRecord msg)
    | [dbCustomer] -> 
      Ok dbCustomer
    | _ -> 
      let msg = sprintf "Multiple records found for CustomerId = %A" customerId
      Error (InvalidRecordCount msg)

let insertOneCustomer (connectionString:string) customer = 
    let ctx = DbProvider.GetDataContext connectionString
    let customers = ctx.Test.Customer
    let row = customers.Create()
    row.CustomerId <- System.Guid.NewGuid().ToString().ToUpper()
    row.Name <- customer.Name
    row.Birthdate <- customer.BirthDate
    ctx.SubmitUpdates()
   

let customerNew1 =  {CustomerId = System.Guid.NewGuid().ToString().ToUpper(); Name="Ivan TENGOUE MANFE";  BirthDate="22/05/1990"}
let customerNew2 =  {CustomerId = System.Guid.NewGuid().ToString().ToUpper(); Name="Barrack OBAMA";  BirthDate="30/06/1965"}
let customerNew3 =  {CustomerId = System.Guid.NewGuid().ToString().ToUpper(); Name="Todd Hess";  BirthDate="27/04/1960"}
