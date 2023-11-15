using Microsoft.AspNetCore.Mvc;
namespace GUI.ViewComponents
{
    public class CoursesViewComponent : ViewComponent
    {
      
        public IViewComponentResult Invoke(int Count)
        {
            return View();
        }
    }
}
