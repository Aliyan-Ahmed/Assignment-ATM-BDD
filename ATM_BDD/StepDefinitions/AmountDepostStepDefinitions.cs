using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class AmountDepostStepDefinitions
    {
        ATM atm = new ATM();
        Param param = new Param();

        [Given(@"Account amount")]
        public void GivenAccountAmount()
        {
            param.currentAmount = 5000;
        }

        [Given(@"Enter choice")]
        public void GivenEnterChoice()
        {
            param.choice = 3;
        }

        [Given(@"Depost amount")]
        public void GivenDepostAmount()
        {
            param.depostAmount = 1000;
        }

        [When(@"Validate the Pin")]
        public void WhenValidateThePin()
        {
            param.pin = 1234;
        }

        [Then(@"Current amount")]
        public void ThenCurrentAmount()
        {
            Assert.AreEqual(atm.BankTransfer(param), "Current Amount = 6000");
        }
    }
}
