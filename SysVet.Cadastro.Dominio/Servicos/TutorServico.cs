using SysVet.Cadastro.Dominio.Entidades;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Dominio.Servicos
{
    public class TutorServico : ITutorServico
    {
        private readonly ITutorRepositorio _tutorRepositorio;

        public TutorServico(ITutorRepositorio tutorRepositorio)
        {
            _tutorRepositorio = tutorRepositorio;
        }

        public void Delete(int id)
        {
            _tutorRepositorio.Delete(id);
        }

        public List<Tutor> Get()
        {
           return _tutorRepositorio.Get();
        }

        public Tutor Get(int id)
        {
            return _tutorRepositorio.Get(id);
        }

        public void Insert(Tutor tutor)
        {
           _tutorRepositorio.Insert(tutor);
        }

        public void Update(Tutor tutor)
        {
            _tutorRepositorio.Update(tutor);
        }
    }
}
