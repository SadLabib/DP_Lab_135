using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class CreditCard : IPaymentSystem
    {
        public string CardNumber { get; }
        public string CardHolderName { get; }

        public CreditCard(string cardNumber, string cardHolderName)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount} for {CardHolderName} (Card: {CardNumber})");
        }
    }
}
