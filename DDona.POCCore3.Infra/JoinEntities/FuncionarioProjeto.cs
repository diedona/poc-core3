using DDona.POCCore3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Infra.JoinEntities
{
    public class FuncionarioProjeto
    {
        public int IdFuncionario { get; set; }
        public int IdProjeto { get; set; }

        public Funcionario Funcionario { get; set; }
        public Projeto Projeto { get; set; }
    }
}
