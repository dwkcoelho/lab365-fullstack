using bercario.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace bercario.Models
{
    public class BercarioContexto : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }
        public DbSet<Bebe> Bebes { get; set; }

        public DbSet <Mae> Maees { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AEEPB0N\\SQLEXPRESS;User ID=sa;Password=*********;Database=Bercario;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
        }
    }
}
