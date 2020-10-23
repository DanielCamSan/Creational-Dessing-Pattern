using CreationalDessignPattern.CreditCards;
using CreationalDessignPattern.Factory;
using System;

namespace CreationalDessignPattern
{
    class MainApp
    {
        static void Main(string[] args)
        {

            string name;
            decimal amountToDeposite;
            CreditCardFactory factory = new ConcreteCreditCardFactory();


            Console.WriteLine("Hello MasterCard User, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How much would you like to deposite?");
            amountToDeposite = (decimal)Convert.ToDouble(Console.ReadLine());
            ICreditCard masterCard = factory.GetCreditCard("MasterCard");
            masterCard.Owner = name;
            Deposite(masterCard, amountToDeposite);


            Console.WriteLine("____________________________________________________\n");


            Console.WriteLine("Hello MasterCard User, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How much would you like to deposite?");
            amountToDeposite = (decimal)Convert.ToDouble(Console.ReadLine());
            ICreditCard visa = factory.GetCreditCard("Visa");
            visa.Owner = name;
            Deposite(visa, amountToDeposite);


            Console.ReadKey();

        }
        public static void Deposite(ICreditCard creditCard,decimal amountToDeposite)
        {
            creditCard.DepositeCash(amountToDeposite);
            Console.WriteLine($"Dear: {creditCard.GetHolderInfo().Name}");
            Console.WriteLine($"Your brand is : {creditCard.GetBrand()}");
            Console.WriteLine($"You have deposited {amountToDeposite} and now you have {creditCard.GetMoney()}$ with {creditCard.GetInterest()}$ of interest per year");
            
        }
    }
}
