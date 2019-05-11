using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Library.AbstractFactory.Models;

namespace DesignPatterns.Library.AbstractFactory.Factories
{
    public class ProductAFactory : IProductFactory
    {
        public ProductModel MakeProduct()
        {
            return new ProductModel()
            {
                Widgets = new List<WidgetModel>()
            };
        }

        /// <summary>
        /// Will return an empty WidgetConnectorModel if a connection already exists between wigits.
        /// </summary>
        /// <param name="widgetModel1"></param>
        /// <param name="widgetModel2"></param>
        /// <returns></returns>
        public WidgetConnectorModel ConnectWidgets(WidgetModel widgetModel1, WidgetModel widgetModel2)
        {
            if (DoesConnectionAlreadyExist(widgetModel1, widgetModel2)) return new WidgetConnectorModel();

            WidgetConnectorModel l_WidgetConnectorModel = new WidgetConnectorModel()
            {
                ID = Guid.NewGuid(),
                WidgetModel1 = widgetModel1,
                WidgetModel2 = widgetModel2
            };

            widgetModel1.AddComponent(l_WidgetConnectorModel);
            widgetModel2.AddComponent(l_WidgetConnectorModel);

            return l_WidgetConnectorModel;
        }

        public WidgetModel MakeWidget(WidgetShape widgetShape, WidgetColor widgetColor, WidgetSize widgetSize)
        {
            return new WidgetAModel()
            {
                ID = Guid.NewGuid(),
                WidgetShape = widgetShape,
                WidgetColor = widgetColor,
                WidgetSize = widgetSize,
                Connectors = new List<WidgetConnectorModel>()
            };
        }

        public bool DoesConnectionAlreadyExist(WidgetModel widgetModel1, WidgetModel widgetModel2)
        {
            // If a connection is already setup across widgets return true
            return (widgetModel1.Connectors.Any(connector => connector.WidgetModel1.ID == widgetModel2.ID ||
                    connector.WidgetModel2.ID == widgetModel2.ID));
        }
    }
}
