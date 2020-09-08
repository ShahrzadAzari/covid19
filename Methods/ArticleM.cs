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
        public NewsResponseModel NewsResponse {get;set;} = null;
        public List<ArticleModel> AllArticles {get;set;} = new List<ArticleModel>();
        public async Task GetArticles()
        {
            String date = DateTime.Today.ToString("yyyy-MM-dd");
            do{
                HttpResponseMessage response = null ;
                try
                {
                    var uri = @"https://newsapi.org/v2/everything?apiKey=4a892542050f40d6a39c3b76785e8240&domains=cnn.com&q=covid vaccine&sortBy=publishedAt&to="+date;
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
                    this.NewsResponse = await response.Content.ReadFromJsonAsync<NewsResponseModel>();

                    foreach(ArticleModel ar in this.NewsResponse.Articles)
                        if(! AllArticles.Contains(ar))
                            this.AllArticles.Add(ar);
                    
                    if(this.NewsResponse.Articles.Length > 0)
                        date = this.NewsResponse.Articles[this.NewsResponse.Articles.Length -1].PublishedAt.ToString("yyyy-MM-dd");
                    else
                        break;
                }

            }while(this.NewsResponse.Articles.Length == 20);
        }
    
    }
}