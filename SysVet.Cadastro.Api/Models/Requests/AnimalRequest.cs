using System.ComponentModel.DataAnnotations;
using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Api.Models.Requests
{
    public class AnimalRequest
    {
        [Required(ErrorMessage = "O nome do animal é obrigatório", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage ="O nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A raça é obrigatória", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "A raça deve ter no máximo 100 caracteres")]
        public string Raca { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateOnly DataNascimento { get; set; }


        public int TutorId { get; set; }

        public Animal ConverterParaDominio()
        {
            return new Animal(Nome, Raca, DataNascimento, TutorId);
        }

        public Animal ConverterParaDominio(int id)
        {
            return new Animal(id, Nome, Raca, DataNascimento, TutorId);
        }
    }
}
