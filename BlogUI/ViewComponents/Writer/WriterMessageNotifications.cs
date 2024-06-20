using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Writer
{
    public class WriterMessageNotifications : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
