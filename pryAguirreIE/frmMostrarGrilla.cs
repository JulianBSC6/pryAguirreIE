using Microsoft.Win32;
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
    public partial class frmMostrarGrilla : Form
    {

        

        public frmMostrarGrilla()
        {
            InitializeComponent();
        }
       
        private void frmMostrarGrilla_Load(object sender, EventArgs e)
        {
           
        }

        private void GrillaMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores volver = new Proveedores();
            volver.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargarProveedores cargar = new CargarProveedores();
            cargar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //En la variable n guardo el indice de la fila seleccionada en la grilla
            int n = GrillaMostrar.CurrentCell.RowIndex;

            CargarProveedores modificar = new CargarProveedores();

            //El ReadOnly solo deja ver el contenido del txt no deja que se modifique
            modificar.txtNumero.ReadOnly = true;
            //Cargo todos los txt del formulario ABM para que solo modifique lo que quiera, sin tener que cargar todo de nuevo
            modificar.txtNumero.Text = GrillaMostrar.Rows[n].Cells[0].Value.ToString();
            modificar.txtEntidad.Text = GrillaMostrar.Rows[n].Cells[1].Value.ToString();
            modificar.txtApertura.Text = GrillaMostrar.Rows[n].Cells[2].Value.ToString();
            modificar.txtExpediente.Text = GrillaMostrar.Rows[n].Cells[3].Value.ToString();
            modificar.txtJuzgado.Text = GrillaMostrar.Rows[n].Cells[4].Value.ToString();
            modificar.txtJurisdiccion.Text = GrillaMostrar.Rows[n].Cells[5].Value.ToString();
            modificar.txtDireccion.Text = GrillaMostrar.Rows[n].Cells[6].Value.ToString();
            modificar.txtLiquidador.Text = GrillaMostrar.Rows[n].Cells[7].Value.ToString();

            string ID = Convert.ToString(GrillaMostrar.Rows[n].Cells[0].Value);


            modificar.btnModificar.Enabled=true;
            modificar.Show();
            this.Hide();




        }
        public static string RutaFull;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //n es el número de fila seleccionado en la grilla
            int n = GrillaMostrar.CurrentCell.RowIndex;

            if (n != -1)
            {
                //ID es el número de la celda 0 de la fila seleccionada 
                string ID = Convert.ToString(GrillaMostrar.Rows[n].Cells[0].Value);

                //Es una lista que funciona igual que un vector pero tiene métodos propios
                List<string> lineasArchivo = new List<string>();

                using (StreamReader reader = new StreamReader(RutaFull))
                {

                    // Lee el resto de las líneas
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Procesa la línea actual aquí y separo los campos con ";"
                        string[] parametros = linea.Split(';');
                        //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                        if (parametros[0] != ID)
                        {
                            lineasArchivo.Add(linea);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(RutaFull))
                {
                    foreach (string elemento in lineasArchivo)
                    {
                        // Escribe cada elemento en una línea del archivo, el elemento contiene la línea guardada en el índice momentáneo de la lista
                        writer.WriteLine(elemento);
                    }
                }

                MessageBox.Show("El registro fue eliminado correctamente.");

                GrillaMostrar.Rows.RemoveAt(n);
            }
        }
    }
}
    

