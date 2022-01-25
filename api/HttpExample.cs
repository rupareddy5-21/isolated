namespace dotnet_isolated_60
{
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    using Microsoft.Azure.Functions.Worker;

    using Microsoft.Azure.Functions.Worker.Http;

    using Microsoft.Extensions.Logging;


    public static class HttpExample
    {
        [Function("HttpExample")]
        public static HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
string date = "2022-01-25T05:04:59.251Z";

            response.WriteString(date);
            return response;
        }
    }
}
