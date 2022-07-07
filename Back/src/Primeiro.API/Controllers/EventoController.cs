using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primeiro.API.Data;
using Primeiro.API.Models;

namespace Primeiro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      //public IEnumerable<Evento> _evento =  new Evento[]{
           /*
           Dentro do start.up falei pro services que o contexto usado é o DbContext, que pasei o tipo <Evento>
           Ou seja, eu eustou passando pro meu services meu DataContext, então dentro do AddControllers ou mesmo do AddSwaggerGen ou de qualquer outra conversa con services, eu posso receber no construtor dessa public aqui, como parametro, o meu contexto.
           */
       // };
        private readonly DataContext _contexto; // initialize fild from parameter
        public EventoController(DataContext contexto)
        {
            _contexto = contexto;
         
        }

        [HttpGet]
        public  IEnumerable<Evento> Get ()
        {
           return  _contexto.Eventos;
        }

        [HttpGet("{id}")]
        public  Evento GetById (int id)
        {
           return _contexto.Eventos.FirstOrDefault(eventoqq => eventoqq.EventoId == id);
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
    }
}
