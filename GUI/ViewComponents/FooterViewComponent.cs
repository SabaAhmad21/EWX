using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
