using Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponent
{
    public class LatestArticlesViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"فروش موبایل","فروش اقساطی موبایل","blog-post-thumb-card-1.jpg"),
                new Article(2,"فروش لپ تاپ","فروش اقساطی لپ تاپ","blog-post-thumb-card-2.jpg"),
                new Article(3,"فروش تلویزیون","فروش اقساطی تلویزیون","blog-post-thumb-card-3.jpg"),
            };
            return View("_LatestArticles",article);
        }
    }
}
