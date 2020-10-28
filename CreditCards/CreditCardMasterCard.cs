using System;
using System.Collections.Generic;
using System.Text;
using static CreationalDessignPattern.CreditCards.ICreditCard;

namespace CreationalDessignPattern.CreditCards
{
    class CreditCardMasterCard : ICreditCard
    {
        private string _owner;
        private int _pan;
        private int _code;
        private DateTime _expirationDate;
        private Brand _brand = Brand.Mastercard;
        private decimal _actualMoney;

        public CreditCardMasterCard(decimal actualMoney = 0)
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
            return $"The brand is {_brand}, Thank You!.";
        }

        public CreditCardHolderInfo GetHolderInfo()
        {
            return new CreditCardHolderInfo()
            {
                Name = $"Ms/Mrs {_owner}"
            };
        }
        public void DepositeCash(decimal amount)
        {
            _actualMoney += (amount-0.02m*amount);
        }
        public decimal GetMoney()
        {
            return _actualMoney;
        }
        public decimal GetInterest()
        {
            decimal interest = 0;
            if (_actualMoney > 1000)
                interest = _actualMoney * 0.04m;
            if (_actualMoney < 1000)
                interest = _actualMoney * 0.02m;
            return interest;
        }
    }
}

