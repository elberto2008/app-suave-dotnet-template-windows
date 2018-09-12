#r @"/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/SQLProvider/lib/net451/FSharp.Data.SqlProvider.dll"
open FSharp.Data.Sql



FSharp.Data.Sql.Common.QueryEvents.SqlQueryEvent |> Event.add (printfn "Executing SQL: %O")

let connString  = "Server=localhost;Database=Test;User=root;Password=mysql"

let ResPath = "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MySql.Data/lib/net452/MySql.Data.dll"
    
let DbVendor    = Common.DatabaseProviderTypes.MYSQL

let indivAmount = 1000

let useOptTypes = true

type DbProvider = SqlDataProvider<
                            Common.DatabaseProviderTypes.MYSQL, 
                            "Server=localhost;Database=Test;User=root;Password=mysql", 
                            ResolutionPath = "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MySql.Data/lib/net452/MySql.Data.dll",
                            IndividualsAmount = 1000,
                            UseOptionTypes = true,
                            Owner = "Test"
                            >
let ctx = DbProvider.GetDataContext()


let customers = ctx.Test.Customer

type Customer = {
    CustomerId : string
    Name : string
    BirthDate : string
}


let allCustomers = query { for row in customers do
                           where (row.Birthdate = "13/02/1990")
                           select row
                         } 
                         |> Seq.map (fun x -> x.MapTo<Customer>())


printfn "CUSTOMERS = %A " allCustomers

let row = customers.Create()

row.CustomerId <- System.Guid.NewGuid().ToString().ToUpper()
row.Name <- "Megan FOTIO HESS"
row.Birthdate <- "13/02/1990"

ctx.SubmitUpdates()
