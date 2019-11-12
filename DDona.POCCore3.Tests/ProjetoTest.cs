using DDona.POCCore3.Domain.Entities;
using System;
using Xunit;

namespace DDona.POCCore3.Tests
{
    public class ProjetoTest
    {
        [Fact]
        public void Invalido_DataFinal_Menor_Que_Inicio()
        {
            DateTime dtInicio = new DateTime(2019, 5, 20);
            Projeto projeto = new Projeto("Teste 01", dtInicio);
            projeto.SetarDataFinal(dtInicio.AddDays(-1));

            Assert.False(projeto.IsValid());
        }
    }
}
