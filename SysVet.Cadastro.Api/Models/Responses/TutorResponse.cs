using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Api.Models.Responses
{
    public class TutorResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public TutorResponse CriarApartirDoDominio(Tutor tutor)
        {
            return new TutorResponse { Id = tutor.Id, Nome = tutor.Nome };
        }
    }
}
