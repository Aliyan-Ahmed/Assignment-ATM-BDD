using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class AmountWithdrawStepDefinitions
    {
        ATM atm = new ATM();
        Param param = new Param();

        [Given(@"Current amount")]
        public void GivenCurrentAmount()
        {
            param.currentAmount = 1000;
        }

        [Given(@"enter option")]
        public void GivenEnterOption()
        {
            param.choice = 2;
        }

        [Given(@"Withdraw amount")]
        public void GivenWithdrawAmount()
        {
            param.withdrawAmount = 100;
        }

        [When(@"Validate Pin")]
        public void WhenValidatePin()
        {
            param.pin = 1234;
        }

        [Then(@"total current amount")]
        public void ThenTotalCurrentAmount()
        {
            Assert.AreEqual(atm.BankTransfer(param), "Current Amount = 900");
        }
    }
}
