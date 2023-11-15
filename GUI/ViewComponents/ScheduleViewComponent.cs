using Microsoft.AspNetCore.Mvc;

namespace GUI.ViewComponents
{
    public class ScheduleViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
