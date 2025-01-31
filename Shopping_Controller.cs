// Create a controller named Shopping and inside the controller, define an action method called AddToCart.

[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddToCart(CartItems items)
        {
         // Your code here   
            }

            return PartialView();
        }