using Microsoft.EntityFrameworkCore;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Horario> Horarios {get;set;}
       public DbSet<Persona> Personas {get;set;}
       public DbSet<Medico> Medicos {get;set;}
       public DbSet<Paciente> Pacientes {get;set;}
       public DbSet<Cita> Citas {get;set;}
       public DbSet<Sede> Sedes {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IpsData");
           }
       }
   }   
}