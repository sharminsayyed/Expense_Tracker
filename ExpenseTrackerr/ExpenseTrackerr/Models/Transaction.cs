using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        // here we are using the foreign key to link the transaction to a category
        // here we have to save category id - to specific which of category transaction we are dealing with
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Category is a navigation property
        // navigation property mes that we can access the category of the transaction directly from the transaction object
        //it represents a link or association from one entity to another related entity or a collection of related entities.
        //With this, you get stronger object relationships in C#:
        //You can do transaction.Category.Name
        //You can load related data easily with .Include(p => p.Category)
        // it is not complusory but with it we can access another members of that particular table
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string? Note { get; set; } // to write a description about the transaction - can be nullable

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
