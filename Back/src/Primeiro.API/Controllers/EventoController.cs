using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primeiro.API.Models;

namespace Primeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _evento =  new Evento[]{
           new Evento() {
            EventoId = 1 ,
            Tema = "Angular 11",
            Local = "Brasilia",
            DataEvento = DateTime.Now.ToString(),
            QtdPessoas = 5,
            Lote = "Asa Norte",
            ImagemURL = "Photoh.png"
           },
           new Evento() {
            EventoId = 2 ,
            Tema = "Angular 11",
            Local = "Brasilia",
            DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
            QtdPessoas = 5,
            Lote = "Asa Sul",
            ImagemURL = "foto.png"
           }
        };

        [HttpGet]
        public  IEnumerable<Evento> Get ()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public  IEnumerable<Evento> GetById (int id)
        {
           return _evento.Where(eventoqq => eventoqq.EventoId == id);
        }
         [HttpPost]
        public string VaiSerPostNaoImportaONome()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string VaiSerPutNaoImportaONome(int id)
        {
           return $"Exemplo de Put com id ={id}";
        }
             public EventoController(){ }
    }
}
