namespace Banking_System.Enities
{
    public enum AccountType
    {
        Savings,
        Current,
        Fixed
    }
    public class Account
    {
        
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance{ get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public Customer Customer{ get; set; }
        public ICollection<>


    }
}
