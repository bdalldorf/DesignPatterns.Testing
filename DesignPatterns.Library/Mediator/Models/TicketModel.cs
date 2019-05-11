using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Library.Mediator.Models
{
    public class TicketModel
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public int MinimumAge { get; set; }
        public decimal GeneralAdmission { get; set; }
        public decimal SeniorAdmission { get; set; }
        public decimal ChildAdmission { get; set; }

    }
}
