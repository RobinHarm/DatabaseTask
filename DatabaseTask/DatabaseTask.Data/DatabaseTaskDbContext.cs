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
        public DbSet<CHAMBER> CHAMBER { get; set; }
        public DbSet<SHIFT> SHIFT { get; set; }
        public DbSet<GUARDS> GUARDS { get; set; }
        public DbSet<PRISON> PRISON { get; set; }
        public DbSet<BLOCK> BLOCK { get; set; }
        public DbSet<BUILDING> BUILDING { get; set; }
        public DbSet<PRISONERS> PRISONERS { get; set; }
        public DbSet<VISIT> VISIT { get; set; }
        public DbSet<VISITORS> VISITORS { get; set; }
        public DbSet<CRIME> CRIME { get; set; }
        public DbSet<PUNISHMENT> PUNISHMENT { get; set; }
    }
}
