﻿using System;
using System.Collections.Generic;

namespace EntityFramework;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
