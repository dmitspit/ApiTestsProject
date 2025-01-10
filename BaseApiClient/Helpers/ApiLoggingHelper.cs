using RestSharp;

using Serilog;

namespace BaseApiClient.Helpers
{
    public class ApiLoggingHelper
    {
        public static void LogRequest(RestResponse response)
        {
            Log.Information($"Send {response.Request.Method} request");
            LogResponse(response);
            LogResponseHeaders(response);

            if (response.ErrorException is not null || response.ErrorMessage is not null)
            {
                Log.Error(response.ErrorException.Message);
                Log.Error(response.ErrorMessage);
            }
        }

        private static void LogResponse(RestResponse response)
        {
            Log.Information($"Response URI {response.ResponseUri}");
            Log.Information($"Port: {response.ResponseUri.Port}");
            Log.Information($"Content-type: {response.ContentType}");
            Log.Information($"Content length: {response.ContentLength}");
            Log.Information($"Response body: {response.Content}");
            Log.Information($"Response status code: {response.StatusCode}");
        }

        private static void LogResponseHeaders(RestResponse response)
        {
            Log.Debug("Response headers");

            foreach (HeaderParameter header in response.Headers)
            {
                Log.Debug($"name: {header.Name}, value: {header.Value}");
            }
        }
    }
}
