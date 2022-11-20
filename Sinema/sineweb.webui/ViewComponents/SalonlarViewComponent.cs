using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sineweb.webui.Data;

namespace sineweb.webui.ViewComponents
{
    public class SalonlarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(SalonRepository.Salonlar);
        }
    }
}