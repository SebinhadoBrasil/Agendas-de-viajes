using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class ventanarestaurante : Form
    {
        double precio = 0; //varible para que el precioo sea leído como decimal y empiece en 0

        class panaderia
        { }

        public ventanarestaurante()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mepicaelcoco
        }

        private void ventanarestaurante_Load(object sender, EventArgs e)
        {

        }

        private void MetPagar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelecMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = SelecMenu.Text; //definimos nombre del combobos

            //asociación de productos y valores
            if (producto.Equals("PACHAMANCA")) precio = 30; //si el producto es igual a pachamanca entonces el precio es de S/45
            if (producto.Equals("AJI DE GALLINA")) precio = 22;
            if (producto.Equals("JARRA DE CHICHA MORADA")) precio = 15;
            if (producto.Equals("COMBINADO")) precio = 20;
            if (producto.Equals("CEVICHE")) precio = 14;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturando datos de lo que fue seleccionado
            String productos = AllBox.Text;
            int Cantidad = Convert.ToInt32(txtCantidad.Text);

            //procesar calculos
            double subtotal = Cantidad * precio;
            double preciofinal = subtotal;

            //impresión de resultado
            ListViewItem fila = new ListViewItem(productos);
            fila.SubItems.Add(Cantidad.ToString());
            fila.SubItems.Add(precio.ToString());
            fila.SubItems.Add(preciofinal.ToString());

            lvRestaurante.Items.Add(fila);
            
        }
    }
}
