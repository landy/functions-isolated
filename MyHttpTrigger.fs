namespace functest.Triggers
open System.Collections.Generic
open System.Net
open Microsoft.Azure.Functions.Worker
open Microsoft.Azure.Functions.Worker.Http
open Microsoft.Extensions.Logging


type MyHttpTrigger() =

    [<Function("MyHttpTrigger")>]
    member _.myHttpTrigger
        ([<HttpTrigger(AuthorizationLevel.Function, "get", Route = "myTest")>] req: HttpRequestData, executionContext: FunctionContext) =
        "hello"
