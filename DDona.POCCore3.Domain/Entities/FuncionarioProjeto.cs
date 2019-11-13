using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.Domain.Entities
{
    public class FuncionarioProjeto 
    {
        public Guid IdFuncionario { get; set; }
        public Guid IdProjeto { get; set; }

        public Funcionario Funcionario { get; set; }
        public Projeto Projeto { get; set; }
    }
}
