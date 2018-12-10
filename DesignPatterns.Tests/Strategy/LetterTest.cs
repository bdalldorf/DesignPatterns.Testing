using DesignPatterns.Library.Strategy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
            public void ReturnFalseIfTheTextDoesntContainTemplateFields(Company value)
            {
                string l_LetterText = CreateLetter.GenerateCustomLetter("../../../../DesignPatterns.Library/Strategy/Letter.txt", value);

                Assert.True(l_LetterText.Length > 0);

                Type Type = typeof(TemplateFields);
                foreach (var Field in Type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public))
                {
                    var Value = Field.GetValue(null);
                    Assert.False(l_LetterText.Contains(Value.ToString()));
                }
            }
        }
    }
}
