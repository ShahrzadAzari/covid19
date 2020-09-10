
namespace BlazorApp.Models
{
    public class  ArticleResponseModel
    {
        public string Status {get;set;}
        public NewsModel[] News {get;set;}
        public int Page {get;set;}

        
        public ArticleResponseModel()
        {
            this.Status = "";
            this.Page = 0;
            this.News = new NewsModel[]{};
        }
    }
}
