using SysVet.Cadastro.Dominio.Entidades;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Dominio.Servicos
{
    public class AnimalServico : IAnimalServico
    {
        private readonly IAnimalRepositorio _AnimalRepositorio;

        public AnimalServico(IAnimalRepositorio animalRepositorio)
        {
            _AnimalRepositorio = animalRepositorio;
        }

        public void Delete(int id)
        {
            _AnimalRepositorio.Delete(id);
        }

        public List<Animal> Get()
        {
           return _AnimalRepositorio.Get();
        }

        public Animal Get(int id)
        {
           return _AnimalRepositorio.Get(id);
        }

        public void Insert(Animal animal)
        {
            _AnimalRepositorio.Insert(animal);
        }

        public void Update(Animal animal)
        {
            _AnimalRepositorio.Update(animal);
        }
    }
}
