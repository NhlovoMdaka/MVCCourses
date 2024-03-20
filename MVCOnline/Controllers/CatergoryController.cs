using Microsoft.AspNetCore.Mvc;

namespace MVCOnline.Controllers
{
    public class CatergoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int ? id)
        {
            if (id.HasValue)
                return new ContentResult { Content = id.ToString() };
            else
                return new ContentResult { Content = "Not Found Content" };
        }
    }
}
