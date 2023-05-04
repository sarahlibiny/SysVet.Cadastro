using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVet.Cadastro.Dominio.Entidades;

namespace SysVet.Cadastro.Dominio.Interfaces
{
    public interface ITutorServico
    {
        List<Tutor> Get();
        Tutor Get(int id);
        void Insert(Tutor tutor);
        void Update(Tutor tutor);
        void Delete(int id);
    }
}
