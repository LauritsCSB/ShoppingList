using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Models
{
    public class GroceryItem
    {
        [Key]
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int Amount { get; set; }
        public string ?Location { get; set; }
        public double Price { get; set; }
    }
}