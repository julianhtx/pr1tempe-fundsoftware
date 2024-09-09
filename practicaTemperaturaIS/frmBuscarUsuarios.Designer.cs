namespace practicaTemperaturaIS
{
    partial class frmBuscarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarUsuarios));
            this.txtBusquedaU = new System.Windows.Forms.TextBox();
            this.dtgvBusqueda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedaU
            // 
            this.txtBusquedaU.Location = new System.Drawing.Point(12, 79);
            this.txtBusquedaU.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaU.Multiline = true;
            this.txtBusquedaU.Name = "txtBusquedaU";
            this.txtBusquedaU.Size = new System.Drawing.Size(901, 35);
            this.txtBusquedaU.TabIndex = 102;
            this.txtBusquedaU.TextChanged += new System.EventHandler(this.txtBusquedaU_TextChanged);
            // 
            // dtgvBusqueda
            // 
            this.dtgvBusqueda.AllowUserToAddRows = false;
            this.dtgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBusqueda.Location = new System.Drawing.Point(13, 145);
            this.dtgvBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvBusqueda.Name = "dtgvBusqueda";
            this.dtgvBusqueda.RowHeadersWidth = 51;
            this.dtgvBusqueda.Size = new System.Drawing.Size(1008, 334);
            this.dtgvBusqueda.TabIndex = 101;
            this.dtgvBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBusqueda_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 46);
            this.label5.TabIndex = 100;
            this.label5.Text = "BÚSQUEDA DE USUARIOS";
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuarios.Image")));
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(931, 68);
            this.btnAgregarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(84, 54);
            this.btnAgregarUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarUsuarios.TabIndex = 103;
            this.btnAgregarUsuarios.TabStop = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // frmBuscarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 500);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.Controls.Add(this.txtBusquedaU);
            this.Controls.Add(this.dtgvBusqueda);
            this.Controls.Add(this.label5);
            this.Name = "frmBuscarUsuarios";
            this.Text = "frmBuscarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAgregarUsuarios;
        private System.Windows.Forms.TextBox txtBusquedaU;
        private System.Windows.Forms.DataGridView dtgvBusqueda;
        private System.Windows.Forms.Label label5;
    }
}