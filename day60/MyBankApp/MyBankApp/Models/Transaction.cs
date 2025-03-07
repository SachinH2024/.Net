using System.ComponentModel.DataAnnotations;

namespace MyBankApp.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransactionDate { get; set; }
        public int UserId { get; set; } // Foreign key to User
        //public User User { get; set; } // Navigation property
    }
}
