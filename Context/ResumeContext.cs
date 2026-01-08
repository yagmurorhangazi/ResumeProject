using Microsoft.EntityFrameworkCore;
using ResumeProject.Entities;

namespace ResumeProject.Context
{
    public class ResumeProject : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=locaLhost,1995;Database=ResumeDb;User Id=sa;Password=Ezya123.;TrustServerCertificate=True");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }


    }
    
}

