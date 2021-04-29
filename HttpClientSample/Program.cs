using System;
using System.Net.Http;

namespace HttpClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var message = new HttpRequestMessage(HttpMethod.Get, "https://microsoft.com");
            HttpContent content = client.Send(message).Content;
        }
    }
}
