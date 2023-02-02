﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewManagingApp.Interfaces
{
    internal interface ICountTotalPrice
    {
        decimal TotalPrice { get; set; }
        public int OrdersCount { get; }
    }
}