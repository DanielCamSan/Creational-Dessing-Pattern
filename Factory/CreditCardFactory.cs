using CreationalDessignPattern.CreditCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDessignPattern.Factory
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard GetCreditCard(string CreditCard);

    }
}
