using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

        public DbSet<Company> Company { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Intranet> Intranet { get; set; }
        public DbSet<Hints> Hints { get; set; }
        public DbSet<WorkerChildren> WorkerChildren { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<HealthInspection> HealthInspection { get; set; }
        public DbSet<Favours> Favours { get; set; }
        public DbSet<Borrowed> Borrowed { get; set; }
        public DbSet<JobName> JobName { get; set; }
        public DbSet<SickPage> SickPage { get; set; }
    }
}
