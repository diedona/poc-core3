using DDona.POCCore3.Domain.Validations;
using DDona.POCCore3.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.POCCore3.Domain.Entities
{
    public class Projeto : Entity
    {
        private readonly IList<Funcionario> _funcionarios;

        public string Titulo { get; private set; }
        public DateTime DtInicio { get; private set; }
        public DateTime? DtFim { get; private set; }
        public IReadOnlyCollection<Funcionario> Funcionarios { get { return _funcionarios.ToArray(); } }

        public Projeto(string titulo, DateTime dtInicio) : base()
        {
            Titulo = titulo;
            DtInicio = dtInicio;
            Status = true;
            _funcionarios = new List<Funcionario>();

            _validator = new ProjetoValidation();
        }

        public void SetarDataFinal(DateTime dtFim)
        {
            if(dtFim < DtInicio)
            {
                this.AddError("Projeto.DtFim", "Data final não pode ser menor que início.");
            }

            this.DtFim = dtFim;
        }
    }
}
