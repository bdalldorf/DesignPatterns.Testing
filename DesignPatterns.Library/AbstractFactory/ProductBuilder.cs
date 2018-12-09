using DesignPatterns.Library.AbstractFactory.Factories;
using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Library.AbstractFactory
{
    public class ProductBuilder
    {
        public ProductModel CreateProduction(IProductFactory productFactory)
        {
            ProductModel ProductModel = productFactory.MakeProduct();
            WidgetModel Widget1 = productFactory.MakeWidget(WidgetShape.Square, WidgetColor.Gray, WidgetSize.Large);
            WidgetModel Widget2 = productFactory.MakeWidget(WidgetShape.Circle, WidgetColor.Red, WidgetSize.Medium);
            productFactory.ConnectWidgets(Widget1, Widget2);

            ProductModel.AddWidget(Widget1);
            ProductModel.AddWidget(Widget2);

            return ProductModel;
        }
    }
}
