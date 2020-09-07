
namespace BlazorApp.Models
{
    public class NewsResponseModel
    {
        public string Status {get;set;}
        public int TotalResult {get;set;}
        public ArticleModel[] Articles {get;set;}
    }
}
