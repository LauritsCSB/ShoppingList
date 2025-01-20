using Microsoft.EntityFrameworkCore;
using ShoppingList.Models;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingList.Data
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext(DbContextOptions<ShoppingListContext> options) : base(options) 
        {
        }

        public DbSet<GroceryItem> GroceryItems { get; set; }
    }
}
