using Entidades;
using System.Net.Http.Json;
using System.Security.Policy;

namespace WinFormsApp
{
    public partial class FrmPrincipal : Form
    {
        private string urlBase = "https://localhost:7152/api/Correos";
        private List<string> lista;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private async Task Enviar()
        {
            
            var mail = new MailRequest();
            mail.Subject = TxtAsunto.Text;
            mail.Body = TxtMensaje.Text;
            mail.Email = lista;

            var url = urlBase + "/SendEmailAsync";
            var cliente = new HttpClient();
            var respuesta = await cliente.PostAsJsonAsync(url, mail);
            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Correo enviado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                TxtAsunto.Clear();
                TxtMensaje.Clear();
                lista.Clear();
            }
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            await Enviar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmDireccionesCorreo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lista = FrmDireccionesCorreo.lista;
                foreach (var item in lista)
                {
                    DataDirecciones.Rows.Add(item, "Quitar");
                }
            }

        }
    }
}