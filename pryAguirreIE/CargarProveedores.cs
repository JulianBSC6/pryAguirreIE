using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAguirreIE
{
    public partial class CargarProveedores : Form
    {
        public CargarProveedores()
        {
            InitializeComponent();
        }
        clsGrabarArchivo varGrabar= new clsGrabarArchivo();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            varGrabar.Grabar(txtNumero.Text, txtEntidad.Text, txtApertura.Text, txtExpediente.Text, txtJuzgado.Text,txtJurisdiccion.Text, txtDireccion.Text, txtLiquidador.Text);
            MessageBox.Show("Datos grabados");
            txtNumero.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtExpediente.Text = "";
            txtJuzgado.Text = "";
            txtJurisdiccion.Text = "";
            txtDireccion.Text = "";
            txtLiquidador.Text = "";
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio volver = new frmInicio();
            volver.Show();
        }

        public void CargarProveedores_Load(object sender, EventArgs e)
        {

        }
        public static string RutaFull;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string ID = txtNumero.Text;
            List<string> LineaArchivo = new List<string>(); 

            using (StreamReader leer = new StreamReader(RutaFull)) 
            {
                string line;
                while((line=leer.ReadLine())!=null) 
                {
                    string [] parametros = line.Split(';');
                    if (parametros[0]!=ID)
                    {
                        LineaArchivo.Add(line);

                    }
                    else
                    {
                        string nuevaLinea = txtNumero.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtExpediente.Text + ";"+ txtJuzgado.Text + ";" + txtJurisdiccion.Text + ";" + txtDireccion.Text + ";" + txtLiquidador.Text;
                        LineaArchivo.Add(nuevaLinea);

                    }
                }
            }
            using (StreamWriter escribir = new StreamWriter(RutaFull))
            {
                foreach(string elemento in LineaArchivo)
                {
                    escribir.WriteLine(elemento);
                }
                
            }
            MessageBox.Show("Modificado correctamente");
        }
    }
}
