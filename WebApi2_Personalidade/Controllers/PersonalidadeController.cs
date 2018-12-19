using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2_Personalidade.Models;

namespace WebApi2_Personalidade.Controllers
{
    public class PersonalidadeController : ApiController
    {
        static readonly IPersonalidadeRepositorio repositorio = new PersonalidadeRepositorio();

        public IEnumerable<Personalidade> GetAllPersonalidades() => repositorio.GetAll();

        public Personalidade GetPersonalidadeById(long id)
        {
            Personalidade pers = repositorio.GetById(id);
            if (null == pers) { throw new HttpResponseException(System.Net.HttpStatusCode.NotFound); }
            return pers;
        }

        public IEnumerable<Personalidade> GetPersonalidadesPorSexo(string sexo)
            => repositorio.GetAll().Where(p => string.Equals(p.Sexo, sexo, StringComparison.OrdinalIgnoreCase));

        public HttpResponseMessage PostPersonalidade(Personalidade pers)
        {
            pers = repositorio.Add(pers);
            var response = Request.CreateResponse<Personalidade>(HttpStatusCode.Created, pers);

            string uri = Url.Link("DefaultApi", new { id = pers.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutProduto(long id, Personalidade pers)
        {
            pers.Id = id;
            if (!repositorio.Update(pers)) { throw new HttpResponseException(HttpStatusCode.NotFound); }
        }

        public void DeletePersonalidade(long id)
        {
            Personalidade pers = repositorio.GetById(id);
            if (null == pers) { throw new HttpResponseException(HttpStatusCode.NotFound); }
            repositorio.Remove(id);
        }
    }
}
