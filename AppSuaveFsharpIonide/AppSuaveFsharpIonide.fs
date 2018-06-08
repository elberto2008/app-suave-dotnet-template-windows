open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Operators
open Suave.Filters
open OrderContext.RestApi





let app = peopleWebPart
    

let myServerConfig = { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8085 ]}

startWebServer myServerConfig app
