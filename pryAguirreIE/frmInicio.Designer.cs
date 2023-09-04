namespace pryAguirreIE
{
    partial class frmInicio
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
            this.Listado = new System.Windows.Forms.TreeView();
            this.AbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.lblDireccionCarpeta = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Listado
            // 
            this.Listado.Location = new System.Drawing.Point(293, 69);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(212, 230);
            this.Listado.TabIndex = 0;
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.FileName = "openFileDialog1";
            this.AbrirArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.AbrirArchivo_FileOk);
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.BackColor = System.Drawing.Color.Black;
            this.btnBuscarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarArchivo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArchivo.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarArchivo.Location = new System.Drawing.Point(36, 31);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(161, 39);
            this.btnBuscarArchivo.TabIndex = 1;
            this.btnBuscarArchivo.Text = "Buscar Archivos";
            this.btnBuscarArchivo.UseVisualStyleBackColor = false;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // lblDireccionCarpeta
            // 
            this.lblDireccionCarpeta.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCarpeta.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDireccionCarpeta.Location = new System.Drawing.Point(32, 93);
            this.lblDireccionCarpeta.Name = "lblDireccionCarpeta";
            this.lblDireccionCarpeta.Size = new System.Drawing.Size(228, 34);
            this.lblDireccionCarpeta.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.lblDireccionCarpeta);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.Listado);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Listado;
        private System.Windows.Forms.OpenFileDialog AbrirArchivo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.Label lblDireccionCarpeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}