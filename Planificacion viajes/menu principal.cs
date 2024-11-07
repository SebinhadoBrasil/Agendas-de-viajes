using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Planificacion_viajes
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void botoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonmaximizar.Visible = false;
            botonrestaurar.Visible = true;
        }

        private void botonrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            botonrestaurar.Visible= false;
            botonmaximizar.Visible= true;
        }

        private void botonminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrirformshija(new vtPrincipal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrirformshija(new programaritinerario());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_principal_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }
        private void Abrirformshija(object formhija)
        {
            if (this.panelcontenedor2.Controls.Count > 0)
                this.panelcontenedor2.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor2.Controls.Add(fh);
            this.panelcontenedor2.Tag=fh;
            fh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abrirformshija(new ventana_alojamiento());
        }

        private void panelcontenedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abrirformshija(new ventanarestaurante());
        }
    }


}
