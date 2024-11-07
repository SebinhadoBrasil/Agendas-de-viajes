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

namespace Planificacion_viajes
{
    public partial class programaritinerario : Form

    {
        private const string rutaArchivo2 = "Lugares pendientes.txt";
        public programaritinerario()
        {
            InitializeComponent();
            CargarLugaresP();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string LugaresP = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(LugaresP))
            {
                if (!listBox1.Items.Contains(LugaresP))
                {
                    listBox1.Items.Add(LugaresP);
                    GuardarLugaresPe(LugaresP);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Este lugar pendiente ya ha sido agregado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un lugar pendiente.");
            }




        }
        private void CargarLugaresP()
        {
            if (File.Exists(rutaArchivo2))
            {
                string[] LugaresP = File.ReadAllLines(rutaArchivo2);
                listBox1.Items.AddRange(LugaresP);
            }
        }
        private void GuardarLugaresPe(string LugaresP)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo2, true))
            {
                writer.WriteLine(LugaresP);
            }
        }
    }
    
}
