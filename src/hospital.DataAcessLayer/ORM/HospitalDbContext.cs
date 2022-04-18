using hospital.Domain.Entities;
using hospital.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace hospital.DataAcessLayer.ORM
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }
        //public HospitalDbContext()
        //{
        //}

        public virtual DbSet<Mural> Mural { get; set; } = null!;
        public virtual DbSet<Paciente> Paciente { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<EstadoPaciente> EstadoPaciente { get; set; } = null!;


    }
}




