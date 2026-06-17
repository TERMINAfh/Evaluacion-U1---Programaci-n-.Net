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
    public partial class FrCalculo : Form
    {
        public FrCalculo()
        {
            InitializeComponent();
        }

        private void FrCalculo_Load(object sender, EventArgs e)
        {

            cmbProducto.Items.Add("Arroz");
            cmbProducto.Items.Add("Pan de molde");
            cmbProducto.Items.Add("Leche");
            cmbProducto.Items.Add("Aceite");
            cmbProducto.Items.Add("Azúcar");
            cmbProducto.Items.Add("Fideos");
            cmbProducto.Items.Add("Huevos");
            cmbProducto.Items.Add("Pollo");
            cmbProducto.Items.Add("Mantequilla");
            cmbProducto.Items.Add("Coca-Cola");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                MessageBox.Show("Seleccione un producto.");
                cmbProducto.Focus();
                return;
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad.");
                txtCantidad.Focus();
                return;
            }

            int cantidad;

            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                txtCantidad.Clear();
                txtCantidad.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                txtCantidad.Clear();
                txtCantidad.Focus();
                return;
            }

            // Validar producto repetido
            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                if (fila.Cells[0].Value != null &&
                    fila.Cells[0].Value.ToString() == cmbProducto.Text)
                {
                    MessageBox.Show("Ese producto ya fue agregado.");
                    return;
                }
            }

            int precio = Convert.ToInt32(txtPrecio.Text);
            int subtotal = precio * cantidad;

            dgvCompra.Rows.Add(
                cmbProducto.Text,
                precio,
                cantidad,
                subtotal);

            cmbProducto.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProducto.Text)
            {
                case "Arroz":
                    txtPrecio.Text = "1650";
                    break;

                case "Pan de molde":
                    txtPrecio.Text = "1990";
                    break;

                case "Leche":
                    txtPrecio.Text = "1150";
                    break;

                case "Aceite":
                    txtPrecio.Text = "2890";
                    break;

                case "Azúcar":
                    txtPrecio.Text = "1390";
                    break;

                case "Fideos":
                    txtPrecio.Text = "890";
                    break;

                case "Huevos":
                    txtPrecio.Text = "2990";
                    break;

                case "Pollo":
                    txtPrecio.Text = "3490";
                    break;

                case "Mantequilla":
                    txtPrecio.Text = "2990";
                    break;

                case "Coca-Cola":
                    txtPrecio.Text = "2170";
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            double subtotal = 0;

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                if (fila.Cells[3].Value != null)
                {
                    subtotal += Convert.ToDouble(fila.Cells[3].Value);
                }
            }

            double iva = subtotal * 0.19;

            double descuento = 0;

            if (subtotal > 20000)
            {
                descuento = subtotal * 0.10;
            }

            double total = subtotal + iva - descuento;

            txtBoleta.Clear();

            txtBoleta.AppendText("SUPERMERCADO\n");
            txtBoleta.AppendText("---------------------------\n");
            txtBoleta.AppendText("Cliente: " + txtCliente.Text + "\n\n");
            txtBoleta.AppendText("Fecha : " + DateTime.Now.ToString("dd/MM/yyyy") + "\n");
            txtBoleta.AppendText("Hora  : " + DateTime.Now.ToString("HH:mm:ss") + "\n");
            txtBoleta.AppendText("-------------------------------------\n\n");

            foreach (DataGridViewRow fila in dgvCompra.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    txtBoleta.AppendText(
                        fila.Cells[0].Value.ToString() +
                        " x" +
                        fila.Cells[2].Value.ToString() +
                        " = $" +
                        Convert.ToDouble(fila.Cells[3].Value).ToString() +
                        "\n");
                }
            }

            txtBoleta.AppendText("\n");

            txtBoleta.AppendText("Subtotal : $" + subtotal.ToString("N0") + "\n");
            txtBoleta.AppendText("IVA 19%  : $" + iva.ToString("N0") + "\n");
            txtBoleta.AppendText("Descuento: $" + descuento.ToString("N0") + "\n");
            txtBoleta.AppendText("---------------------------\n");
            txtBoleta.AppendText("TOTAL : $" + total.ToString("N0"));
        }

        private void FrCalculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
