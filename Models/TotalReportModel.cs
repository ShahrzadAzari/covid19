using System;

namespace BlazorApp.Models
{
    public class TotalReportModel
    {
        public int Confirmed {get;set;}
        public int Recovered {get;set;}
        public int Critical {get;set;}
        public int Deaths {get;set;}
        public DateTime LastUpdate {get;set;}
    }
}