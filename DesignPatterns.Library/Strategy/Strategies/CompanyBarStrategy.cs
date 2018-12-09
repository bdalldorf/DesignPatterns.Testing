using DesignPatterns.Library.Strategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Library.Strategy.Strategies
{
    public class CompanyBarStrategy : ILetterStrategy
    {
        public string LetterText { get; set; }

        public CompanyBarStrategy(string filePath)
        {
            if (!File.Exists(filePath)) throw new Exception($"The file {filePath} doesn't exist");

            LetterText = new StreamReader(filePath).ReadToEnd();
            CompanyName();
            Addressee();
            CompanyCityAddress();
            CompanyStateAddress();
            CompanyStreetAddress();
            CompanyZipCode();
        }

        public void CompanyName()
        {
            LetterText = LetterText.Replace(FileFields.CompanyName, "Bar Incorporated");
        }

        public void Addressee()
        {
            LetterText = LetterText.Replace(FileFields.Addressee, "Mr. Bar");
        }

        public void CompanyCityAddress()
        {
            LetterText = LetterText.Replace(FileFields.CompanyCityAddress, "Bar Town");
        }

        public void CompanyStateAddress()
        {
            LetterText = LetterText.Replace(FileFields.CompanyStateAddress, "CA");
        }

        public void CompanyStreetAddress()
        {
            LetterText = LetterText.Replace(FileFields.CompanyStreetAddress, "123 Bar Ave.");
        }

        public void CompanyZipCode()
        {
            LetterText = LetterText.Replace(FileFields.CompanyZipCode, "68518");
        }

        public void CompanyProducts(List<CompanyProductModel> products)
        {
            StringBuilder l_StringBuilder = new StringBuilder();
            List<CompanyProductModel> CompanyBarProducts = products.FindAll(companyProductModel =>
                companyProductModel.FK_comID_Company == (int)Company.Bar);

            foreach (CompanyProductModel CompanyProduct in CompanyBarProducts)
            {
                l_StringBuilder.AppendLine($"\\u {CompanyProduct.Name}: ${CompanyProduct.Price}");
            }

            LetterText = LetterText.Replace(FileFields.ProductsOffered, l_StringBuilder.ToString());
        }
    }
}
