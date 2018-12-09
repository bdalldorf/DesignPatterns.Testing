using DesignPatterns.Library.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Library.AbstractFactory.Factories
{
    public interface IProductFactory
    {
        ProductModel MakeProduct();
        WidgetModel MakeWidget(WidgetShape widgetShape, WidgetColor widgetColor, WidgetSize widgetSize);
        WidgetConnectorModel ConnectWidgets(WidgetModel widgetModel1, WidgetModel widgetModel2);
    }
}
