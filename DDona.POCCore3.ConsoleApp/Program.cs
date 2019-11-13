using DDona.POCCore3.Infra.DbContexts;
using Microsoft.EntityFrameworkCore;
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
                var funcionarios = context
                    .Funcionario
                    .Include(x => x.ProjetoFuncionario)
                    .ThenInclude(x => x.Projeto)
                    .ToList();

                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"{funcionario.Nome} está nesses projetos:");
                    foreach (var projetoFuncionario in funcionario.ProjetoFuncionario)
                    {
                        Console.WriteLine(projetoFuncionario.Projeto.Titulo);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
