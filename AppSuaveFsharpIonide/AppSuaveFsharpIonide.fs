open Suave                 // always open suave
open Suave.Logging
open Suave.Filters
open Suave.Operators

open OrderContext.RestApi



let logger = Logging.Targets.create Logging.Info [| "Suave" |]
let serverConfig =
        { defaultConfig with
            logger = Targets.create LogLevel.Debug [|"ServerCode"; "Server" |]
            bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8085 ] }


let app = placeOrderWebPart >=> logWithLevelStructured Logging.Debug logger logFormatStructured

    

let myServerConfig = { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8085 ]}

startWebServer serverConfig app
