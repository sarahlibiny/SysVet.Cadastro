using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Dominio.Interfaces
{
    public interface IAnimalRepositorio
    {
        List<Animal> Get();
        Animal Get(int id);
        void Insert(Animal animal);
        void Update(Animal animal);
        void Delete(int id);
    }
}
