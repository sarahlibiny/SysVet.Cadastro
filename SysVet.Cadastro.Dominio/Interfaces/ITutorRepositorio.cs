using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Dominio.Interfaces
{
    public interface ITutorRepositorio
    {
        List<Tutor> Get();
        Tutor Get(int id);
        void Insert(Tutor tutor);
        void Update(Tutor tutor);
        void Delete(int id);
    }
}
