using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebEstampillas.Models;

namespace WebEstampillas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstampillaController: ControllerBase
    {
        private readonly EstampillaService _estampillaService;
        public IConfiguration Configuration { get; }
        public EstampillaController(IConfiguration configuration)
        {
            Configuration = configuration;
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            _estampillaService = new EstampillaService(connectionString);
        }

        // GET: api/Estampilla
        [HttpGet]
        public IEnumerable<EstampillaViewModel> Gets()
        {
            var estampillas = _estampillaService.ConsultarTodos().Select(p=> new EstampillaViewModel(p));
            return estampillas;
        }

        // POST: api/Estampilla
        [HttpPost]
        public ActionResult<EstampillaViewModel> Post(EstampillaInputModel estampillaInput)
        {
            Estampilla estampilla = MapearEstampilla(estampillaInput);
            var response = _estampillaService.Guardar(estampilla);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Estampilla);
        }

        private Estampilla MapearEstampilla(EstampillaInputModel estampillaInput){
            var estampilla = new Estampilla
            {
                NumeroDeContrato = estampillaInput.NumeroDeContrato,
                ObjetoDelContrato = estampillaInput.ObjetoDelContrato,
                ValorDelContrato = estampillaInput.ValorDelContrato,
                ApoyaEmergenciaCovid19 = estampillaInput.ApoyaEmergenciaCovid19,
                
            };
            return estampilla;
    }
        
    }
}