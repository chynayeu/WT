using Chynayeu90331.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chynayeu90331.Components
{
    public class CartViewComponent : ViewComponent

    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
