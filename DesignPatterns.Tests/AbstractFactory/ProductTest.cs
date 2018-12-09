using DesignPatterns.Library.AbstractFactory;
using DesignPatterns.Library.AbstractFactory.Factories;
using DesignPatterns.Library.AbstractFactory.Models;
using NUnit.Framework;

namespace DesignPatterns.Tests.AbstractFactory
{
    class ProductTest
    {
        [TestFixture]
        public class ProductFactoryTest
        {
            private readonly ProductBuilder _ProductBuilder;

            public ProductFactoryTest()
            {
                _ProductBuilder = new ProductBuilder();
            }

            [Test]
            public void ReturnTrueIfProductIsSetUpCorrectly()
            {
                ProductAFactory l_ProductFactory = new ProductAFactory();
                ProductModel ProductModel = _ProductBuilder.CreateProduction(l_ProductFactory);

                Assert.IsTrue(ProductModel.Widgets.Count == 2);

                WidgetModel WidgetModel1 = ProductModel.Widgets[0];
                WidgetModel WidgetModel2 = ProductModel.Widgets[1];

                Assert.AreEqual(WidgetModel1.WidgetShape, WidgetShape.Square);
                Assert.AreEqual(WidgetModel1.WidgetColor, WidgetColor.Gray);
                Assert.AreEqual(WidgetModel1.WidgetSize, WidgetSize.Large);

                Assert.AreEqual(WidgetModel2.WidgetShape, WidgetShape.Circle);
                Assert.AreEqual(WidgetModel2.WidgetColor, WidgetColor.Red);
                Assert.AreEqual(WidgetModel2.WidgetSize, WidgetSize.Medium);

                Assert.IsTrue(l_ProductFactory.DoesConnectionAlreadyExist(WidgetModel1, WidgetModel2));
            }

            [Test]
            public void ReturnTrueIfProductBIsSetUpCorrectly()
            {
                ProductBFactory l_ProductFactory = new ProductBFactory();
                ProductModel ProductModel = _ProductBuilder.CreateProduction(l_ProductFactory);

                Assert.IsTrue(ProductModel.Widgets.Count == 2);

                WidgetBModel WidgetModel1 = (WidgetBModel)ProductModel.Widgets[0];
                WidgetBModel WidgetModel2 = (WidgetBModel)ProductModel.Widgets[1];

                Assert.AreEqual(WidgetModel1.WidgetShape, WidgetShape.Square);
                Assert.AreEqual(WidgetModel1.WidgetColor, WidgetColor.Gray);
                Assert.AreEqual(WidgetModel1.WidgetSize, WidgetSize.Large);

                Assert.AreEqual(WidgetModel2.WidgetShape, WidgetShape.Circle);
                Assert.AreEqual(WidgetModel2.WidgetColor, WidgetColor.Red);
                Assert.AreEqual(WidgetModel2.WidgetSize, WidgetSize.Medium);

                Assert.IsTrue(l_ProductFactory.DoesConnectionAlreadyExist(WidgetModel1, WidgetModel2));

                Assert.AreEqual(WidgetModel1.AddtionalInformation, "This is Widgit B");
                Assert.AreEqual(WidgetModel2.AddtionalInformation, "This is Widgit B");
            }
        }
    }
}
