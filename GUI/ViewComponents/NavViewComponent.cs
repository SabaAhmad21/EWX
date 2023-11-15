using Microsoft.AspNetCore.Mvc;
namespace GUI.ViewComponents
{
    public class NavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int Count)
        {
            return View();

        }




    }
}
