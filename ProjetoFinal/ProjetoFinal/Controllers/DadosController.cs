using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class DadosController : ApiController
    {
        public static string relay_state = "";
        private string relay_change = "";

        // GET: api/Dados
        public string Get()
        {
            return relay_state;
        }

        // GET: api/Dados/5
        public string Get(int id)
        {
            return relay_state;
        }

        [HttpPost]
        // POST: api/Dados
        public HttpResponseMessage Post([FromBody]Relays value)
        {
            if (value != null)
            {
                relay_state = value.relay;
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // PUT: api/Dados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dados/5
        public void Delete(int id)
        {
        }
    }
}
