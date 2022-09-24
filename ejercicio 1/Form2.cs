using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form2 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Datos.DataSource = listEstudents;
        }

        private void bottonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bottonAgregar_Click(object sender, EventArgs e)
        {
            textId.Text = Datos.CurrentRow.Cells[0].Value.ToString();
            textNombre.Text = Datos.CurrentRow.Cells[1].Value.ToString();
            textApellido.Text = Datos.CurrentRow.Cells[2].Value.ToString();
        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
