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
            this.btnBuscarCarpeta = new System.Windows.Forms.Button();
            this.lblDireccionCarpeta = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLeer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarCarpeta
            // 
            this.btnBuscarCarpeta.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarpeta.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBuscarCarpeta.Location = new System.Drawing.Point(36, 31);
            this.btnBuscarCarpeta.Name = "btnBuscarCarpeta";
            this.btnBuscarCarpeta.Size = new System.Drawing.Size(161, 39);
            this.btnBuscarCarpeta.TabIndex = 1;
            this.btnBuscarCarpeta.Text = "Buscar Carpeta";
            this.btnBuscarCarpeta.UseVisualStyleBackColor = false;
            this.btnBuscarCarpeta.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // lblDireccionCarpeta
            // 
            this.lblDireccionCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCarpeta.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDireccionCarpeta.Location = new System.Drawing.Point(236, 36);
            this.lblDireccionCarpeta.Name = "lblDireccionCarpeta";
            this.lblDireccionCarpeta.Size = new System.Drawing.Size(228, 34);
            this.lblDireccionCarpeta.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Black;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAbrir.Location = new System.Drawing.Point(36, 150);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(161, 39);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtLeer
            // 
            this.txtLeer.Location = new System.Drawing.Point(239, 161);
            this.txtLeer.Multiline = true;
            this.txtLeer.Name = "txtLeer";
            this.txtLeer.Size = new System.Drawing.Size(266, 207);
            this.txtLeer.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.txtLeer);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblDireccionCarpeta);
            this.Controls.Add(this.btnBuscarCarpeta);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarCarpeta;
        private System.Windows.Forms.Label lblDireccionCarpeta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLeer;
    }
}