using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace network
{
    public class HttpGetRequest : IHttpRequest
    {
        private static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// Asynchronously sends a POST request to the specified URL with JSON content and returns the response body as a string.
        /// </summary>
        /// <param name="url">The URL to which the POST request will be sent.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response body as a string.</returns>
        /// <remarks>
        /// This method creates a JSON payload from the instance variable <c>_data</> and sends it to the specified <paramref name="url"/> using an HTTP POST request.
        /// It uses the <c>HttpClient</c> class to perform the request and ensures that the response indicates success by calling <c>EnsureSuccessStatusCode</c>.
        /// If the response is successful, it reads the content of the response as a string and returns it.
        /// This method is intended for use in scenarios where an asynchronous operation is preferred, allowing for non-blocking execution.
        /// </remarks>
        public async Task<string> ExecuteAsync(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
    
    public class HttpPostRequest : IHttpRequest
    {
        private HttpClient _client = new HttpClient();
        private string _data = "";

        public async Task<string> ExecuteAsync(string url)
        {
            var content = new StringContent(_data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        /// <summary>
        /// Sets the data for the HTTP POST request.
        /// </summary>
        /// <param name="data">The data to be set for the request.</param>
        /// <returns>The current instance of <see cref="HttpPostRequest"/> with the updated data.</returns>
        /// <remarks>
        /// This method allows you to specify the data that will be sent with the HTTP POST request.
        /// By calling this method, you can set the content that will be included in the body of the request.
        /// The method modifies the internal state of the <see cref="HttpPostRequest"/> instance by updating its
        /// private field <c>_data</c> with the provided string.
        /// It returns the same instance of <see cref="HttpPostRequest"/> to allow for method chaining,
        /// enabling a more fluent interface when configuring the request.
        /// </remarks>
        public HttpPostRequest SetData(string data)
        {
            this._data = data;
            return this;
        }

        /// <summary>
        /// Sets the HttpClient instance for the current request.
        /// </summary>
        /// <param name="client">The HttpClient instance to be set.</param>
        /// <returns>The current instance of HttpPostRequest for method chaining.</returns>
        /// <remarks>
        /// This method assigns the provided <paramref name="client"/> to the private field _client of the HttpPostRequest class.
        /// It allows for configuring the HttpClient that will be used for making HTTP requests.
        /// By returning the current instance, this method supports a fluent interface, enabling method chaining for cleaner and more readable code.
        /// </remarks>
        public HttpPostRequest SetClient(HttpClient client)
        {
            this._client = client;
            return this;
        }
    }
}