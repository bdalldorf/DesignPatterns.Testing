using DesignPatterns.Library.Strategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.Library.Strategy.Strategies
{
    public class CompanyFooStrategy : ILetterStrategy
    {
        public string LetterText { get; set; }

        public CompanyFooStrategy(string filePath)
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
            LetterText = LetterText.Replace(TemplateFields.CompanyName, "Foo Incorporated");
        }

        public void Addressee()
        {
            LetterText = LetterText.Replace(TemplateFields.Addressee, "Mr. Foo");
        }

        public void CompanyCityAddress()
        {
            LetterText = LetterText.Replace(TemplateFields.CompanyCityAddress, "Foo Town");
        }

        public void CompanyStateAddress()
        {
            LetterText = LetterText.Replace(TemplateFields.CompanyStateAddress, "CA");
        }

        public void CompanyStreetAddress()
        {
            LetterText = LetterText.Replace(TemplateFields.CompanyStreetAddress, "123 Foo Ave.");
        }

        public void CompanyZipCode()
        {
            LetterText = LetterText.Replace(TemplateFields.CompanyZipCode, "95641");
        }

        public void CompanyProducts(List<CompanyProductModel> products)
        {
            StringBuilder l_StringBuilder = new StringBuilder();
            List<CompanyProductModel> CompanyFooProducts = products.FindAll(companyProductModel => 
                companyProductModel.FK_comID_Company == (int)Company.Foo);

            foreach  (CompanyProductModel CompanyProduct in CompanyFooProducts)
            {
                l_StringBuilder.AppendLine($"\\u {CompanyProduct.Name}: ${CompanyProduct.Price}");
            }

            LetterText = LetterText.Replace(TemplateFields.ProductsOffered, l_StringBuilder.ToString());
        }
    }
}
