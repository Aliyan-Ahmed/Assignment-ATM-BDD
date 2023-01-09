using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_BDD
{
    public class ATM
    {
        private int count = 0;
        public string BankTransfer(Param param)
        {
            if (param.pin == 1234)
            {
                count = 0;
                while (true)
                {
                    switch (param.choice)
                    {
                        case 1:
                            return "Current Amount = " + param.currentAmount;
                        case 2:
                            if (param.withdrawAmount % 100 != 0)
                            {
                                return "Please enter Amount in 100s";
                            }
                            else if (param.withdrawAmount > (param.currentAmount - param.withdrawAmount))
                            {
                                return "Sorry insufficient balance";
                            }
                            else
                            {
                                param.currentAmount -= param.withdrawAmount;
                                return "Current Amount = " + param.currentAmount;
                            }
                        case 3:
                            param.currentAmount += param.depostAmount;
                            return "Current Amount = " + param.currentAmount;
                        case 4:
                            return "Thanks";
                    }
                }
            }
            else
            {
                count++;
                if (count < 4)
                {
                    return "Invalid PIN";
                }
                else
                {
                    return "ATM blocked";
                }
            }
        }
    }

    public class Param
    {
        public double currentAmount { get; set; }
        public int choice { get; set; }
        public double withdrawAmount { get; set; }
        public double depostAmount { get; set; }
        public int pin { get; set; }
    }
}
