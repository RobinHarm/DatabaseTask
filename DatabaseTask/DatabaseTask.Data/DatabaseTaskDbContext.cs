using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<HospitalCure> HospitalCure { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PrescribedMedicine> PrescribedMedicine { get; set; }
        public DbSet<Study> Study { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<Visit> Visit { get; set; }
    }
}
