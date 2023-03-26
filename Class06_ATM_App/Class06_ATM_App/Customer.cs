namespace Class06_ATM_App
{
    public class Customer
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }

        public Customer(string name, string cardNumber, string pin, decimal balance)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;           
            Name = name;
            Balance = balance;
        }

        public void CheckBalance(Customer user)
        {
            Console.WriteLine(user.Balance);
        }
        
    }
}
