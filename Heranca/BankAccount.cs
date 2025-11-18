using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes.Heranca
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }


        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Accout number: {AccountNumber}\n" +
                $"Account Holder: {AccountHolder}");
        }

        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposited: {amount:C}");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrew: {amount:C}");
        }
    }
}
