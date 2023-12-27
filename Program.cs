using DbWithEntityFramework.Data;
using DbWithEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace DbWithEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new IdentificacaoDataContext();

            //context.Add(new Morador { Name = "wellington", Cpf = "52186082790", DataNascimento = DateTime.Parse("18/03/2003") });
            //context.Add(new Morador { Name = "iraci", Cpf = "57186082790", DataNascimento = DateTime.Parse("25/05/2004") });

            var morador = context.Moradores;

            foreach(var moradores in morador)
            {
                Console.WriteLine($"{moradores.Name} - {moradores.DataNascimento.ToString("dd/MM/yyyy")}");
            }
            

        }
    }
}
