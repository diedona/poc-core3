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
        private readonly IList<Projeto> _projetos;

        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public IReadOnlyCollection<Projeto> Projetos { get { return _projetos.ToArray(); } }

        public Funcionario(string nome, decimal salario) : base()
        {
            Nome = nome;
            Salario = salario;
            _projetos = new List<Projeto>();

            _validator = new ProjetoValidation();
        }
    }
}
