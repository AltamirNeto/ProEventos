using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Olá mundo";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Olá mundo {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Olá mundo {id}";
        }
    }
}
