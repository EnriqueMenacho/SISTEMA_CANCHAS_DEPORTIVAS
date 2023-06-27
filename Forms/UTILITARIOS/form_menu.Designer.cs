namespace Gestion_Alquiler_Canchas.Forms
{
    partial class form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            this.pnClientes = new System.Windows.Forms.Panel();
            this.ptbCliente = new System.Windows.Forms.PictureBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnAlquilerReservas = new System.Windows.Forms.Panel();
            this.ptbAlquilerReserva = new System.Windows.Forms.PictureBox();
            this.lblAlquilerReservas = new System.Windows.Forms.Label();
            this.pnPredios = new System.Windows.Forms.Panel();
            this.ptbPredios = new System.Windows.Forms.PictureBox();
            this.lblPredios = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.ptb_NuevoUsusario = new System.Windows.Forms.PictureBox();
            this.ptb_Reportes = new System.Windows.Forms.PictureBox();
            this.ptbConfirmarReserva = new System.Windows.Forms.PictureBox();
            this.pictureMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pnClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).BeginInit();
            this.pnAlquilerReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlquilerReserva)).BeginInit();
            this.pnPredios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPredios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NuevoUsusario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmarReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnClientes
            // 
            this.pnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            this.pnClientes.Controls.Add(this.ptbCliente);
            this.pnClientes.Controls.Add(this.lblClientes);
            this.pnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClientes.Location = new System.Drawing.Point(12, 12);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Size = new System.Drawing.Size(331, 625);
            this.pnClientes.TabIndex = 0;
            this.pnClientes.Click += new System.EventHandler(this.panel1_Click);
            this.pnClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ptbCliente
            // 
            this.ptbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.user;
            this.ptbCliente.Location = new System.Drawing.Point(19, 105);
            this.ptbCliente.Name = "ptbCliente";
            this.ptbCliente.Size = new System.Drawing.Size(276, 302);
            this.ptbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCliente.TabIndex = 1;
            this.ptbCliente.TabStop = false;
            this.ptbCliente.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold);
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(36, 432);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(245, 56);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "CLIENTES";
            this.lblClientes.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnAlquilerReservas
            // 
            this.pnAlquilerReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.pnAlquilerReservas.Controls.Add(this.ptbAlquilerReserva);
            this.pnAlquilerReservas.Controls.Add(this.lblAlquilerReservas);
            this.pnAlquilerReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAlquilerReservas.Location = new System.Drawing.Point(349, 12);
            this.pnAlquilerReservas.Name = "pnAlquilerReservas";
            this.pnAlquilerReservas.Size = new System.Drawing.Size(331, 625);
            this.pnAlquilerReservas.TabIndex = 1;
            this.pnAlquilerReservas.Click += new System.EventHandler(this.panel2_Click);
            this.pnAlquilerReservas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ptbAlquilerReserva
            // 
            this.ptbAlquilerReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAlquilerReserva.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.notes;
            this.ptbAlquilerReserva.Location = new System.Drawing.Point(66, 105);
            this.ptbAlquilerReserva.Name = "ptbAlquilerReserva";
            this.ptbAlquilerReserva.Size = new System.Drawing.Size(276, 302);
            this.ptbAlquilerReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAlquilerReserva.TabIndex = 1;
            this.ptbAlquilerReserva.TabStop = false;
            this.ptbAlquilerReserva.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblAlquilerReservas
            // 
            this.lblAlquilerReservas.AutoSize = true;
            this.lblAlquilerReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlquilerReservas.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquilerReservas.ForeColor = System.Drawing.Color.White;
            this.lblAlquilerReservas.Location = new System.Drawing.Point(29, 410);
            this.lblAlquilerReservas.Name = "lblAlquilerReservas";
            this.lblAlquilerReservas.Size = new System.Drawing.Size(276, 112);
            this.lblAlquilerReservas.TabIndex = 0;
            this.lblAlquilerReservas.Text = " ALQUILER\r\n RESERVAS";
            this.lblAlquilerReservas.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pnPredios
            // 
            this.pnPredios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.pnPredios.Controls.Add(this.ptbPredios);
            this.pnPredios.Controls.Add(this.lblPredios);
            this.pnPredios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPredios.Location = new System.Drawing.Point(686, 12);
            this.pnPredios.Name = "pnPredios";
            this.pnPredios.Size = new System.Drawing.Size(331, 625);
            this.pnPredios.TabIndex = 1;
            this.pnPredios.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // ptbPredios
            // 
            this.ptbPredios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbPredios.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.football_field;
            this.ptbPredios.Location = new System.Drawing.Point(30, 105);
            this.ptbPredios.Name = "ptbPredios";
            this.ptbPredios.Size = new System.Drawing.Size(276, 302);
            this.ptbPredios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPredios.TabIndex = 1;
            this.ptbPredios.TabStop = false;
            this.ptbPredios.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // lblPredios
            // 
            this.lblPredios.AutoSize = true;
            this.lblPredios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPredios.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold);
            this.lblPredios.ForeColor = System.Drawing.Color.White;
            this.lblPredios.Location = new System.Drawing.Point(20, 410);
            this.lblPredios.Name = "lblPredios";
            this.lblPredios.Size = new System.Drawing.Size(293, 112);
            this.lblPredios.TabIndex = 0;
            this.lblPredios.Text = " NUESTROS \r\n   PREDIOS";
            this.lblPredios.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(1043, 555);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(123, 60);
            this.btn_CerrarSesion.TabIndex = 9;
            this.btn_CerrarSesion.Text = "CERRAR\r\nSESION";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // ptb_NuevoUsusario
            // 
            this.ptb_NuevoUsusario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_NuevoUsusario.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.NUEVO_USUARIOMenu;
            this.ptb_NuevoUsusario.Location = new System.Drawing.Point(1035, 389);
            this.ptb_NuevoUsusario.Name = "ptb_NuevoUsusario";
            this.ptb_NuevoUsusario.Size = new System.Drawing.Size(142, 142);
            this.ptb_NuevoUsusario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_NuevoUsusario.TabIndex = 8;
            this.ptb_NuevoUsusario.TabStop = false;
            this.ptb_NuevoUsusario.Click += new System.EventHandler(this.ptb_NuevoUsusario_Click);
            this.ptb_NuevoUsusario.MouseLeave += new System.EventHandler(this.ptb_NuevoUsusario_MouseLeave);
            this.ptb_NuevoUsusario.MouseHover += new System.EventHandler(this.ptb_NuevoUsusario_MouseHover);
            // 
            // ptb_Reportes
            // 
            this.ptb_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Reportes.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.ResportesMenu;
            this.ptb_Reportes.Location = new System.Drawing.Point(1035, 235);
            this.ptb_Reportes.Name = "ptb_Reportes";
            this.ptb_Reportes.Size = new System.Drawing.Size(142, 142);
            this.ptb_Reportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Reportes.TabIndex = 8;
            this.ptb_Reportes.TabStop = false;
            this.ptb_Reportes.Click += new System.EventHandler(this.ptb_Reportes_Click);
            this.ptb_Reportes.MouseLeave += new System.EventHandler(this.ptb_Reportes_MouseLeave);
            this.ptb_Reportes.MouseHover += new System.EventHandler(this.ptb_Reportes_MouseHover);
            // 
            // ptbConfirmarReserva
            // 
            this.ptbConfirmarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbConfirmarReserva.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.Confirmar_reserva_png;
            this.ptbConfirmarReserva.Location = new System.Drawing.Point(1035, 81);
            this.ptbConfirmarReserva.Name = "ptbConfirmarReserva";
            this.ptbConfirmarReserva.Size = new System.Drawing.Size(142, 142);
            this.ptbConfirmarReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbConfirmarReserva.TabIndex = 8;
            this.ptbConfirmarReserva.TabStop = false;
            this.ptbConfirmarReserva.Click += new System.EventHandler(this.ptbConfirmarReserva_Click);
            this.ptbConfirmarReserva.MouseLeave += new System.EventHandler(this.ptbConfirmarReserva_MouseLeave);
            this.ptbConfirmarReserva.MouseHover += new System.EventHandler(this.ptbConfirmarReserva_MouseHover);
            // 
            // pictureMinimizar
            // 
            this.pictureMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimizar.Image")));
            this.pictureMinimizar.Location = new System.Drawing.Point(1118, 12);
            this.pictureMinimizar.Name = "pictureMinimizar";
            this.pictureMinimizar.Size = new System.Drawing.Size(24, 23);
            this.pictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimizar.TabIndex = 7;
            this.pictureMinimizar.TabStop = false;
            this.pictureMinimizar.Click += new System.EventHandler(this.pictureMinimizar_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(1148, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(24, 23);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 6;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.ptb_NuevoUsusario);
            this.Controls.Add(this.ptb_Reportes);
            this.Controls.Add(this.ptbConfirmarReserva);
            this.Controls.Add(this.pictureMinimizar);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.pnPredios);
            this.Controls.Add(this.pnAlquilerReservas);
            this.Controls.Add(this.pnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.pnClientes.ResumeLayout(false);
            this.pnClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCliente)).EndInit();
            this.pnAlquilerReservas.ResumeLayout(false);
            this.pnAlquilerReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlquilerReserva)).EndInit();
            this.pnPredios.ResumeLayout(false);
            this.pnPredios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPredios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_NuevoUsusario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmarReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel pnAlquilerReservas;
        private System.Windows.Forms.Panel pnPredios;
        private System.Windows.Forms.Label lblAlquilerReservas;
        private System.Windows.Forms.Label lblPredios;
        private System.Windows.Forms.PictureBox pictureMinimizar;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox ptbCliente;
        private System.Windows.Forms.PictureBox ptbAlquilerReserva;
        private System.Windows.Forms.PictureBox ptbPredios;
        private System.Windows.Forms.PictureBox ptbConfirmarReserva;
        private System.Windows.Forms.PictureBox ptb_Reportes;
        private System.Windows.Forms.PictureBox ptb_NuevoUsusario;
        private System.Windows.Forms.Button btn_CerrarSesion;
    }
}