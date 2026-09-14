namespace Exercise2Week3.Pages.Models
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public int NumberofTransactions { get; set; }
        public int AccountId { get; set; }
        List<BankAccount>? BankAccounts { get; set; }
    }
}
