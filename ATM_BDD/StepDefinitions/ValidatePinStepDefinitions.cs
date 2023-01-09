using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ATM_BDD.StepDefinitions
{
    [Binding]
    public class ValidatePinStepDefinitions
    {
        ATM atm = new ATM();
        Param param = new Param();

        [Given(@"The incorrect PIN")]
        public void GivenTheIncorrectPIN()
        {
            param.pin = 4321;
        }

        [Then(@"invalid pin mesasge")]
        public void ThenInvalidPinMesasge()
        {
            Assert.AreEqual(atm.BankTransfer(param), "Invalid PIN");
        }
    }
}
