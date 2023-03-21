using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;


namespace WebApplicationAlertas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorreosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CorreosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpPost("Insertar")]
        public async Task<ActionResult> Insertar(Correo correo)
        {
            if(correo is null)
            {
                return NoContent();
            }

            context.Add(correo);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
