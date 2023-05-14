using Microsoft.AspNetCore.Mvc;
using SysVet.Cadastro.Api.Models.Requests;
using SysVet.Cadastro.Api.Models.Responses;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        private readonly ITutorServico _tutorServico;

        public TutorController(ITutorServico tutorservico)
        {
            _tutorServico = tutorservico;
        }

        [HttpGet]
        public List<TutorResponse> Get()
        {
            var tutoresDominio = _tutorServico.Get();

            var tutoresResponse = new List<TutorResponse>();

            foreach (var tutorDominio in tutoresDominio)
            {
                var tutorResponse = new TutorResponse().CriarApartirDoDominio(tutorDominio);
                tutoresResponse.Add(tutorResponse);
            }

            return tutoresResponse;

            //return _tutorServico.Get().Select(tutorDominio => new TutorResponse().CriarApartirDoDominio(tutorDominio)).ToList();
        }

        [HttpGet("{id}")]
        public TutorResponse Get(int id)
        {
            var tutorDominio = _tutorServico.Get(id);
            return new TutorResponse().CriarApartirDoDominio(tutorDominio);
        }

        [HttpPost]
        public void Post([FromBody] TutorRequest tutorRequest)
        {
            _tutorServico.Insert(tutorRequest.ConverterParaDominio());
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TutorRequest tutorRequest)
        {
            _tutorServico.Update(tutorRequest.ConverterParaDominio(id));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tutorServico.Delete(id);
        }
    }
}
