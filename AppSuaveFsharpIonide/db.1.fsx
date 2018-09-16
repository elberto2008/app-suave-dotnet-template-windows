#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver/lib/net45/MongoDB.Driver.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Driver.Core/lib/net45/MongoDB.Driver.Core.dll"
 
#r "/home/el/Documents/app-code/training/felicien-test/order-taking-app/app-suave-ionide-template-ubuntu/packages/MongoDB.Bson/lib/net45/MongoDB.Bson.dll"

open MongoDB.Bson
 
open MongoDB.Driver


type Movie = { Id : BsonObjectId; Title : string; Score : float }



let connectionString = "mongodb://localhost"
 
let client = new MongoClient(connectionString)
 
let db = client.GetDatabase("MoviesDb")
 
let collection = db.GetCollection<Movie> "movies"


let insertCollection = db.GetCollection<Movie> "movies"
 
 
insertCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Gladiator"; Score = 5.8 }
insertCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avengers: Infinity War"; Score = 6.2 }
insertCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "The good, the Bad and the mighty"; Score = 9.5 }
insertCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Star Wars"; Score = 9.3 }
insertCollection.InsertOne { Id = BsonObjectId(ObjectId.GenerateNewId()); Title = "Avatar: The darwn"; Score = 10.0 }
