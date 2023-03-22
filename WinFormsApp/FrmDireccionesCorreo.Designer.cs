namespace WinFormsApp
{
    partial class FrmDireccionesCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataDirecciones = new DataGridView();
            correo = new DataGridViewTextBoxColumn();
            seleccionar = new DataGridViewCheckBoxColumn();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DataDirecciones).BeginInit();
            SuspendLayout();
            // 
            // DataDirecciones
            // 
            DataDirecciones.AllowUserToAddRows = false;
            DataDirecciones.AllowUserToDeleteRows = false;
            DataDirecciones.BackgroundColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataDirecciones.ColumnHeadersHeight = 30;
            DataDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataDirecciones.Columns.AddRange(new DataGridViewColumn[] { correo, seleccionar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataDirecciones.DefaultCellStyle = dataGridViewCellStyle2;
            DataDirecciones.Dock = DockStyle.Top;
            DataDirecciones.EnableHeadersVisualStyles = false;
            DataDirecciones.Location = new Point(0, 0);
            DataDirecciones.Name = "DataDirecciones";
            DataDirecciones.RowHeadersVisible = false;
            DataDirecciones.RowTemplate.Height = 25;
            DataDirecciones.Size = new Size(437, 200);
            DataDirecciones.TabIndex = 8;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.Width = 330;
            // 
            // seleccionar
            // 
            seleccionar.HeaderText = "Seleccionar";
            seleccionar.Name = "seleccionar";
            seleccionar.Resizable = DataGridViewTriState.True;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.SlateBlue;
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderColor = Color.White;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnAgregar.IconColor = Color.White;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 30;
            BtnAgregar.Location = new Point(0, 211);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(198, 25);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Aceptar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.SlateBlue;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.White;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnCancelar.IconColor = Color.White;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 30;
            BtnCancelar.Location = new Point(234, 212);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(198, 25);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmDireccionesCorreo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(437, 248);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(DataDirecciones);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "FrmDireccionesCorreo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Direcciones";
            Load += FrmDireccionesCorreo_Load;
            ((System.ComponentModel.ISupportInitialize)DataDirecciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataDirecciones;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewCheckBoxColumn seleccionar;
    }
}