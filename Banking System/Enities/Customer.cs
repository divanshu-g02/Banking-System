namespace Banking_System.Enities
{
    public class Customer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
