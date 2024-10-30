﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class vtPrincipal : Form
    {
        private const string rutaArchivo = "viajes.txt";

        public vtPrincipal()
        {
            InitializeComponent();
            CargarViajes();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            string viaje = txtAgregarViaje.Text.Trim();

            if (!string.IsNullOrEmpty(viaje))
            {
                // Verificar si el viaje ya existe en el ListBox
                if (!lstPendientes.Items.Contains(viaje))
                {
                    lstPendientes.Items.Add(viaje);
                    GuardarViaje(viaje);
                    txtAgregarViaje.Clear();
                    button2.Visible=true;
                }
                else
                {
                    MessageBox.Show("Este viaje ya ha sido agregado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un viaje.");
            }
        }

        private void CargarViajes()
        {
            if (File.Exists(rutaArchivo))
            {
                string[] viajes = File.ReadAllLines(rutaArchivo);
                lstPendientes.Items.AddRange(viajes);
            }
        }

        private void GuardarViaje(string viaje)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(viaje);
            }
        }

        private void txtAgregarViaje_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            programaritinerario programaritinerario = new programaritinerario();
            programaritinerario.Show();
            this.Hide();

        }
    }
}
