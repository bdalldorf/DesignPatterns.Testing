using DesignPatterns.Library.Strategy.Models;
using System.Collections.Generic;

namespace DesignPatterns.Library.Strategy
{
    public static class CompanyProducts
    {
        public static List<CompanyProductModel> Products
        {
            get
            {
                return new List<CompanyProductModel>()
                {
                   new CompanyProductModel()
                    {
                        ID = 1,
                        FK_comID_Company = (int)Company.Foo,
                        Name = "Foo Product 1",
                        Price = 5.25m
                    },
                    new CompanyProductModel()
                    {
                        ID = 2,
                        FK_comID_Company = (int)Company.Foo,
                        Name = "Foo Product 2",
                        Price = 3.25m
                    },
                    new CompanyProductModel()
                    {
                        ID = 3,
                        FK_comID_Company = (int)Company.Bar,
                        Name = "Bar Product 1",
                        Price = 2.35m
                    },
                    new CompanyProductModel()
                    {
                        ID = 4,
                        FK_comID_Company = (int)Company.Bar,
                        Name = "Bar Product 2",
                        Price = 6.75m
                    },
                    new CompanyProductModel()
                    {
                        ID = 5,
                        FK_comID_Company = (int)Company.Baz,
                        Name = "Baz Product 1",
                        Price = 10.50m
                    },
                    new CompanyProductModel()
                    {
                        ID = 6,
                        FK_comID_Company = (int)Company.Baz,
                        Name = "Baz Product 2",
                        Price = 3.80m
                    },
                };
            }
        }
    }
}
