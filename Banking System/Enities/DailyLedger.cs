namespace Banking_System.Enities
{
    public class DailyLedger
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal TotalDepoit { get; set; }
        public decimal TotalWithdraw { get; set; }
        public decimal ClosingBalance { get; set; }


        public Account Account { get; set; }
    }
}
