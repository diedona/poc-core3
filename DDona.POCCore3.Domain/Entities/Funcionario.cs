using DDona.POCCore3.Domain.Validations;
using DDona.POCCore3.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.POCCore3.Domain.Entities
{
    public class Funcionario : Entity
    {
        private readonly List<FuncionarioProjeto> _projetos;

        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public IEnumerable<FuncionarioProjeto> Projetos { get { return _projetos.AsReadOnly(); } }

        public Funcionario(string nome, decimal salario) : base()
        {
            Nome = nome;
            Salario = salario;
            Status = true;
            _projetos = new List<FuncionarioProjeto>();

            _validator = new ProjetoValidation();
        }
    }
}
