namespace dotnet_isolated_60
{
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Script;
    using System.Web.Script.Serialization;
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
            JavaScriptSerializer js = new JavaScriptSerializer();
            var str = js.Serialize("hello from the API");
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString(str);
            return response;
        }
    }
}
