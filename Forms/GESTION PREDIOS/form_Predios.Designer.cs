namespace Gestion_Alquiler_Canchas.Forms
{
    partial class form_Predios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEliminarCliente = new System.Windows.Forms.Label();
            this.lblModificarCliente = new System.Windows.Forms.Label();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.lbl_tituloCliente = new System.Windows.Forms.Label();
            this.ptbEliminarCliente = new System.Windows.Forms.PictureBox();
            this.ptbModificarCliente = new System.Windows.Forms.PictureBox();
            this.ptbNuevoCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 312);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblEliminarCliente
            // 
            this.lblEliminarCliente.AutoSize = true;
            this.lblEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.lblEliminarCliente.Location = new System.Drawing.Point(980, 544);
            this.lblEliminarCliente.Name = "lblEliminarCliente";
            this.lblEliminarCliente.Size = new System.Drawing.Size(116, 50);
            this.lblEliminarCliente.TabIndex = 13;
            this.lblEliminarCliente.Text = "Eliminar\r\nPredio";
            this.lblEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEliminarCliente.Click += new System.EventHandler(this.ptbEliminarCliente_Click);
            // 
            // lblModificarCliente
            // 
            this.lblModificarCliente.AutoSize = true;
            this.lblModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificarCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCliente.ForeColor = System.Drawing.Color.White;
            this.lblModificarCliente.Location = new System.Drawing.Point(769, 544);
            this.lblModificarCliente.Name = "lblModificarCliente";
            this.lblModificarCliente.Size = new System.Drawing.Size(129, 50);
            this.lblModificarCliente.TabIndex = 14;
            this.lblModificarCliente.Text = "Modificar\r\nCliente";
            this.lblModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModificarCliente.Click += new System.EventHandler(this.ptbModificarCliente_Click);
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.lblNuevoCliente.Location = new System.Drawing.Point(575, 544);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(103, 50);
            this.lblNuevoCliente.TabIndex = 15;
            this.lblNuevoCliente.Text = "Agragar\r\nPredio";
            this.lblNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNuevoCliente.Click += new System.EventHandler(this.ptbNuevoCliente_Click);
            // 
            // lbl_tituloCliente
            // 
            this.lbl_tituloCliente.AutoSize = true;
            this.lbl_tituloCliente.Font = new System.Drawing.Font("Stencil", 40.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloCliente.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloCliente.Location = new System.Drawing.Point(316, 9);
            this.lbl_tituloCliente.Name = "lbl_tituloCliente";
            this.lbl_tituloCliente.Size = new System.Drawing.Size(582, 64);
            this.lbl_tituloCliente.TabIndex = 16;
            this.lbl_tituloCliente.Text = "GESTION DE PREDIOS";
            // 
            // ptbEliminarCliente
            // 
            this.ptbEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbEliminarCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.eliminar_predio;
            this.ptbEliminarCliente.Location = new System.Drawing.Point(986, 432);
            this.ptbEliminarCliente.Name = "ptbEliminarCliente";
            this.ptbEliminarCliente.Size = new System.Drawing.Size(104, 109);
            this.ptbEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEliminarCliente.TabIndex = 10;
            this.ptbEliminarCliente.TabStop = false;
            this.ptbEliminarCliente.Tag = "";
            this.ptbEliminarCliente.Click += new System.EventHandler(this.ptbEliminarCliente_Click);
            // 
            // ptbModificarCliente
            // 
            this.ptbModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbModificarCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.edit_cliente;
            this.ptbModificarCliente.Location = new System.Drawing.Point(779, 432);
            this.ptbModificarCliente.Name = "ptbModificarCliente";
            this.ptbModificarCliente.Size = new System.Drawing.Size(104, 109);
            this.ptbModificarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbModificarCliente.TabIndex = 11;
            this.ptbModificarCliente.TabStop = false;
            this.ptbModificarCliente.Tag = "";
            this.ptbModificarCliente.Click += new System.EventHandler(this.ptbModificarCliente_Click);
            // 
            // ptbNuevoCliente
            // 
            this.ptbNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbNuevoCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.new_reserva;
            this.ptbNuevoCliente.Location = new System.Drawing.Point(574, 432);
            this.ptbNuevoCliente.Name = "ptbNuevoCliente";
            this.ptbNuevoCliente.Size = new System.Drawing.Size(104, 109);
            this.ptbNuevoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNuevoCliente.TabIndex = 12;
            this.ptbNuevoCliente.TabStop = false;
            this.ptbNuevoCliente.Tag = "";
            this.ptbNuevoCliente.Click += new System.EventHandler(this.ptbNuevoCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.PRUEBA_JPG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.homeWhite;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(79, 64);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 7;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Khaki;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1066, 63);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // form_Predios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lbl_tituloCliente);
            this.Controls.Add(this.lblEliminarCliente);
            this.Controls.Add(this.lblModificarCliente);
            this.Controls.Add(this.lblNuevoCliente);
            this.Controls.Add(this.ptbEliminarCliente);
            this.Controls.Add(this.ptbModificarCliente);
            this.Controls.Add(this.ptbNuevoCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Predios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Predios";
            this.Load += new System.EventHandler(this.form_Predios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEliminarCliente;
        private System.Windows.Forms.Label lblModificarCliente;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.PictureBox ptbEliminarCliente;
        private System.Windows.Forms.PictureBox ptbModificarCliente;
        private System.Windows.Forms.PictureBox ptbNuevoCliente;
        private System.Windows.Forms.Label lbl_tituloCliente;
        private System.Windows.Forms.Button btnActualizar;
    }
}