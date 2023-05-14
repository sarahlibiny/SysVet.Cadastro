using Microsoft.AspNetCore.Mvc;
using SysVet.Cadastro.Api.Models.Requests;
using SysVet.Cadastro.Api.Models.Responses;
using SysVet.Cadastro.Dominio.Interfaces;

namespace SysVet.Cadastro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalServico _animalServico;

        public AnimalController(IAnimalServico animalServico)
        {
            _animalServico = animalServico;
        }

        [HttpGet]
        public List<AnimalResponse> Get()
        {
            var animaisDominio = _animalServico.Get();
            var animaisResponse = new List<AnimalResponse>();

            foreach (var animalDominio in animaisDominio)
            {
                var animalResponse = new AnimalResponse().CriarAPartirDoDominio(animalDominio);
                animaisResponse.Add(animalResponse);
            }
            return animaisResponse;
        }

        [HttpGet("{id}")]
        public AnimalResponse Get(int id)
        {
            return new AnimalResponse().CriarAPartirDoDominio(_animalServico.Get(id));
        }

        [HttpPost]
        public void Post([FromBody] AnimalRequest animalRequest)
        {
            _animalServico.Insert(animalRequest.ConverterParaDominio());
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AnimalRequest animalResquest)
        {
            _animalServico.Update(animalResquest.ConverterParaDominio(id));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _animalServico.Delete(id);
        }
    }
}
