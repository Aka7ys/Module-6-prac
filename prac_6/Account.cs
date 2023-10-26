using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_6
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Сумма {amount} успешно зачислена на счет {AccountNumber}.");
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Сумма {amount} успешно снята со счета {AccountNumber}.");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
                return false;
            }
        }
    }
}
