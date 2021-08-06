using Challenge.PreAceleracion.Context;
using Challenge.PreAceleracion.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAceleracion.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //De este modo accedemos a los métodos descritos en el controlador
    public class ContinentController : ControllerBase
    {
        private readonly ChallengeContext _challengeContext;
        public ContinentController(ChallengeContext ctx)
        {
            _challengeContext = ctx;
        }
        // Método GET va a obtener info y devolverla
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var continent = await _challengeContext.Continents.FirstOrDefaultAsync();
            return Ok();
        }
        //Método POST va a crear información nueva en el modelo de datos
        [HttpPost]
        public async Task<IActionResult> Post(Continent continent)
        {
            _challengeContext.Continents.Add(continent);
            //Modificaciones en el contexto no se guardan automáticamente
            _challengeContext.SaveChanges();

            return Ok(_challengeContext.Continents.ToList());
        }
        //Van a modificar información de una entidad en particular
        [HttpPut]
        public void Put()
        {

        }

        //Va a borrar una entidad disponible
        [HttpDelete]
        public void Delete()
        {

        }
    }
}
