using System;
using System.Net.Http;

namespace network
{
    public class HttpRequestFactory
    {

        /// <summary>
        /// Creates an HTTP request based on the specified request type.
        /// </summary>
        /// <param name="requestType">The HTTP method to be used for the request, such as GET or POST.</param>
        /// <returns>An instance of <see cref="IHttpRequest"/> corresponding to the specified request type.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided <paramref name="requestType"/> is not supported.</exception>
        /// <remarks>
        /// This method generates an HTTP request object based on the specified <paramref name="requestType"/>.
        /// If the request type is GET, it creates an instance of <see cref="HttpGetRequest"/>.
        /// If the request type is POST, it creates an instance of <see cref="HttpPostRequest"/>.
        /// If the request type is neither GET nor POST, an <see cref="ArgumentException"/> is thrown, indicating that the request type is invalid.
        /// This method is useful for encapsulating the creation of different types of HTTP requests in a single method, promoting code reusability and maintainability.
        /// </remarks>
        public IHttpRequest CreateHttpRequest(HttpMethod requestType)
        {
            if (requestType == HttpMethod.Get)
            {
                return new HttpGetRequest();
            }
            else if (requestType == HttpMethod.Post)
            {
                return new HttpPostRequest();
            }
            else
            {
                throw new ArgumentException("Invalid request type");
            }
        }
    }
}