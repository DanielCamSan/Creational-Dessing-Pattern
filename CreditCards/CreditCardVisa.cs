using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDessignPattern.CreditCards
{
    public class CreditCardVisa : ICreditCard
    {
        private string _owner;
        private int _pan;
        private int _code;
        private DateTime _expirationDate;
        private const string brand = "Master Card";
        private decimal _actualMoney;

        public CreditCardVisa(decimal actualMoney=0)
        {
            _actualMoney = actualMoney;
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }

        }
        public int Pan
        {
            get { return _pan; }
            set { _pan = value; }

        }
        public int Code
        {
            get { return _code; }
            set { _code = value; }

        }
        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }

        }
        public string GetBrand()
        {
            return $"The brand of this card is {brand}.";
        }

        public CreditCardHolderInfo GetHolderInfo()
        {
            return new CreditCardHolderInfo()
            {
                Name = $"Owner: {_owner}"
            };
        }
        public void DepositeCash(decimal amount)
        {
            _actualMoney += amount;
        }
        public decimal GetMoney()
        {
            return _actualMoney;
        }
        public decimal GetInterest()
        {
            decimal interest = 0;
            if (_actualMoney > 1000 && _actualMoney < 10000)
                interest = _actualMoney * 0.03m;
            if (_actualMoney > 10000)
                interest = _actualMoney * 0.06m;
            if (_actualMoney < 1000)
                interest = _actualMoney * 0.01m;
            return interest;
        }
    }
}
