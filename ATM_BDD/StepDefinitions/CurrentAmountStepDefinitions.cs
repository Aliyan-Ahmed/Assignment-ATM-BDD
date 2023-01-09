using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class CurrentAmountStepDefinitions
    {
        ATM atm = new ATM();
        Param param = new Param();

        [Given(@"current amount")]
        public void GivenCurrentAmount()
        {
            param.currentAmount = 123456;
        }

        [Given(@"account option")]
        public void GivenAccountOption()
        {
            param.choice = 1;
        }

        [When(@"valid pin")]
        public void WhenValidPin()
        {
            param.pin = 1234;
        }

        [Then(@"the current amount")]
        public void ThenTheCurrentAmount()
        {
            Assert.AreEqual(atm.BankTransfer(param), "Current Amount = 123456");
        }
    }
}
