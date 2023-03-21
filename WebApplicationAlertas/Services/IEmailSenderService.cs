using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAlertas.Services
{
    public interface IEmailSenderService
    {
        Task<ActionResult> SendEmailAsync(MailRequest request);
        Task<ActionResult> PostAsync(Correo correo);
        Task<ActionResult> GetAllAsync();
    }
}
