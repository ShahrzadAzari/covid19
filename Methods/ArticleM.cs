using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Methods
{
    public class ArticleM
    {
        private HttpClient _http;
        public ArticleM(HttpClient http)
        {
            _http = http;
        }
        public ArticleResponseModel NewsResponse {get;set;} = new ArticleResponseModel();
        public List<NewsModel> AllArticles {get;set;} = new List<NewsModel>();
        public async Task GetArticles()
        {
            HttpResponseMessage response = null;
            try
            {
                var uri = @"https://api.currentsapi.services/v1/search?keywords=covid vaccine&apiKey=A08cvp0C7ijWVyAH95_T4E-G9jJP_fbq-Ufa9qeyEJMVnowN";
                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(uri),
                };
                response = await _http.SendAsync(httpRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if(response != null)
            {
                this.NewsResponse = await response.Content.ReadFromJsonAsync<ArticleResponseModel>();

                foreach(NewsModel ar in this.NewsResponse.News)
                    if(! AllArticles.Contains(ar))
                        this.AllArticles.Add(ar);
            }
        }
    
    }
}