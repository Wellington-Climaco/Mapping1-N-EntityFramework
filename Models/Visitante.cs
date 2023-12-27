
namespace DbWithEntityFramework.Models
{
    public class Visitante
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Cpf { get; set; }
        
        public Morador? Morador { get; set; }

    }
}
