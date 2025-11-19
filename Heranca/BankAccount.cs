using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes.Heranca
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0.00m;
        public virtual double InterestRate { get; set; } = 0.00;
        public virtual double ImpostRate { get; set; } = 0.00;

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is: {Balance:C}");
        }

        public void ShowInfoAccounts()
        {
            Console.WriteLine($"#### Account Number: {AccountNumber} - Accont Holder: {AccountHolder}");
        }


        public decimal Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
            Balance = Balance + CalculateBalanceWithInterest(InterestRate);
            return Balance;
        }

        public virtual decimal Withdraw(decimal withdrawAmount)
        {
            if (Balance > withdrawAmount)
            {
                Balance -= withdrawAmount;
                Balance = Balance - CalculateBalanceWithdrawWithTax(ImpostRate);
            }
            else
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }

            return Balance;
        }

        public static void ShowInfoAboutFunctionAccounts()
        {
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.TransactionsCurrentAccount();

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.TransactionsSavingsAccount();

            InvestmentAccount investmentAccount = new InvestmentAccount();
            investmentAccount.TransactionsInvestmentAccount();

        }

        private decimal CalculateBalanceWithInterest(double interestRate)
        {
            return Balance * (decimal)interestRate;
        }
        private decimal CalculateBalanceWithdrawWithTax(double impostRate)
        {
            return Balance * (decimal)impostRate;
        }
    }

    public class CurrentAccount : BankAccount
    {
        public void TransactionsCurrentAccount()
        {
          

            AccountNumber = 111;
            AccountHolder = "Maria";

            ShowInfoAccounts();

            Balance = 1000.00m;
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");

            Deposit(1000.00m);
            Console.WriteLine($"Depositando (R$ 1000.00): {Balance.ToString("c")}");
            Withdraw(100.00m);
            Console.WriteLine($"Retirando (R$ 100.00): {Balance.ToString("c")}");

            Withdraw(2000.00m);
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");

        }
    }

    public class SavingsAccount : BankAccount
    {
        public override double InterestRate { get; set; } = 0.005;

        public void TransactionsSavingsAccount()
        {
        
            AccountNumber = 222;
            AccountHolder = "José";

            ShowInfoAccounts();

            Balance = 1000.00m;
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");
            Deposit(1000.00m);
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");
            Withdraw(100.00m);
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");
        }

    }

    public class InvestmentAccount : BankAccount
    {
        public override double InterestRate { get; set; } = 0.009;
        public override double ImpostRate { get; set; } = 0.01;

        public void TransactionsInvestmentAccount()
        {
            Balance = 1000.00m;

            AccountNumber = 333;
            AccountHolder = "Gabriel";

            ShowInfoAccounts();

            Balance = 1000.00m;
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");

            Deposit(1000.00m);
            Console.WriteLine($"Depositando (R$ 1000.00): {Balance.ToString("c")}");
            Withdraw(100.00m);
            Console.WriteLine($"Retirando (R$ 100.00): {Balance.ToString("c")}");

            Withdraw(2000.00m);
            Console.WriteLine($"Saldo: {Balance.ToString("c")}");
        }

    }
}

