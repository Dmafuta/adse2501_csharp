namespace sess02_csharp_building_blocks
{
    public class Banking
    {
        private string _accountName;
        private int _accountNumber;
        private double _accountBalance;
        private bool _isActive;

        public Banking()
        {
            this._accountName = string.Empty;
            this._accountNumber = 0;
            this._accountBalance = 0;
            this._isActive = false;
        }

        public Banking(string accountName, int accountNumber, double accountBalance, bool isActive)
        {
            this._accountName = accountName;
            this._accountNumber = accountNumber;
            this._accountBalance = accountBalance;
            this._isActive = isActive;
        }

        public string GetName() => this._accountName;
        public void SetAccountName(string accountName)
        { this._accountName = accountName; }

        public int GetAccountNumber() => this._accountNumber;
        public void SetAccountNumber(int _accountNumber)
        { this._accountNumber = _accountNumber; }

        public double GetAccountBalance() => this._accountBalance;
        public void SetAccountBalance(double _accountBalance)
        { this._accountBalance = _accountBalance; }

        public bool IsActive() => this._isActive;

        public double DepositAmount(double amount)
        {
            return this._accountBalance += amount; 
        }

        public double WithDrawAmount(double amount)
        {
            try
            {
                while(amount > this._accountBalance)
                {
                    Console.WriteLine($"Account balance is insufficient...");
                    amount -= this._accountBalance;
                }
            }catch
            (Exception e) 
            { Console.WriteLine(e.Message); }
            return this._accountBalance -= amount; 
        }
        
        static void Main(string[] args)
        {
            Banking account = new Banking("Dennis Simiyu",1139852434, 100, true);

            Func<int> tested = account.GetAccountNumber;
            Action<int> tested2 = account.SetAccountNumber;

            Console.WriteLine("This is a test {0}", tested);
            account.DepositAmount(5000);
            account.DepositAmount(6500);
            account.WithDrawAmount(1);

            double balance = account.GetAccountBalance();
            Console.WriteLine($"Account Balance: {balance:C}");
        }

        static void DispalyBalance(double balance)
        {
            Console.WriteLine($"Account balance: {balance:c}");
        }
    }
}
