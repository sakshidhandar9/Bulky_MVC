using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;


namespace BulkyBookWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
      .HasOne(p => p.Category)
      .WithMany()
      .HasForeignKey(p => p.CategoryId);



            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "The Pragmatic Programmer",
                     Description = "A practical guide to programming.",
                     ISBN = "978-0135957059",
                     Author = "Andrew Hunt",
                     ListPrice = 550,
                     Price = 500,
                     Price50 = 480,
                     Price100 = 450,
                     CategoryId = 2,
                     ImageUrl = ""
                    
                 },
        new Product
        {
            Id = 2,
            Title = "Clean Code",
            Description = "A Handbook of Agile Software Craftsmanship.",
            ISBN = "978-0132350884",
            Author = "Robert C. Martin",
            ListPrice = 600,
            Price = 580,
            Price50 = 550,
            Price100 = 530,
            CategoryId = 2,
            ImageUrl = ""


        },
        new Product
        {
            Id = 3,
            Title = "Design Patterns",
            Description = "Elements of Reusable Object-Oriented Software.",
            ISBN = "978-0201633610",
            Author = "Erich Gamma",
            ListPrice = 700,
            Price = 680,
            Price50 = 660,
            Price100 = 630,
            CategoryId = 2,
            ImageUrl = ""




        },
        new Product
        {
            Id = 4,
            Title = "Introduction to Algorithms",
            Description = "Widely used textbook for algorithms.",
            ISBN = "978-0262033848",
            Author = "Thomas H. Cormen",
            ListPrice = 900,
            Price = 880,
            Price50 = 850,
            Price100 = 820,
            CategoryId = 2,
            ImageUrl = ""


        },
        new Product
        {
            Id = 5,
            Title = "Refactoring",
            Description = "Improving the Design of Existing Code.",
            ISBN = "978-0201485677",
            Author = "Martin Fowler",
            ListPrice = 750,
            Price = 720,
            Price50 = 700,
            Price100 = 680,
            CategoryId = 2,
            ImageUrl = ""


        },
        new Product
        {
            Id = 6,
            Title = "Domain-Driven Design",
            Description = "Tackling Complexity in the Heart of Software.",
            ISBN = "978-0321125217",
            Author = "Eric Evans",
            ListPrice = 850,
            Price = 820,
            Price50 = 800,
            Price100 = 780,
            CategoryId = 3,
            ImageUrl = ""


        }
            );


        }

    }
}
