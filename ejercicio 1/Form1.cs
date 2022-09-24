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
    public partial class Form1 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bottonRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text) || string.IsNullOrEmpty(textNombre.Text) || string.IsNullOrEmpty(textApellido.Text))
            {
                MessageBox.Show("Debio Complegtar los cmapos");
            }

            else
            {
                int ID = int.Parse(textId.Text);
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                listEstudents.Add(new Estudiantes()
                {
                    Id = ID,
                    Nombre = nombre,
                    Apelido = apellido
                });
                MessageBox.Show("Su registro fue agregado con exito");
                textId.Clear();
                textNombre.Clear();
                textApellido.Clear();
            }
        }

        private void bottonDatos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                //enviar los datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
        }
    }
}
