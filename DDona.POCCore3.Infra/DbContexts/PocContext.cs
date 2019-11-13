using DDona.POCCore3.Domain.Entities;
using DDona.POCCore3.Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Infra.DbContexts
{
    public class PocContext : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<FuncionarioProjeto> FuncionarioProjeto { get; set; }

        public PocContext() { }

        public PocContext(DbContextOptions<PocContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProjetoConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioProjetoConfiguration());
        }
    }
}
