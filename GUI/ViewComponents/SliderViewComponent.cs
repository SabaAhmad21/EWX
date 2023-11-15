using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
