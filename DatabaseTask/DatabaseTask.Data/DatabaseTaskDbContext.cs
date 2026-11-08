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
        public DbSet<Koolitaja> Koolitaja { get; set; }
        public DbSet<Koolitus> Koolitus { get; set; }
        public DbSet<Õppija> Õppija { get; set; }
        public DbSet<Ruum> Ruum { get; set; }
        public DbSet<Registreerimine> Registreerimine { get; set; }
        public DbSet<Makse> Makse { get; set; }

    }
}
