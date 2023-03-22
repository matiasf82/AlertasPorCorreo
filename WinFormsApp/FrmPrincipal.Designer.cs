namespace WinFormsApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtAsunto = new TextBox();
            TxtMensaje = new TextBox();
            BtnEnviar = new FontAwesome.Sharp.IconButton();
            DataDirecciones = new DataGridView();
            correo = new DataGridViewTextBoxColumn();
            quitar = new DataGridViewButtonColumn();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DataDirecciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 16);
            label1.TabIndex = 0;
            label1.Text = "Direccion Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 1;
            label2.Text = "Asunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 208);
            label3.Name = "label3";
            label3.Size = new Size(60, 16);
            label3.TabIndex = 2;
            label3.Text = "Mensaje:";
            // 
            // TxtAsunto
            // 
            TxtAsunto.Location = new Point(12, 29);
            TxtAsunto.Name = "TxtAsunto";
            TxtAsunto.Size = new Size(419, 22);
            TxtAsunto.TabIndex = 3;
            // 
            // TxtMensaje
            // 
            TxtMensaje.Location = new Point(12, 227);
            TxtMensaje.Multiline = true;
            TxtMensaje.Name = "TxtMensaje";
            TxtMensaje.Size = new Size(419, 191);
            TxtMensaje.TabIndex = 5;
            // 
            // BtnEnviar
            // 
            BtnEnviar.BackColor = Color.SlateBlue;
            BtnEnviar.Cursor = Cursors.Hand;
            BtnEnviar.FlatAppearance.BorderColor = Color.White;
            BtnEnviar.FlatStyle = FlatStyle.Flat;
            BtnEnviar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEnviar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            BtnEnviar.IconColor = Color.White;
            BtnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEnviar.IconSize = 30;
            BtnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEnviar.Location = new Point(12, 428);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(419, 30);
            BtnEnviar.TabIndex = 6;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = false;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // DataDirecciones
            // 
            DataDirecciones.AllowUserToAddRows = false;
            DataDirecciones.AllowUserToDeleteRows = false;
            DataDirecciones.AllowUserToResizeColumns = false;
            DataDirecciones.AllowUserToResizeRows = false;
            DataDirecciones.BackgroundColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataDirecciones.ColumnHeadersHeight = 28;
            DataDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataDirecciones.Columns.AddRange(new DataGridViewColumn[] { correo, quitar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataDirecciones.DefaultCellStyle = dataGridViewCellStyle2;
            DataDirecciones.EnableHeadersVisualStyles = false;
            DataDirecciones.Location = new Point(12, 91);
            DataDirecciones.Name = "DataDirecciones";
            DataDirecciones.ReadOnly = true;
            DataDirecciones.RowHeadersVisible = false;
            DataDirecciones.RowTemplate.Height = 25;
            DataDirecciones.Size = new Size(419, 114);
            DataDirecciones.TabIndex = 7;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            correo.Width = 300;
            // 
            // quitar
            // 
            quitar.FlatStyle = FlatStyle.Popup;
            quitar.HeaderText = "Quitar";
            quitar.Name = "quitar";
            quitar.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DarkSlateBlue;
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderColor = Color.White;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAgregar.IconColor = Color.White;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 30;
            BtnAgregar.Location = new Point(130, 60);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(43, 22);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(445, 470);
            Controls.Add(BtnAgregar);
            Controls.Add(DataDirecciones);
            Controls.Add(BtnEnviar);
            Controls.Add(TxtMensaje);
            Controls.Add(TxtAsunto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enviar Correos";
            ((System.ComponentModel.ISupportInitialize)DataDirecciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtAsunto;
        private TextBox TxtMensaje;
        private FontAwesome.Sharp.IconButton BtnEnviar;
        private DataGridView DataDirecciones;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewButtonColumn quitar;
    }
}