using System;
using System.Collections.Generic;
using Online_ShoppingCart.Models;

namespace Online_ShoppingCart.ModelViews
{
    public class HomeViewVM
    {
        public List<TinDang> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
