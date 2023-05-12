namespace SysVet.Cadastro.Dominio.Entidades
{
    public class Tutor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Tutor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Tutor( string nome)
        {
            Nome = nome;
        }
    }
}
