﻿using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuotes();
            QuoteGenerator.RonQuotes();

            QuoteGenerator.KanyeQuotes();
            QuoteGenerator.RonQuotes();

            QuoteGenerator.KanyeQuotes();
            QuoteGenerator.RonQuotes();

        }
    }
   
}
