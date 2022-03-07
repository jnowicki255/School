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
    }
}
