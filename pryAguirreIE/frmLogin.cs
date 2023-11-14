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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtContraseña.PasswordChar= '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
        int cont = 3;
        public static string usuario;
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario=txtUsuario.Text;
           
            
            clsUsuario objUsuario = new clsUsuario();

            objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Ingrese al sistema...","Kanyo Seguros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objUsuario.RegistroLogInicioSesion();
                this.Hide();
                frmInicio pasar = new frmInicio();
                pasar.ShowDialog();
            }
            else
            {
                cont = cont - 1;
                MessageBox.Show("Contraseña y/o Usuario incorrectos", "Error login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                objUsuario.RegistroLogInicioFallidoSesion();
                
                if (cont <= 0)
                {
                    MessageBox.Show("Se excedio el limite de intentos","Sistema Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIngresar.Enabled = false;
                    objUsuario.RegistroLogInicioBloqueado();
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarCuenta pasar = new frmRegistrarCuenta();
            pasar.ShowDialog();
        }
    }
}
