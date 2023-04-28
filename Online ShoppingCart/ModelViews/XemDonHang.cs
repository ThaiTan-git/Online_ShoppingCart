using System;
using System.Collections.Generic;
using Online_ShoppingCart.Models;

namespace Online_ShoppingCart.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
