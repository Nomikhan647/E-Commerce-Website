using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Website.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        {
            
        }
       
        public DbSet<Admin> admins { get; set; }
        public DbSet<Customer> customers { get; set; }  
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }    
        public DbSet<Cart> carts { get; set; }  
        public DbSet<Feedback> feedbacks { get; set; } 
        public DbSet<Faqs> faqs { get; set; }
    }
}
