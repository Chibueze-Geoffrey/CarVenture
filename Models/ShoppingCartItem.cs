﻿using EzeCarVentures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzeCarVentures.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Car Car { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
