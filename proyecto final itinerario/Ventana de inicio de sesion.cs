using System;
using System.IO;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class login : Form
    {
        private Timer fadeInTimer;

        public login()
        {
            InitializeComponent();
            this.Opacity = 0; // Comienza con opacidad 0 (invisible)
            this.StartPosition = FormStartPosition.CenterScreen; // Centra la ventana en la pantalla

            // Configura el Timer para el fade-in
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 25; // Intervalo de tiempo para incrementar la opacidad (25 ms)
            fadeInTimer.Tick += FadeInTimer_Tick; // Evento que ocurre cuando el Timer se activa

            fadeInTimer.Start(); // Inicia el efecto fade-in directamente desde el constructor
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05; // Incrementa la opacidad
            }
            else
            {
                fadeInTimer.Stop(); // Detiene el Timer cuando la opacidad es 1 (completamente visible)
            }
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
                menu_principal menu_principal = new menu_principal(); // Crear la instancia de menu_principal
                menu_principal.Show(); // Mostrar la ventana menu_principal
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
