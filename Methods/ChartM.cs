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
        public ChartM(){}
        public HttpClient Http = new HttpClient();
        public TotalReportModel[] TotalReport {get;set;} = {};
        public ChartDataModel[] ChartDatas {get;set;} = {};
        public TotalReportModel[] ThisDayReport {get;set;} = {};
        public List<LineChartDataModel> AllDeathData {get;set;} = new List<LineChartDataModel>();
        public List<LineChartDataModel> AllConfirmedData {get;set;} = new List<LineChartDataModel>();
        public List<LineChartDataModel> AllCritialData {get;set;} = new List<LineChartDataModel>();
        public List<LineChartDataModel> AllRecoveredData {get;set;} = new List<LineChartDataModel>();
        
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


        public async Task GetCasesByDate()
        {
            DateTime date = new DateTime(2020,02,01);

            do{
                HttpResponseMessage response = null ;
                try
                {

                    var uri = @"https://covid-19-data.p.rapidapi.com/report/totals?date-format=YYYY-MM-DD&format=json&date=" + date.ToString("yyyy-MM-dd");
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
                this.ThisDayReport = response != null ? await response.Content.ReadFromJsonAsync<TotalReportModel[]>() : new TotalReportModel[]{};
                if(this.ThisDayReport.Length>0)
                {
                    this.AllDeathData.Add(new LineChartDataModel(date, ThisDayReport[0].Deaths ));
                    this.AllConfirmedData.Add(new LineChartDataModel(date, ThisDayReport[0].Confirmed ));
                    this.AllCritialData.Add(new LineChartDataModel(date, ThisDayReport[0].Critical ));
                    this.AllRecoveredData.Add(new LineChartDataModel(date, ThisDayReport[0].Recovered ));
                }
                date.AddMonths(1);

            }while(ThisDayReport.Length>0);
        }
    }
}