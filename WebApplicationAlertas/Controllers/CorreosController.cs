using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ActionResult> GetAll()
        {
            var lista = await context.Correos.ToListAsync();
            if(lista is null)
            {
                return NoContent();
            }
            return Ok(lista);
        }
    }
}
