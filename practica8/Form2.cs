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
    public partial class Form2 : Form
    {

        public string mensaje;
        public Form2(string mensaje)
        {
            InitializeComponent();
            labelMensaje2.Text = mensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelMensaje1.Text = mensaje;
        }

        private void bottonMensaje3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMensaje1_Click(object sender, EventArgs e)
        {

        }
    }
}
