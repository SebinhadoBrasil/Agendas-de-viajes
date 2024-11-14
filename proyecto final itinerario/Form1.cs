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
    public partial class Form1 : Form
    {
        double precio = 0; //varible para que el precioo sea leído como decimal y empiece en 0
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        //Constructor
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SelecMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
