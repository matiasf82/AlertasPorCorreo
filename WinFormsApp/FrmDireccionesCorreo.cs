using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmDireccionesCorreo : Form
    {
        public static List<string> lista = new List<string>();

        public FrmDireccionesCorreo()
        {
            InitializeComponent();
        }

        private void CargarDirecciones()
        {
            DataDirecciones.Rows.Add("matiasferreyra82@outlook.com.ar");
            DataDirecciones.Rows.Add("victoriagervasoni@outlook.com.ar");
            DataDirecciones.Rows.Add("matias.nicolas.ferreyra82@gmail.com");
        }

        private void FrmDireccionesCorreo_Load(object sender, EventArgs e)
        {
            CargarDirecciones();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            lista.Clear();
            foreach (DataGridViewRow item in DataDirecciones.Rows)
            {
                if (Convert.ToBoolean(item.Cells["seleccionar"].Value) == true)
                {
                    lista.Add(item.Cells["correo"].Value.ToString());
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
