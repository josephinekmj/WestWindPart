﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindSpareParts
{
    public class Product
    {
        public string SupplierProductNumber { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public double DefaultUnitPriceDKK { get; set; }
        public double MarkUpPercentage { get; set; }
        public string Category {  get; set; } // new eller renovated evt bool
        public int LeedTimeWeeks { get; set; }
        public string UnitOfMeasure { get; set; } //kg, units, box
    



    
    }
}
