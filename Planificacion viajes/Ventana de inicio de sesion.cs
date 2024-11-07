using System;
using System.IO;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void linkLabelRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registroForm = new register();
            registroForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e) // Método para iniciar sesión
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            bool credencialesValidas = false;

            // Leer los datos del archivo de texto
            try
            {
                using (StreamReader sr = new StreamReader("usuarios.txt"))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 2 && datos[0] == usuario && datos[1] == contraseña)
                        {
                            credencialesValidas = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }

            if (credencialesValidas)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                menu_principal menu_principal = new menu_principal(); // Crear la instancia de vtPrincipal
                menu_principal.Show(); // Mostrar la ventana vtPrincipal
                this.Hide(); // Ocultar la ventana de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
