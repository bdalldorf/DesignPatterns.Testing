using DesignPatterns.Library.Strategy.Models;
using System.Collections.Generic;

namespace DesignPatterns.Library.Strategy.Strategies
{
    public interface ILetterStrategy
    {
        string LetterText { get; set; }
        void CompanyName();
        void Addressee();
        void CompanyStreetAddress();
        void CompanyStateAddress();
        void CompanyCityAddress();
        void CompanyZipCode();
        void CompanyProducts(List<CompanyProductModel> products);
    }
}
