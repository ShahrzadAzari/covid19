using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Methods
{
    public class Stats
    {
        public Stats(){}
        public TotalReportModel[] TotalReport {get;set;} = {};
        public NewsResponseModel NewsResponse {get;set;} = null;
        public List<ArticleModel> AllArticles {get;set;} = new List<ArticleModel>();
        public ChartDataModel[] ChartDatas {get;set;} = {};
        public HttpClient Http = new HttpClient();

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
                    response = await Http.SendAsync(httpRequest);
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

        public async Task GetStatistics()
        {
            HttpResponseMessage response = null ;
            try
            {
                var uri = @"https://covid-19-data.p.rapidapi.com/totals" ;
                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(uri),
                    Headers = 
                    {
                        {"x-rapidapi-host", "covid-19-data.p.rapidapi.com"},
                        {"x-rapidapi-key", "2b44e18130mshba82bfb1b3f5a93p1986b1jsnf5816d8a6dd8"},
                    }
                };
                response = await Http.SendAsync(httpRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.TotalReport = response != null ? await response.Content.ReadFromJsonAsync<TotalReportModel[]>() : new TotalReportModel[]{};

            if(this.TotalReport.Length>0)
            {
                this.ChartDatas = new ChartDataModel[] {
                    new ChartDataModel("Confirmed",TotalReport[0].Confirmed),
                    new ChartDataModel("Recovered",TotalReport[0].Recovered),
                    new ChartDataModel("Critical",TotalReport[0].Critical),
                    new ChartDataModel("Deaths",TotalReport[0].Deaths)
                };
            }
        }
    }
}