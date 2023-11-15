using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class ContactViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
