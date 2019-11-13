using DDona.POCCore3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Infra.Configurations
{
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder
                .ToTable("Projeto")
                .HasKey(x => x.Id);

            builder
                .HasMany(x => x.FuncionarioProjeto)
                .WithOne(x => x.Projeto)
                .Metadata.PrincipalToDependent.SetField("_funcionarios");
        }
    }
}
