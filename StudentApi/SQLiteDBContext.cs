using Microsoft.EntityFrameworkCore;

namespace StudentApi
{
    public class SQLiteDBContext : DbContext
    {
        public DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Students>().HasData(
                new Students() { Id = 1, Username = "juan.montoya", FirstName = "Juan", LastName = "Montoya", Age = 24, Career = "Systems engineer" },
                new Students() { Id = 2, Username = "juan.moreno", FirstName = "Juan", LastName = "Moreno", Age = 23, Career = "Systems engineer" },
                new Students() { Id = 3, Username = "sara.carmona", FirstName = "Sara", LastName = "Cardona", Age = 19, Career = "Public Health Administration" },
                new Students() { Id = 4, Username = "stasy.castro", FirstName = "Stasy", LastName = "Castro", Age = 22, Career = "Public Health Administration" }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=Students.db");
    }
}