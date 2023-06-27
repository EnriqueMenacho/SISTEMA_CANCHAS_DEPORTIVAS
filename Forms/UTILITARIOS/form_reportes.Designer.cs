namespace Gestion_Alquiler_Canchas.Forms.UTILITARIOS
{
    partial class form_reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar_NC = new System.Windows.Forms.Button();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.dgv_Reservas);
            this.panel1.Controls.Add(this.btnCancelar_NC);
            this.panel1.Controls.Add(this.lblNuevoCliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 587);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar_NC
            // 
            this.btnCancelar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_NC.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar_NC.Location = new System.Drawing.Point(482, 536);
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
            this.lblNuevoCliente.Location = new System.Drawing.Point(255, 13);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(591, 40);
            this.lblNuevoCliente.TabIndex = 1;
            this.lblNuevoCliente.Text = "REPORTES RESERVAS COMPLETOS";
            // 
            // dgv_Reservas
            // 
            this.dgv_Reservas.AllowUserToAddRows = false;
            this.dgv_Reservas.AllowUserToDeleteRows = false;
            this.dgv_Reservas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservas.Location = new System.Drawing.Point(17, 67);
            this.dgv_Reservas.Name = "dgv_Reservas";
            this.dgv_Reservas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_Reservas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Reservas.Size = new System.Drawing.Size(1129, 463);
            this.dgv_Reservas.TabIndex = 14;
            // 
            // form_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_reportes";
            this.Load += new System.EventHandler(this.form_reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Button btnCancelar_NC;
        private System.Windows.Forms.DataGridView dgv_Reservas;
    }
}