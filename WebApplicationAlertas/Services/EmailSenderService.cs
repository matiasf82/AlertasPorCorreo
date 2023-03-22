using Entidades;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using System.Diagnostics.CodeAnalysis;
//using System.Net.Mail;

namespace WebApplicationAlertas.Services
{
    public class EmailSenderService : ControllerBase, IEmailSenderService
    {
        private readonly SmtpSettings _smtpSettings;
        private readonly ApplicationDbContext context;

        public EmailSenderService(IOptions<SmtpSettings> smtpSettings, ApplicationDbContext context)
        {
            _smtpSettings = smtpSettings.Value;
            this.context = context;
        }

        public async Task<ActionResult> SendEmailAsync(MailRequest request)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_smtpSettings.SenderName, _smtpSettings.SenderEmail));
                foreach (var item in request.Email)
                {
                    message.To.Add(new MailboxAddress("", item));
                }
                //message.To.Add(new MailboxAddress("", request.Email));
                message.Subject = request.Subject;
                message.Body = new TextPart("html") { Text = request.Body };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_smtpSettings.Server);
                    await client.AuthenticateAsync(_smtpSettings.UserName, _smtpSettings.Password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public async Task<ActionResult> PostAsync(Correo correo)
        {
            if (correo is null)
            {
                NoContent();
            }

            context.Add(correo);
            await context.SaveChangesAsync();
            return Ok();
        }

        public async Task<ActionResult> GetAllAsync()
        {
            var lista = await context.Correos.ToListAsync();
            return Ok(lista);
        }

    }
}
