using DDona.POCCore3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Infra.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder
                .ToTable("Funcionario")
                .HasKey(x => x.Id);

            builder
                .HasMany(x => x.ProjetoFuncionario)
                .WithOne()
                .Metadata.PrincipalToDependent.SetField("_projetos");
        }
    }
}
