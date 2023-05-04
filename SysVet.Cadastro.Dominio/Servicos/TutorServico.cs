using SysVet.Cadastro.Dominio.Entidades;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Dominio.Servicos
{
    public class TutorServico : ITutorServico
    {
        private readonly ITutorRepositorio _TutorRepositorio;

        public TutorServico(ITutorRepositorio tutorRepositorio)
        {
            _TutorRepositorio = tutorRepositorio;
        }

        public void Delete(int id)
        {
            _TutorRepositorio.Delete(id);
        }

        public List<Tutor> Get()
        {
           return _TutorRepositorio.Get();
        }

        public Tutor Get(int id)
        {
            return _TutorRepositorio.Get(id);
        }

        public void Insert(Tutor tutor)
        {
           _TutorRepositorio.Insert(tutor);
        }

        public void Update(Tutor tutor)
        {
            _TutorRepositorio.Update(tutor);
        }
    }
}
