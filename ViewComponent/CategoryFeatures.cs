using Microsoft.AspNetCore.Mvc;
using Homework2.Models;

namespace Homework2.ViewComponent
{
    public class CategoryFeatures : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}


