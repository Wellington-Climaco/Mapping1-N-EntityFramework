using System;


namespace DbWithEntityFramework.Models
{
    public class Morador
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Cpf { get; set; }

        public DateTime? DataNascimento { get; set; }

        public IList<Visitante>? Visitantes { get; set; }
    }
}
