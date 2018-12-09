using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Library.AbstractFactory.Models
{
    public class WidgetConnectorModel
    {
        public Guid ID { get; set; }
        public WidgetModel WidgetModel1;
        public WidgetModel WidgetModel2;
    }
}
