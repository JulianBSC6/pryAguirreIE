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
    public partial class frmMostrarClientes : Form
    {
        clsBaseDatos objBaseDatos;
        public frmMostrarClientes()
        {
            InitializeComponent();
        }

        private void frmMostrarClientes_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            objBaseDatos.ConectarBD();
            lblEstadoConexion.Text = objBaseDatos.EstadoConexion;
            lblEstadoConexion.BackColor = Color.Green;
            objBaseDatos.TraerDatos(dgvMostrar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorCodigo(int.Parse(txtBuscar.Text));
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorApellido(txtApellido.Text);
        }
        int id = 0;
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtCambiarActivo.Text);
            clsBaseDatos objBaseDatos = new clsBaseDatos();

            objBaseDatos.CambiarEstadoCliente(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio volver = new frmInicio();
            volver.ShowDialog();
        }
    }
}
