namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den

            // Nytt bankkonto
            BankAccount account = new BankAccount("0987654", "Farishta Sulaiman", 1000);

            // Visar det aktuella saldot på kontot
             account.DisplayBalance();

            // Gör en insättning 
            account.Deposit(1000);

            //Gör ett uttag
            account.Withdraw(300);

            //ta ut mer pengar än vad som finns på kontot
            account.Withdraw(2000);

            account.DisplayBalance();


        }
    }
}
