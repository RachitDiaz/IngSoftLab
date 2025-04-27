using backend_lab.Handlers;
using backend_lab_c12569.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab_c12569.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisesHandler _paisesHandler;
        public PaisesController()
        {
            _paisesHandler = new PaisesHandler();
        }
        [HttpGet]
        public List<PaisModel> Get()
        {
            var paises = _paisesHandler.ObtenerPaises();
            return paises;
        }

        [HttpPost]
        public async Task<ActionResult> CrearPais(PaisModel pais)
        {
            try {
                if (pais == null)
                {
                    return BadRequest("El pais no puede ser nulo");
                }
                PaisesHandler paisHandler = new PaisesHandler();
                var resultado = paisHandler.CrearPais(pais);
                return new JsonResult(resultado);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creando el país");
            }

        }

    }
}
