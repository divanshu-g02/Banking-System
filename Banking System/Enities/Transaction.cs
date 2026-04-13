namespace Banking_System.Enities
{
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer

    }
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public decimal BalanceAfter { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }

        public Account Account { get; set; }
    }
}
