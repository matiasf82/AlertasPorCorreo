using Entidades;
using System.Net.Http.Json;
using System.Security.Policy;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string urlBase = "https://localhost:7152/api/Correos/SendEmailAsync";
        public Form1()
        {
            InitializeComponent();
        }

        //private async Task BtnEnviar_Click(object sender, EventArgs e)
        //{
        //    await Enviar();
        //}

        private async Task Enviar()
        {
            var mail = new MailRequest();
            mail.Subject = TxtAsunto.Text;
            mail.Body = TxtMensaje.Text;

            var url = urlBase + "/SendEmailAsync";
            var cliente = new HttpClient();
            var respuesta = await cliente.PostAsJsonAsync(urlBase, mail);
            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Correo enviado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                TxtAsunto.Clear();
                TxtDireccionDestino.Clear();
                TxtMensaje.Clear();
            }

        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            await Enviar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DataDirecciones.Rows.Add();
        }
    }
}