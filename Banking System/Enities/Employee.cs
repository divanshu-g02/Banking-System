namespace Banking_System.Enities
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime JoinedAt { get; set; }

        public User User { get; set; }
    }
}
