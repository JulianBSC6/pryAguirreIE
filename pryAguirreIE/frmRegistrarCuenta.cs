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
    public partial class frmRegistrarCuenta : Form
    {
        public frmRegistrarCuenta()
        {
            InitializeComponent();
        }
        public static string Usuario;
        public static string Contraseña;
        public static string ContraseñaRepetida;
        public static string Perfil;
        public static string ContraseñaIguales;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objRegistrar = new clsBaseDatos();
            Usuario = txtUsuario.Text;
            Contraseña = txtContraseña.Text;
            ContraseñaRepetida = txtContraseñaRepetida.Text;
            Perfil = txtPerfil.Text;


            if (Contraseña == ContraseñaRepetida)
            {
                ContraseñaIguales = Contraseña;

                MessageBox.Show("Cuenta creada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                

                objRegistrar.CrearCuenta();


            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin volver = new frmLogin();
            volver.ShowDialog();
        }
    }
}
