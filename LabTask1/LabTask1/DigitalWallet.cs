using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class DigitalWallet : IPaymentSystem
    {
        public string WalletId { get; }

        public DigitalWallet(string walletId)
        {
            WalletId = walletId;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing Digital Wallet payment of ${amount} for Wallet ID: {WalletId}");
        }
    }
}
