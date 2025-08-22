using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        // This class represents a category for expenses or income in the expense tracker application.
        //travel , food, entertainment, etc.
        [Key]
        public int CategoryId { get; set; }

        [Column (TypeName ="nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = ""; // Icon for the category, can be an emoji or a font icon

        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; } = "Expense";// Income or Expense type 


    }
}
