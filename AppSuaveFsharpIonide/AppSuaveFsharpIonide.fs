open Suave                 // always open suave
open OrderContext.RestApi





let app = placeOrderWebPart
    

let myServerConfig = { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8085 ]}

startWebServer myServerConfig app
