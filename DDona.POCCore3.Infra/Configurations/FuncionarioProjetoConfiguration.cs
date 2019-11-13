using DDona.POCCore3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Infra.Configurations
{
    public class FuncionarioProjetoConfiguration : IEntityTypeConfiguration<FuncionarioProjeto>
    {
        public void Configure(EntityTypeBuilder<FuncionarioProjeto> builder)
        {
            builder.HasKey(x => new { x.IdFuncionario, x.IdProjeto });

            builder
                .HasOne(x => x.Projeto)
                .WithMany(x => x.FuncionarioProjeto)
                .HasForeignKey(x => x.IdProjeto);

            builder
                .HasOne(x => x.Funcionario)
                .WithMany(x => x.ProjetoFuncionario)
                .HasForeignKey(x => x.IdFuncionario);
        }
    }
}
