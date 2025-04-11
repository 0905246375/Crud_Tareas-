using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Tarea = txtTarea.Text;
            string Carnet = txtCarnet.Text;
            string Nota1 = txtNota1.Text;
            string Nota2 = txtNota2.Text;
            string Nota3 = txtNota3.Text;
            string Nota4 = txtNota4.Text;

            if (Tarea == "" || Carnet == "" || Nota1 == "" || Nota2 == "" || Nota3 == "" || Nota4 == "")

            {
                MessageBox.Show("Debe de agregar todo");
            }
            else
            {
                TareasGeneral nuevoIngreso = new TareasGeneral();
                int fila = nuevoIngreso.AgregarRegistro(); 

                if (fila == 1)
                {
                    MessageBox.Show("El resgistro se agrego correctamenete", "Exitos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTarea.Text = ""; 
                    txtCarnet.Text = "";
                    txtNota1.Text = "";
                    txtNota2.Text = "";
                    txtNota3.Text = "";
                    txtNota4.Text = ""; 
                }
                else
                {
                    MessageBox.Show("El resgistro no se agrego ", "Reviselo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        } 
    }
}
