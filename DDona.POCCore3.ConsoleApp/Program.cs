using DDona.POCCore3.Infra.DbContexts;
using System;
using System.Linq;

namespace DDona.POCCore3.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PocContextFactory().CreateDbContext())
            {
                var funcionarios = context.Funcionario.ToList();
            }
        }
    }
}
