using System;
using System.Collections.Generic;

namespace DesignPatterns.Library.AbstractFactory.Models
{
    public class WidgetModel
    {
        public Guid ID { get; set; }
        public WidgetShape WidgetShape { get; set; }
        public WidgetSize WidgetSize { get; set; }
        public WidgetColor WidgetColor { get; set; }
        public List<WidgetConnectorModel> Connectors { get; set; }

        public void AddComponent(WidgetConnectorModel componentModel)
        {
            Connectors?.Add(componentModel);
        }
    }
}
