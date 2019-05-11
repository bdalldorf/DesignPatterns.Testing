using DesignPatterns.Library.Mediator.Models;
using DesignPatterns.Library.Mediator;
using NUnit.Framework;

namespace DesignPatterns.Tests.Mediator
{
    class MediatorTest
    {
        [TestFixture]
        public class MediatorTicketTest
        {
            private PersonModel _PersonModel;
            private TicketModel _TicketModel;

            public MediatorTicketTest()
            {
                _PersonModel = new PersonModel()
                {
                    FirstName = "Test",
                    LastName = "Tester",
                    Age = 25
                };

                _TicketModel = new TicketModel()
                {
                    EventName = "Really Fun Concert",
                    Description = "Come have a good time",
                    MinimumAge = 21,
                    SeniorAdmission = 70.00m,
                    ChildAdmission = 0.00m,
                    GeneralAdmission = 100.00m
                };
            }

            [Test]
            public void ReturnTrueIfEligbleAndIsGeneralAdmission()
            {
                _PersonModel.Age = 25;
                TicketMediator TicketMediator = new TicketMediator(_PersonModel, _TicketModel);

                Assert.IsTrue(TicketMediator.IsEligibleToAttend());
                Assert.IsTrue(TicketMediator.GetTicketPrice() == _TicketModel.GeneralAdmission);
            }

            [Test]
            public void ReturnTrueIfEligibleAndIsSeniorAdmission()
            {
                _PersonModel.Age = 65;
                TicketMediator TicketMediator = new TicketMediator(_PersonModel, _TicketModel);

                Assert.IsTrue(TicketMediator.IsEligibleToAttend());
                Assert.IsTrue(TicketMediator.GetTicketPrice() == _TicketModel.SeniorAdmission);
            }

            [Test]
            public void ReturnTrueIfEligibleAndIsChildAdmission()
            {
                _TicketModel.MinimumAge = 0;
                _PersonModel.Age = 6;

                TicketMediator TicketMediator = new TicketMediator(_PersonModel, _TicketModel);

                Assert.IsTrue(TicketMediator.IsEligibleToAttend());
                Assert.IsTrue(TicketMediator.GetTicketPrice() == _TicketModel.ChildAdmission);
            }

            [Test]
            public void ReturnTrueIfNotEligible()
            {
                _PersonModel.Age = 6;
                _TicketModel.MinimumAge = 21;
                TicketMediator TicketMediator = new TicketMediator(_PersonModel, _TicketModel);

                Assert.IsFalse(TicketMediator.IsEligibleToAttend());
            }
        }
    }
}
