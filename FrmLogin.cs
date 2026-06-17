using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Ingrese un usuario");
                txtUsuario.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña");
                txtPassword.Focus();
                return;
            }

            if (txtUsuario.Text=="invitado" && txtPassword.Text=="123inv")
            {
                FrmMovimiento frm = new FrmMovimiento();
                frm.Show();
                this.Hide();
            }
            else if(txtUsuario.Text=="administrador" && txtPassword.Text=="123adm")
            {
            FrCalculo frm = new FrCalculo();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
}
}
