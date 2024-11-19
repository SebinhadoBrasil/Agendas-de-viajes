using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.IO;
using System.Linq;

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
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            string destino = txtAgregarViaje.Text.Trim();
            string fechaIda = dtfechaida.Value.ToString("dd/MM/yyyy");
            string fechaVuelta = dtfechavuelta.Value.ToString("dd/MM/yyyy");
            string nombreViaje = txtnombreviaje.Text.Trim();

            if (string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(nombreViaje))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (dtfechaida.Value >= dtfechavuelta.Value)
            {
                MessageBox.Show("La fecha de ida debe ser anterior a la fecha de vuelta.");
                return;
            }

            string item = $"{destino} - {fechaIda} - {fechaVuelta} - {nombreViaje}";

            if (!lstPendientes.Items.Contains(item))
            {
                lstPendientes.Items.Add(item);
                GuardarViaje(item);
                LimpiarCampos();
                MessageBox.Show("El viaje se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Este viaje ya ha sido agregado.");
            }
        }

        private void CargarViajes()
        {
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    foreach (string linea in lineas)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            lstPendientes.Items.Add(linea);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los viajes: {ex.Message}");
                }
            }
        }

        private void GuardarViaje(string item)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    writer.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el viaje: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtAgregarViaje.Clear();
            txtnombreviaje.Clear();
            dtfechaida.Value = DateTime.Now;
            dtfechavuelta.Value = DateTime.Now;
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (lstPendientes.SelectedItem != null)
            {
                string itemSeleccionado = lstPendientes.SelectedItem.ToString();

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este viaje?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    lstPendientes.Items.Remove(itemSeleccionado);

                    if (File.Exists(rutaArchivo))
                    {
                        try
                        {
                            var lineas = File.ReadAllLines(rutaArchivo).ToList();
                            lineas.Remove(itemSeleccionado);
                            File.WriteAllLines(rutaArchivo, lineas);
                            MessageBox.Show("El viaje ha sido eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el viaje: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un viaje para eliminar.");
            }
        }

        private void eliminarPlan_Click(object sender, EventArgs e)
        {
            if (lstPendientes.SelectedItem != null)
            {
                string itemSeleccionado = lstPendientes.SelectedItem.ToString();

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este viaje?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    lstPendientes.Items.Remove(itemSeleccionado);

                    if (File.Exists(rutaArchivo))
                    {
                        try
                        {
                            var lineas = File.ReadAllLines(rutaArchivo).ToList();
                            lineas.Remove(itemSeleccionado);
                            File.WriteAllLines(rutaArchivo, lineas);
                            MessageBox.Show("El viaje ha sido eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el viaje: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un viaje para eliminar.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtAgregarViaje_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtfechaida_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtfechavuelta_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
