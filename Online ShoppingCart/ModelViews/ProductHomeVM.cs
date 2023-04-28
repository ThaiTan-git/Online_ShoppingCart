using System;
using System.Collections.Generic;
using Online_ShoppingCart.Models;

namespace Online_ShoppingCart.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
