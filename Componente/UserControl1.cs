using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string setNombre { set { lblNombre.Visible = true; lblNombre.Text = value; } }
        public string setEsc { set { lblEscolaridad.Visible = true; lblEscolaridad.Text = value; } }
        public string setResena { set { lblResena.Visible = true; lblResena.Text = value; } }
        public string setPonencia { set { lblPonencia.Visible = true; lblPonencia.Text = value; } }
        public string setInv { set { lblInvestigacion.Visible = true; lblInvestigacion.Text = value; } }

        public void Img()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\1.jpg");
        }

        public void Img2()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\2.jpg");
        }

        public void Img3()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\3.jpg");
        }

        public void Img4()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\4.jpg");
        }

        public void Img5()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\5.jpg");
        }

        public void Img6()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alan\Desktop\ComponentePonente\IMG\6.jpg");
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
