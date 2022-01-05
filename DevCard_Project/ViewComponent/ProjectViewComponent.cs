using System.Collections.Generic;
using Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev.ViewComponent
{
    public class ProjectViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private List<Project> projects = new List<Project>
        {
            new Project(1,"موبایل","project-1.jpg","خرید و فروش  گوشی های پرچم دار را به بهترین شکل با ما تجربه کنید ","Mobile-Shop"),
            new Project(2,"تعمییرات","project-2.jpg","تعمییرات کلالی دیجیتال خود را به بهترین شکل با ما تجربه کنید ","Mohsen-Shah"),
            new Project(3,"تاکسی","project-3.jpg","سفر های درون شهری را به بهترین شکل با ما تجربه کنید ","Snap"),
            new Project(4,"توسعه نرم افزار","project-4.jpg","توسعه نرم افزار های خود را به بهترین شکل با ما تجربه کنید ","Programmer")
        };
        public IViewComponentResult Invoke()
        {
            return View("_Project",projects);
        }
    }
}
