using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDessignPattern.CreditCards
{
    public interface ICreditCard
    {
        public int Pan { get; set; }
        public int Code { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Owner { get; set; }
        public enum Brand { Mastercard, Visa};
        CreditCardHolderInfo GetHolderInfo();
        string GetBrand();
        void DepositeCash(decimal amount);
        decimal GetMoney();
        decimal GetInterest();
    }
}
