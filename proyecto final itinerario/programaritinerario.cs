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

        public void button3_Click(object sender, EventArgs e)
        {
            string LugaresP = textBox1.Text.Trim();
            string FechaSalida = dtFechaSalida.Value.ToString("dd/MM/yyyy");
            string FechaLlegada = dtFechaRegreso.Value.ToString("dd/MM/yyyy");

            string item = $"{LugaresP} - {FechaSalida} - {FechaLlegada}";
            listLugaresPendientes.Items.Add(item);
            textBox1.Clear();


            if (!string.IsNullOrEmpty(LugaresP))
            {
                if (!listLugaresPendientes.Items.Contains(LugaresP))
                {
                    listLugaresPendientes.Items.Add(LugaresP);
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
                listLugaresPendientes.Items.AddRange(LugaresP);
            }
        }
        private void GuardarLugaresPe(string LugaresP)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo2, true))
            {
                writer.WriteLine(LugaresP);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void dtFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dtFechaLlegada_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
