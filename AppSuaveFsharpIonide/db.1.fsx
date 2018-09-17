#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }


                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }

                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }

                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }

                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }
"adl4"; City = "c"; ZipCode = "z"}
                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }
"adl4"; City = "c"; ZipCode = "z"}
                                  #r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }

                                 }#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }

type UnvalidatedCustomerInfo = {
    FirstName : string
    LastName : string
    EmailAddress : string
    }

type UnvalidatedAddress = {
    AddressLine1 : string
    AddressLine2 : string
    AddressLine3 : string
    AddressLine4 : string
    City : string
    ZipCode : string
    }

type UnvalidatedOrderLine =  {
    OrderLineId : string
    ProductCode : string
    Quantity : decimal
    }

type UnvalidatedOrder = {
    Id : BsonObjectId
    OrderId : string
    CustomerInfo : UnvalidatedCustomerInfo
    ShippingAddress : UnvalidatedAddress
    BillingAddress : UnvalidatedAddress
    Lines : UnvalidatedOrderLine list
    }


let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let movieDb = client.GetDatabase("MoviesDb")

let orderDb = client.GetDatabase("OrderDb")
 
//let collection = movieDb.GetCollection<Movie> "movies"


let insertMovieCollection = movieDb.GetCollection<Movie> "movies"
 
 
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertMovieCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }



let insertOrdersCollection = orderDb.GetCollection<UnvalidatedOrder> "orders"
 

 
insertOrdersCollection.InsertOne { 
                                   Id = BsonObjectId(ObjectId.GenerateNewId()) 
                                   OrderId = "1"
                                   CustomerInfo = {FirstName = "f"; LastName = "l"; EmailAddress = "email"}
                                   ShippingAddress = {AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   BillingAddress = { AddressLine1 = "adl1"; AddressLine2 = "adl2";  AddressLine3 = "adl3";  AddressLine4 = "adl4"; City = "c"; ZipCode = "z"}
                                   Lines = [{ OrderLineId = "id";  ProductCode = "pc"; Quantity = 10.9M}]
                                 }

