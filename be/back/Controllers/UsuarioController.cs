using back.Interfaces;
using back.Migrations;
using back.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace back.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly AplicationContext _aplicationContext;
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(AplicationContext aplicationContext, IUsuarioService usuarioService)
        {
            _aplicationContext = aplicationContext;
            _usuarioService = usuarioService;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        public async Task<ActionResult> Login([FromQuery] UsuarioModel input)
        {
            try
            {
                //var token = HttpContext.Request.Headers["x-token"].ToString();//SACAR TOKEN

                var result = await _usuarioService.Login(input);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
