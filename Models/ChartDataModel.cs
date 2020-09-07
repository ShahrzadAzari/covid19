namespace BlazorApp.Models
{
    public class ChartDataModel
    {
        public string Title {get;set;}
        public int Number {get;set;}
        public ChartDataModel(string title, int number)
        {
            this.Title = title;
            this.Number = number;
        }
    }
}