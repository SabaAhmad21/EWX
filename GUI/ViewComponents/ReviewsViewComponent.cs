using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class ReviewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
