using DesignPatterns.Library.Mediator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Library.Mediator
{
    public class TicketMediator
    {
        public PersonModel PersonModel = null;
        public TicketModel TicketModel = null;

        public TicketMediator(PersonModel personModel, TicketModel ticketModel)
        {
            PersonModel = personModel;
            TicketModel = ticketModel;
        }

        public decimal GetTicketPrice()
        {
            if (!IsEligibleToAttend()) return 0.00m;

            if (PersonModel.Age >= 65)
                return TicketModel.SeniorAdmission;
            if (PersonModel.Age <= 12)
                return TicketModel.ChildAdmission;

            return TicketModel.GeneralAdmission;
        }

        public bool IsEligibleToAttend()
        {
            return (PersonModel.Age >= TicketModel.MinimumAge);
        }
    }
}
