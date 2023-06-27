namespace Gestion_Alquiler_Canchas.Forms.GESTION_ALQUILER
{
    partial class form_ConfirmarReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar_NC = new System.Windows.Forms.Button();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.pnl_buscarReserva = new System.Windows.Forms.Panel();
            this.txtBuscarCi = new System.Windows.Forms.TextBox();
            this.btnBuscarCi = new System.Windows.Forms.Button();
            this.lblBuscarReserva = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_buscarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.dgv_Reservas);
            this.panel1.Controls.Add(this.pnl_buscarReserva);
            this.panel1.Controls.Add(this.btnCancelar_NC);
            this.panel1.Controls.Add(this.lblNuevoCliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 587);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar_NC
            // 
            this.btnCancelar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_NC.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar_NC.Location = new System.Drawing.Point(480, 540);
            this.btnCancelar_NC.Name = "btnCancelar_NC";
            this.btnCancelar_NC.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar_NC.TabIndex = 8;
            this.btnCancelar_NC.Text = "CERRAR";
            this.btnCancelar_NC.UseVisualStyleBackColor = false;
            this.btnCancelar_NC.Click += new System.EventHandler(this.btnCancelar_NC_Click);
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Bold);
            this.lblNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.lblNuevoCliente.Location = new System.Drawing.Point(342, 37);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(405, 40);
            this.lblNuevoCliente.TabIndex = 1;
            this.lblNuevoCliente.Text = "CONFIRMAR RESERVAS";
            // 
            // pnl_buscarReserva
            // 
            this.pnl_buscarReserva.Controls.Add(this.btnEliminarReserva);
            this.pnl_buscarReserva.Controls.Add(this.btnConfirmarReserva);
            this.pnl_buscarReserva.Controls.Add(this.txtBuscarCi);
            this.pnl_buscarReserva.Controls.Add(this.btnBuscarCi);
            this.pnl_buscarReserva.Controls.Add(this.lblBuscarReserva);
            this.pnl_buscarReserva.Location = new System.Drawing.Point(21, 126);
            this.pnl_buscarReserva.Name = "pnl_buscarReserva";
            this.pnl_buscarReserva.Size = new System.Drawing.Size(346, 404);
            this.pnl_buscarReserva.TabIndex = 11;
            // 
            // txtBuscarCi
            // 
            this.txtBuscarCi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtBuscarCi.Location = new System.Drawing.Point(24, 60);
            this.txtBuscarCi.Name = "txtBuscarCi";
            this.txtBuscarCi.Size = new System.Drawing.Size(293, 35);
            this.txtBuscarCi.TabIndex = 7;
            // 
            // btnBuscarCi
            // 
            this.btnBuscarCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btnBuscarCi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCi.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCi.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCi.Location = new System.Drawing.Point(108, 101);
            this.btnBuscarCi.Name = "btnBuscarCi";
            this.btnBuscarCi.Size = new System.Drawing.Size(123, 38);
            this.btnBuscarCi.TabIndex = 8;
            this.btnBuscarCi.Text = "BUSCAR";
            this.btnBuscarCi.UseVisualStyleBackColor = false;
            this.btnBuscarCi.Click += new System.EventHandler(this.btnBuscarCi_Click);
            // 
            // lblBuscarReserva
            // 
            this.lblBuscarReserva.AutoSize = true;
            this.lblBuscarReserva.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBuscarReserva.ForeColor = System.Drawing.Color.White;
            this.lblBuscarReserva.Location = new System.Drawing.Point(18, 32);
            this.lblBuscarReserva.Name = "lblBuscarReserva";
            this.lblBuscarReserva.Size = new System.Drawing.Size(311, 25);
            this.lblBuscarReserva.TabIndex = 6;
            this.lblBuscarReserva.Text = "BUSCAR RESERVA POR C.I.";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Khaki;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1044, 97);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgv_Reservas
            // 
            this.dgv_Reservas.AllowUserToAddRows = false;
            this.dgv_Reservas.AllowUserToDeleteRows = false;
            this.dgv_Reservas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservas.Location = new System.Drawing.Point(384, 126);
            this.dgv_Reservas.Name = "dgv_Reservas";
            this.dgv_Reservas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv_Reservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Reservas.Size = new System.Drawing.Size(757, 404);
            this.dgv_Reservas.TabIndex = 13;
            this.dgv_Reservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reservas_CellContentClick);
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.Khaki;
            this.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarReserva.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarReserva.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarReserva.Location = new System.Drawing.Point(68, 173);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(205, 72);
            this.btnConfirmarReserva.TabIndex = 9;
            this.btnConfirmarReserva.Text = "CONFIRMAR";
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.BackColor = System.Drawing.Color.Khaki;
            this.btnEliminarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarReserva.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnEliminarReserva.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarReserva.Location = new System.Drawing.Point(68, 274);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(205, 72);
            this.btnEliminarReserva.TabIndex = 9;
            this.btnEliminarReserva.Text = "ELIMINAR";
            this.btnEliminarReserva.UseVisualStyleBackColor = false;
            // 
            // form_ConfirmarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ConfirmarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ConfirmarReservas";
            this.Load += new System.EventHandler(this.form_ConfirmarReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_buscarReserva.ResumeLayout(false);
            this.pnl_buscarReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar_NC;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Panel pnl_buscarReserva;
        private System.Windows.Forms.TextBox txtBuscarCi;
        private System.Windows.Forms.Button btnBuscarCi;
        private System.Windows.Forms.Label lblBuscarReserva;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgv_Reservas;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnConfirmarReserva;
    }
}