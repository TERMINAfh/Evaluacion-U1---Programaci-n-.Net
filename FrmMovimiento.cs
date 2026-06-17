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
    public partial class FrmMovimiento : Form
    {
        public FrmMovimiento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
                int paso;

    if (!int.TryParse(txtPaso.Text, out paso))
    {
        MessageBox.Show("Ingrese un número válido.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPaso.Focus();
        return;
    }

    if (paso <= 0)
    {
        MessageBox.Show("El paso debe ser mayor que cero.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPaso.Focus();
        return;
    }

    if (CalacaChida.Left + paso <= this.ClientSize.Width - CalacaChida.Width)
    {
        CalacaChida.Left += paso;
    }
        
    }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            int paso = Convert.ToInt32(txtPaso.Text);

            if (!int.TryParse(txtPaso.Text, out paso))
            {
                MessageBox.Show("Ingrese un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaso.Focus();
                return;
            }

            if (paso <= 0)
            {
                MessageBox.Show("El paso debe ser mayor que cero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaso.Focus();
                return;
            }

            if (CalacaChida.Top + paso <= this.ClientSize.Height - CalacaChida.Height)
            {
                CalacaChida.Top += paso;
            }
        }
        

        private void btnReinicar_Click(object sender, EventArgs e)
        {
            CalacaChida.Left = 0;
            CalacaChida.Top = 0;
        }
        private void FrmMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {

        }
    }

}
