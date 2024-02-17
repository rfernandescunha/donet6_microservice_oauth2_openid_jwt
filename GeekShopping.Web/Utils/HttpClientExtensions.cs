using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace GeekShopping.Web.Utils
{
    public static class HttpClientExtensions
    {
        private static MediaTypeHeaderValue _contentType = new MediaTypeHeaderValue("application/json");
        
        public static async Task<T> GetAsync<T>(this HttpClient httpClient, string urlClient) 
        {
            var response = await httpClient.GetAsync(urlClient);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Somenthing went wrong calling the api: {response.ReasonPhrase}");
            }

            var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }


        //public static async Task<T> GetAsync<T>(this HttpClient httpClient, string urlClient, T dataClient)
        //{
        //    var data = JsonSerializer.Serialize(dataClient);
        //    var content = new StringContent(data);
        //    content.Headers.ContentType = _contentType;

        //    var response = await httpClient.GetAsync(urlClient, content);

        //    if (response. ReadAsStringAsync().GetAwaiter().GetResult().sta)
        //    {
        //        throw new ApplicationException($"Somenthing went wrong calling the api: {response.ReasonPhrase}");
        //    }

        //    return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        //}

        public static async Task<T> PostAsync<T>(this HttpClient httpClient, string urlClient, T dataClient)
        {
            var data = JsonSerializer.Serialize(dataClient);
            var content = new StringContent(data);
            content.Headers.ContentType = _contentType;

            var response = await httpClient.PostAsync(urlClient, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Somenthing went wrong calling the api: {response.ReasonPhrase}");
            }

            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        }

        public static async Task<T> PutAsync<T>(this HttpClient httpClient, string urlClient, T dataClient)
        {
            var data = JsonSerializer.Serialize(dataClient);
            var content = new StringContent(data);
            content.Headers.ContentType = _contentType;

            var response = await httpClient.PutAsync(urlClient, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Somenthing went wrong calling the api: {response.ReasonPhrase}");
            }

            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public static async Task<T> ReadContentAs<T>(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Somenthing went wrong calling the api: {response.ReasonPhrase}");
            }


            var data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<T>(data, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
