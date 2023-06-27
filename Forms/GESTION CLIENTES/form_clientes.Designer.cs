namespace Gestion_Alquiler_Canchas.Forms
{
    partial class form_clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_tituloCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alquiler_CanchasDataSet1 = new Gestion_Alquiler_Canchas.Alquiler_CanchasDataSet1();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.lblModificarCliente = new System.Windows.Forms.Label();
            this.lblEliminarCliente = new System.Windows.Forms.Label();
            this.lblBuscarCi = new System.Windows.Forms.Label();
            this.txtBuscarCi = new System.Windows.Forms.TextBox();
            this.btnBuscarCi = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquiler_CanchasDataSet = new Gestion_Alquiler_Canchas.Alquiler_CanchasDataSet();
            this.clienteTableAdapter = new Gestion_Alquiler_Canchas.Alquiler_CanchasDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new Gestion_Alquiler_Canchas.Alquiler_CanchasDataSet1TableAdapters.ClienteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbEliminarCliente = new System.Windows.Forms.PictureBox();
            this.ptbModificarCliente = new System.Windows.Forms.PictureBox();
            this.ptbNuevoCliente = new System.Windows.Forms.PictureBox();
            this.alquiler_CanchasDataSet2 = new Gestion_Alquiler_Canchas.Alquiler_CanchasDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tituloCliente
            // 
            this.lbl_tituloCliente.AutoSize = true;
            this.lbl_tituloCliente.Font = new System.Drawing.Font("Stencil", 40.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloCliente.Location = new System.Drawing.Point(437, 9);
            this.lbl_tituloCliente.Name = "lbl_tituloCliente";
            this.lbl_tituloCliente.Size = new System.Drawing.Size(279, 64);
            this.lbl_tituloCliente.TabIndex = 0;
            this.lbl_tituloCliente.Text = "CLIENTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(64, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.alquiler_CanchasDataSet1;
            // 
            // alquiler_CanchasDataSet1
            // 
            this.alquiler_CanchasDataSet1.DataSetName = "Alquiler_CanchasDataSet1";
            this.alquiler_CanchasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCliente.Location = new System.Drawing.Point(558, 256);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(103, 50);
            this.lblNuevoCliente.TabIndex = 4;
            this.lblNuevoCliente.Text = "Nuevo\r\nCliente";
            this.lblNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNuevoCliente.Click += new System.EventHandler(this.ptbNuevoCliente_Click);
            // 
            // lblModificarCliente
            // 
            this.lblModificarCliente.AutoSize = true;
            this.lblModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificarCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCliente.Location = new System.Drawing.Point(753, 256);
            this.lblModificarCliente.Name = "lblModificarCliente";
            this.lblModificarCliente.Size = new System.Drawing.Size(129, 50);
            this.lblModificarCliente.TabIndex = 4;
            this.lblModificarCliente.Text = "Modificar\r\nCliente";
            this.lblModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModificarCliente.Click += new System.EventHandler(this.ptbModificarCliente_Click);
            // 
            // lblEliminarCliente
            // 
            this.lblEliminarCliente.AutoSize = true;
            this.lblEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarCliente.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCliente.Location = new System.Drawing.Point(964, 256);
            this.lblEliminarCliente.Name = "lblEliminarCliente";
            this.lblEliminarCliente.Size = new System.Drawing.Size(116, 50);
            this.lblEliminarCliente.TabIndex = 4;
            this.lblEliminarCliente.Text = "Eliminar\r\nCliente";
            this.lblEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEliminarCliente.Click += new System.EventHandler(this.ptbEliminarCliente_Click);
            // 
            // lblBuscarCi
            // 
            this.lblBuscarCi.AutoSize = true;
            this.lblBuscarCi.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBuscarCi.Location = new System.Drawing.Point(62, 8);
            this.lblBuscarCi.Name = "lblBuscarCi";
            this.lblBuscarCi.Size = new System.Drawing.Size(207, 25);
            this.lblBuscarCi.TabIndex = 6;
            this.lblBuscarCi.Text = "BUSCAR POR C.I.";
            // 
            // txtBuscarCi
            // 
            this.txtBuscarCi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtBuscarCi.Location = new System.Drawing.Point(3, 50);
            this.txtBuscarCi.Name = "txtBuscarCi";
            this.txtBuscarCi.Size = new System.Drawing.Size(328, 35);
            this.txtBuscarCi.TabIndex = 7;
            // 
            // btnBuscarCi
            // 
            this.btnBuscarCi.BackColor = System.Drawing.Color.Khaki;
            this.btnBuscarCi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCi.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCi.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCi.Location = new System.Drawing.Point(94, 101);
            this.btnBuscarCi.Name = "btnBuscarCi";
            this.btnBuscarCi.Size = new System.Drawing.Size(123, 38);
            this.btnBuscarCi.TabIndex = 8;
            this.btnBuscarCi.Text = "BUSCAR";
            this.btnBuscarCi.UseVisualStyleBackColor = false;
            this.btnBuscarCi.Click += new System.EventHandler(this.btnBuscarCi_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.alquiler_CanchasDataSet;
            // 
            // alquiler_CanchasDataSet
            // 
            this.alquiler_CanchasDataSet.DataSetName = "Alquiler_CanchasDataSet";
            this.alquiler_CanchasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.alquiler_CanchasDataSet;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarCi);
            this.panel1.Controls.Add(this.btnBuscarCi);
            this.panel1.Controls.Add(this.lblBuscarCi);
            this.panel1.Location = new System.Drawing.Point(119, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 148);
            this.panel1.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Khaki;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(75, 304);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.homeWhite;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbEliminarCliente
            // 
            this.ptbEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbEliminarCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.delete_cliente;
            this.ptbEliminarCliente.Location = new System.Drawing.Point(935, 105);
            this.ptbEliminarCliente.Name = "ptbEliminarCliente";
            this.ptbEliminarCliente.Size = new System.Drawing.Size(170, 148);
            this.ptbEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEliminarCliente.TabIndex = 3;
            this.ptbEliminarCliente.TabStop = false;
            this.ptbEliminarCliente.Tag = "";
            this.ptbEliminarCliente.Click += new System.EventHandler(this.ptbEliminarCliente_Click);
            // 
            // ptbModificarCliente
            // 
            this.ptbModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbModificarCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.edit_cliente;
            this.ptbModificarCliente.Location = new System.Drawing.Point(728, 105);
            this.ptbModificarCliente.Name = "ptbModificarCliente";
            this.ptbModificarCliente.Size = new System.Drawing.Size(170, 148);
            this.ptbModificarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbModificarCliente.TabIndex = 3;
            this.ptbModificarCliente.TabStop = false;
            this.ptbModificarCliente.Tag = "";
            this.ptbModificarCliente.Click += new System.EventHandler(this.ptbModificarCliente_Click);
            // 
            // ptbNuevoCliente
            // 
            this.ptbNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbNuevoCliente.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.add_cliente;
            this.ptbNuevoCliente.Location = new System.Drawing.Point(523, 105);
            this.ptbNuevoCliente.Name = "ptbNuevoCliente";
            this.ptbNuevoCliente.Size = new System.Drawing.Size(170, 148);
            this.ptbNuevoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNuevoCliente.TabIndex = 3;
            this.ptbNuevoCliente.TabStop = false;
            this.ptbNuevoCliente.Tag = "";
            this.ptbNuevoCliente.Click += new System.EventHandler(this.ptbNuevoCliente_Click);
            // 
            // alquiler_CanchasDataSet2
            // 
            this.alquiler_CanchasDataSet2.DataSetName = "Alquiler_CanchasDataSet";
            this.alquiler_CanchasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEliminarCliente);
            this.Controls.Add(this.lblModificarCliente);
            this.Controls.Add(this.lblNuevoCliente);
            this.Controls.Add(this.ptbEliminarCliente);
            this.Controls.Add(this.ptbModificarCliente);
            this.Controls.Add(this.ptbNuevoCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_tituloCliente);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_clientes";
            this.Load += new System.EventHandler(this.form_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModificarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquiler_CanchasDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Alquiler_CanchasDataSet alquiler_CanchasDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Alquiler_CanchasDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.PictureBox ptbNuevoCliente;
        private System.Windows.Forms.PictureBox ptbModificarCliente;
        private System.Windows.Forms.PictureBox ptbEliminarCliente;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Label lblModificarCliente;
        private System.Windows.Forms.Label lblEliminarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBuscarCi;
        private System.Windows.Forms.TextBox txtBuscarCi;
        private System.Windows.Forms.Button btnBuscarCi;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private Alquiler_CanchasDataSet1 alquiler_CanchasDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private Alquiler_CanchasDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private Alquiler_CanchasDataSet alquiler_CanchasDataSet2;
    }
}