using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Library.Strategy.Models
{
    public class CompanyProductModel
    {
        public int ID { get; set; }
        public int FK_comID_Company { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
