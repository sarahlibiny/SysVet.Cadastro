namespace SysVet.Cadastro.Infra.Data.Entidades
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int TutorId { get; set; }
    }
}
