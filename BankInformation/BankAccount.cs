namespace BankInformation
{
    public class BankAccount
    {
        private double balance;
        public BankAccount()
        {
            
        }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public double Balance 
        { 
            get { return balance; }
        }

        public void AddBalance(double amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > balance || amount < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }
        public void TransferFundsTo(BankAccount bankAccount, double amount) 
        { 
            if(bankAccount == null)
            {
                throw new ArgumentNullException(nameof(bankAccount));
            }
            Withdraw(amount);
            bankAccount.AddBalance(balance);
        }
    }
}