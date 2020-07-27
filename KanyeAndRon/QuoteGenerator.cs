using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public QuoteGenerator()
        {
        }

        public static void KanyeQuotes()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Kanye says: {kanyeQuote}");
            Console.WriteLine("--------------------------------------");
        }

        public static void RonQuotes()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            
            Console.WriteLine($"Ron responds with: {ronQuote}");
            Console.WriteLine("--------------------------------------");


        }
    }
}
