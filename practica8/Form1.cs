using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bottonMensaje1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textmensaje1.Text))
            {
                MessageBox.Show("Debe completar el campo solicitado");
            }
           
            string mensaje = textmensaje1.Text;
            Form2 f2 = new Form2("");
            f2.mensaje = mensaje;
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bottonMensaje2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textmensaje2.Text))
            {
                MessageBox.Show("DEbe completar el campo solicitado");
            }
           
            string mensaje = textmensaje2.Text;
            Form2 f2 = new Form2("");
            f2.mensaje = mensaje;
            f2.Show();
        }
    }
}
