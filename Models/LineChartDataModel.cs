
using System;

namespace BlazorApp.Models
{
    public class LineChartDataModel
    {
        public DateTime Date { get; set; }
        public int Num { get; set; }
        public LineChartDataModel(DateTime date, int number)
        {
            this.Date = date;
            this.Num = number;
        }
    }

}