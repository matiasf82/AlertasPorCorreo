using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApplicationAlertas.Services;

namespace WebApplicationAlertas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorreosController : ControllerBase
    {
        private readonly IEmailSenderService service;

        public CorreosController(ApplicationDbContext context, IEmailSenderService service)
        {
            this.service = service;
        }


        [HttpPost("Post")]
        public async Task<ActionResult> Post(Correo correo)
        {
           return await service.PostAsync(correo);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            return await service.GetAllAsync();
        }

        [HttpPost("SendEmailAsync")]
        public async Task<ActionResult> SendEmailAsync(MailRequest mail)
        {
            try
            {
                var algo = await service.SendEmailAsync(mail);
                return algo;
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }
    }
}
