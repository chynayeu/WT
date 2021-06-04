using Microsoft.AspNetCore.Mvc;

namespace Chynayeu90331.Components
{
    public class CartViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
