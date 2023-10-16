using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
    

