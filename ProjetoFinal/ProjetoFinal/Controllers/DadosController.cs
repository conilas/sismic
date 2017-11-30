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
        public static string relay_state = "OFF";  
        private string relay_change = "";

        // GET: api/Dados   
        public string Get()
        {
           return relay_state;  
        }
        
        [HttpPost]
        // POST: api/Dados
        public HttpResponseMessage Post([FromBody]Relays value)
        {
            relay_state = value.relay.Equals("1") ? "ON" : "OFF";  
            if (relay_change.Equals("ON")) return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.Created); 
        }
                  
        [HttpPut]
        public void Put([FromBody]string value)
        { 
            relay_change = value;
        } 

        // DELETE: api/Dados/5
        public void Delete(int id)
        {
        }
    }
}
