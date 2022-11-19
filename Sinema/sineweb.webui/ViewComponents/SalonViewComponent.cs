using Microsoft.AspNetCore.Mvc;
using sineweb.webui.Data;

namespace sineweb.webui.ViewComponents
{
    public class SalonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(SalonRepository.Salonlar);
        }
    }
}