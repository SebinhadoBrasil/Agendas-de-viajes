using System;
using System.IO;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            
            bool usuarioExistente = false;
            try
            {
                using (StreamReader sr = new StreamReader("usuarios.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos[0] == usuario)
                        {
                            usuarioExistente = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
                return; 
            }

            if (usuarioExistente)
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elige otro.");
                return; 
            }

            
            using (StreamWriter sw = new StreamWriter("usuarios.txt", true))
            {
                sw.WriteLine($"{usuario},{contraseña}");
            }

            MessageBox.Show("Registro exitoso.");
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
