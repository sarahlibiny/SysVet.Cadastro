using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Api.Models.Responses
{
    public class AnimalResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int TutorId { get; set; }

        public AnimalResponse CriarAPartirDoDominio(Animal animal)
        {
            return new AnimalResponse { Id = animal.Id, Nome = animal.Nome, DataNascimento = animal.DataNascimento, Raca = animal.Raca, TutorId = animal.TutorId };
        }

    }
}
