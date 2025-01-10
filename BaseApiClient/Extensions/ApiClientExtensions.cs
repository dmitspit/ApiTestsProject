using BaseApiClient.Helpers;

using RestSharp;

using System.Net;

namespace BaseApiClient.Extensions
{
    public static class ApiClientExtensions
    {
        public static RestResponse<T> GetRequest<T>(this RestClient client, RestRequest request)
        {
            RestResponse<T> response = client.ExecuteGet<T>(request);
            ApiLoggingHelper.LogRequest(response);
            return response;
        }

        public static RestResponse<T> PostRequest<T>(this RestClient client, RestRequest request)
        {
            RestResponse<T> response = client.ExecutePost<T>(request);
            ApiLoggingHelper.LogRequest(response);
            return response;
        }

        public static HttpStatusCode PostRequest(this RestClient client, RestRequest request)
        {
            var response = client.ExecutePost(request);
            ApiLoggingHelper.LogRequest(response);
            return response.StatusCode;
        }

        public static RestResponse<T> PutRequest<T>(this RestClient client, RestRequest request)
        {
            RestResponse<T> response = client.ExecutePut<T>(request);
            ApiLoggingHelper.LogRequest(response);
            return response;
        }

        public static RestResponse PutRequest(this RestClient client, RestRequest request)
        {
            RestResponse response = client.ExecutePut(request);
            ApiLoggingHelper.LogRequest(response);
            return response;
        }

        public static RestResponse<T> DeleteRequest<T>(this RestClient client, RestRequest request)
        {
            RestResponse<T> response = client.Execute<T>(request);
            ApiLoggingHelper.LogRequest(response);
            return response;
        }

        public static HttpStatusCode DeleteRequest(this RestClient client, RestRequest request)
        {
            RestResponse response = client.Execute(request);
            ApiLoggingHelper.LogRequest(response);
            return response.StatusCode;
        }
    }
}