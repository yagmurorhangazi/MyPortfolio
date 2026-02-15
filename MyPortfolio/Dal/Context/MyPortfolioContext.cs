using Microsoft.EntityFrameworkCore;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Dal.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S23DBBK\\SQLEXPRESS;initial Catalog=MyPortfolioDb; integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages  { get; set; }
        public DbSet<portfolio> portfolios{ get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<ToDoList> toDolists { get; set; }
       
    }
}
