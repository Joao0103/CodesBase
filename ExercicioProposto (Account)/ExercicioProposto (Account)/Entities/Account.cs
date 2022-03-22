using ExercicioProposto__Account_.Entities.Exceptions;

namespace ExercicioProposto__Account_.Entities
{
    class Account
    {
        public int Number { get; set; }
        public  string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double whithdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = whithdrawLimit;
        }

        public void Deposit(double amount)
        {
                Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;

        }      
    }
    
}
