using DesignPatterns.Library.Strategy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Tests.Strategy
{
    class LetterTest
    {
        [TestFixture]
        public class LetterStrategyTest
        {
            public LetterStrategyTest(){}
             
            [TestCase(Company.Foo)]
            [TestCase(Company.Bar)]
            [TestCase(Company.Baz)]
            public void ReturnFalseIfTheTextDoesntContainTemplateFields(Company company)
            {
                string FilePath = "../../../../DesignPatterns.Library/Strategy/Letter.txt";
                string LetterText = string.Empty;
                Type TemplateFieldType = typeof(TemplateFields);

                Assert.True(File.Exists(FilePath));

                LetterText = CreateLetter.GenerateCustomLetter(FilePath, company);

                foreach (var Field in TemplateFieldType.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public))
                {
                    var Value = Field.GetValue(null);
                    Assert.False(LetterText.Contains(Value.ToString()));
                }
            }
        }
    }
}
