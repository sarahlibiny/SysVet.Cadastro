namespace SysVet.Cadastro.Dominio.Entidades
{
    public class Animal
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Raca { get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public int TutorId { get; private set; }
    }
}
