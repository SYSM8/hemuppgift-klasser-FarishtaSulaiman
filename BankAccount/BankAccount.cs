using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; } // vissa har skrivit "private" pga de ska vara hemligt 

        //Lägg till Konstruktor
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance; 
        }

        //Lägg till Metoder

        //Metod för att sätta in pengar
        public void Deposit(double amount)

        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Nytt saldo efter insättning: {Balance}");
            }
            else
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
            }
        }

        //kan också skrivas såhär  Balance += amount;
        // Console.WriteLine("$Deposited {amount}, New Blanace {Balance}");


        // för att ta ut pengar
        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Nytt saldo efter uttag: {Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Beloppet måste vara större än 0.");
            }
            else
            {
                Console.WriteLine("Uttag misslyckades. Otillräckligt saldo.");
            }
        }
        // kan cos
        // visar aktuellt saldo
        public void DisplayBalance()
        {
            Console.WriteLine($"Det aktuella saldot är: {Balance}");
        }


        //Lycka till! :)
    }
}
