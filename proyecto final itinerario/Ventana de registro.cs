using System;
using System.IO;
using System.Windows.Forms;

namespace Planificacion_viajes
{
    public partial class register : Form
    {
        private Timer fadeInTimer;

        public register()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.StartPosition = FormStartPosition.CenterScreen;

            fadeInTimer = new Timer();
            fadeInTimer.Interval = 25; // Reducción del intervalo a la mitad (25 ms)
            fadeInTimer.Tick += FadeInTimer_Tick;
        }

        private void register_Load(object sender, EventArgs e)
        {
            fadeInTimer.Start();
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                fadeInTimer.Stop();
            }
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

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete los campos de usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;

            MessageBox.Show("Redirigiendo al inicio de sesión...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando al inicio de sesión...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }
    }
}
