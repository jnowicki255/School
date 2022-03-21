using Microsoft.EntityFrameworkCore;
using School.Repository.Entities;
using School.Repository.Settings;

namespace School.Repository
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        { }

        public SchoolDbContext(ISqlDbSettings settings)
            : base(new DbContextOptionsBuilder<SchoolDbContext>()
                  .UseSqlServer(settings.ConnectionString).Options)
        { }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        { }

        public virtual DbSet<DbClass> Classes { get; set; }
        public virtual DbSet<DbStudent> Students { get; set; }
        public virtual DbSet<DbSubject> Subjects { get; set; }
        public virtual DbSet<DbTeacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbSettings = new SqlDbSettings
                {
                    ConnectionString = "Server=.\\SQLEXPRESS; " +
                    "Database=SchoolDB; " +
                    "Trusted_Connection=True; " +
                    "MultipleActiveResultSets=true"
                };
                optionsBuilder.UseSqlServer(dbSettings.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbSubject>().HasData(
                new DbSubject { SubjectId = 1, Name = "Matematyka" },
                new DbSubject { SubjectId = 2, Name = "Język polski" },
                new DbSubject { SubjectId = 3, Name = "Język angielski" },
                new DbSubject { SubjectId = 4, Name = "Fizyka" });

            modelBuilder.Entity<DbTeacher>().HasData(
                new DbTeacher { TeacherId = 1, FirstName = "Jan", LastName = "Nowak", },
                new DbTeacher { TeacherId = 2, FirstName = "Anna", LastName = "Kowalska" },
                new DbTeacher { TeacherId = 3, FirstName = "Bogusław", LastName = "Łęcina" },
                new DbTeacher { TeacherId = 4, FirstName = "Władysław", LastName = "Jagiełło" });

            modelBuilder.Entity<DbClass>().HasData(
                new DbClass { ClassId = 1, Name = "1A", TeacherId = 1 },
                new DbClass { ClassId = 2, Name = "2B", TeacherId = 2 },
                new DbClass { ClassId = 3, Name = "3C", TeacherId = 3 },
                new DbClass { ClassId = 4, Name = "4D", TeacherId = 4 });

            modelBuilder.Entity<DbStudent>().HasData(
                new DbStudent { StudentId = 1, FirstName = "Marcin", LastName = "Amoniak", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 1 },
                new DbStudent { StudentId = 2, FirstName = "Andrzej", LastName = "Mackiewicz", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 1 },
                new DbStudent { StudentId = 3, FirstName = "Zdzisław", LastName = "Kasztan", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 2 },
                new DbStudent { StudentId = 4, FirstName = "Ryszard", LastName = "Boguza", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 2 },
                new DbStudent { StudentId = 5, FirstName = "Maciej", LastName = "Armani", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 3 },
                new DbStudent { StudentId = 6, FirstName = "Wioletta", LastName = "Kamana", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 3 },
                new DbStudent { StudentId = 7, FirstName = "Rydygier", LastName = "Węzał", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 4 },
                new DbStudent { StudentId = 8, FirstName = "Pola", LastName = "Imola", 
                                BirthDate = new DateTime(2010, 02, 02), Telephone = "123-123-123", ClassId = 4 });
        }
    }
}
