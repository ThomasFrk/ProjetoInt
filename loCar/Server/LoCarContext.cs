using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoCar.Models;

namespace LoCar.Data
{
    public class LoCarContext : DbContext
    {
        public LoCarContext(DbContextOptions<LoCarContext> options) : base(options)
        {
        }

        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Empresa> Empresa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 2,
                    Nome = "Carlos",
                    Endereco = "teste",
                    Cpf = "teste",
                    Email = "teste",
                    Nascimento = "16091997",
                    Senha = "123456"
                }
            );
        }
    }
}
