using System.ComponentModel.DataAnnotations;
using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Api.Models.Requests
{
    public class TutorRequest
    {
        [Required(ErrorMessage = "O nome do Tutor é obrigatório.", AllowEmptyStrings = false )]
        [StringLength(200, ErrorMessage ="O nome deve ter no máximo 200 caracteres")]
        public string Nome { get; set; }
       

        public Tutor ConverterParaDominio()
        {
            return new Tutor(Nome);
        }
    }
}
