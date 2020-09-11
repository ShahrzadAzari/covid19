using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Methods
{
    public class ChartM
    {    
        private HttpClient _http;
        public ChartM(HttpClient http)
        {
            _http = http;
        }
        public TotalReportModel[] TotalReport {get;set;} = {};
        public ChartDataModel[] ChartDatas {get;set;} = {};
        
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
                response = await _http.SendAsync(httpRequest);
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