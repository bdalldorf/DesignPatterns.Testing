using System.Collections.Generic;

namespace DesignPatterns.Library.AbstractFactory.Models
{
    public class ProductModel
    {
        string Name { get; set; }
        string Description { get; set; }
        string SerialNumber { get; set; }
        public List<WidgetModel> Widgets { get; set; }

        public void AddWidget(WidgetModel widgetModel)
        {
            Widgets?.Add(widgetModel);
        }
    }
}
