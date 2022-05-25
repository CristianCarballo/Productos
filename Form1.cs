using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class frmProductos : Form
    {
        //En form declaro una constante, un contador y un arreglo
        const int tam = 5;
        int c = 0;
        ClaseProducto[] aProducto = new ClaseProducto[tam]; 

        public frmProductos()
        {
            InitializeComponent();
            c = 0;

            for (int i = 0; i < tam; i++)
                aProducto[i] = null;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Creo el objeto
            aProducto[c] = new ClaseProducto();

            // Cargo los valores al objeto (al arreglo)
            aProducto[c].pNombre = txtNombre.Text;
            aProducto[c].pPrecio = Convert.ToDouble(txtPrecio.Text);
            aProducto[c].pCantidad = Convert.ToDouble(txtCantidad.Text);

            // Paso los arreglos a las listas para mostrar
            lstNombre.Items.Add(aProducto[c].pNombre);
            lstPrecio.Items.Add(aProducto[c].pPrecio);
            lstCantidad.Items.Add(aProducto[c].pPrecio);
            
            c++; // Cuento para a la siguiente posicion

            if(c==tam)
            {
                MessageBox.Show("Se completó el arreglo", "Arreglo Completo");
                btnCargar.Enabled = false;
            }

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtGanancia.Text == "")
            MessageBox.Show("Ingrese valor");
            
            else
            { 
            lstImporte.Items.Clear();
            double total = 0;

            // EN ESTE FOR LE PONGO QUE i SEA MENOR QUE c ( NO MENOR QUE tam ) 
            // Porque asi voy a poder calcular el importe sin necesidad de completar el arreglo antes, osea usar el boton sin importar que el arreglo no este completo
            for(int i = 0; i < c; i++)
            {
                lstImporte.Items.Add(aProducto[i].calcularImporte(Convert.ToDouble(txtGanancia.Text)));
                total += aProducto[i].calcularImporte(Convert.ToDouble(txtGanancia.Text));
            }

            txtTotal.Text = total.ToString();
            }
        }
    }
}
