namespace Banking_System.Enities
{
   public enum Roles
    {
        Employee,
        Customer
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }

        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
     }
}
