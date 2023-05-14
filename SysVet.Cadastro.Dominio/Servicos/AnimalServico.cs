using SysVet.Cadastro.Dominio.Entidades;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Dominio.Servicos
{
    public class AnimalServico : IAnimalServico
    {
        private readonly IAnimalRepositorio _animalRepositorio;

        public AnimalServico(IAnimalRepositorio animalRepositorio)
        {
            _animalRepositorio = animalRepositorio;
        }

        public void Delete(int id)
        {
            _animalRepositorio.Delete(id);
        }

        public List<Animal> Get()
        {
           return _animalRepositorio.Get();
        }

        public Animal Get(int id)
        {
           return _animalRepositorio.Get(id);
        }

        public void Insert(Animal animal)
        {
            _animalRepositorio.Insert(animal);
        }

        public void Update(Animal animal)
        {
            _animalRepositorio.Update(animal);
        }
    }
}
