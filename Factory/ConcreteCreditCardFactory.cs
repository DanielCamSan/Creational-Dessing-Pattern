using CreationalDessignPattern.CreditCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDessignPattern.Factory
{
    public class ConcreteCreditCardFactory :CreditCardFactory
    {
        public override ICreditCard GetCreditCard(string CreditCard)
        {
            switch (CreditCard)
            {
                case "MasterCard":
                    return new CreditCardMasterCard();                 
                case "Visa":
                    return new CreditCardVisa();                    
                default:
                    throw new Exception(string.Format($"CreditCard '{CreditCard}' cannot be created"));                   
            }
        }
    }
}
