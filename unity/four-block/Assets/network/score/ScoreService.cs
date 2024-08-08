using System.Net.Http;
using UnityEngine;

namespace network.score
{
    public class ScoreService
    {

        /// <summary>
        /// Submits a user's score to a remote server.
        /// </summary>
        /// <param name="score">The score to be submitted.</param>
        /// <remarks>
        /// This method creates an HTTP POST request to send the specified score to a remote server at the endpoint
        /// "https://liamlime.com/api/user/score/1". It uses an instance of <see cref="HttpRequestFactory"/> to create
        /// the request and sets the score data in JSON format. After executing the request asynchronously, it logs
        /// the server's response using <see cref="Debug.Log"/>. The method does not return any value and operates
        /// asynchronously, meaning that the score submission will not block the calling thread.
        /// </remarks>
        public void SubmitScore(int score)
        {
            var httpRequestFactory = new HttpRequestFactory();
            var postRequest = (HttpPostRequest)httpRequestFactory.CreateHttpRequest(HttpMethod.Post);
            var postResponse = postRequest
                .SetData("{\"score\": "+score+"}")
                .SetClient(new HttpClient())
                .ExecuteAsync("https://liamlime.com/api/user/score/1");
            postResponse.ContinueWith(task =>
            {
                var result = postResponse.Result;
                Debug.Log(result);
            });
        }
    }
}