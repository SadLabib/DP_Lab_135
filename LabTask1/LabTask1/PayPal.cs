using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class PayPal : IPaymentSystem
    {
        public string Email { get; }

        public PayPal(string email) {
            Email = email;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount} for {Email}");
        }
    }
}
