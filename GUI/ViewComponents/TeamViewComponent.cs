using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class TeamViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
