﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryAguirreIE
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void AbrirArchivo_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            lblDireccionCarpeta.Text = folderBrowserDialog1.SelectedPath;






        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog LeerArchivo = new OpenFileDialog();
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader Leer = new StreamReader(LeerArchivo.FileName);
                txtLeer.Text= Leer.ReadToEnd();
                Leer.Close();
            }

        }
    }
}
