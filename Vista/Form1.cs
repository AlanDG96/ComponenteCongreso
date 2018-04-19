using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Componente;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Componente.UserControl1 u1 = new UserControl1();
        Componente.UserControl1 u2 = new UserControl1();



        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.setNombre = "Alan Demetrio";
            userControl11.setResena = "Reseña";
            userControl11.setEsc = "Universidad";
            userControl11.setPonencia = "Animal";
            userControl11.setInv = "Los animales en peligro de extinción";
            userControl11.Img();

            userControl12.setNombre = "Alberto del Rio";
            userControl12.setResena = "Reseña";
            userControl12.setEsc = "Preparatoria";
            userControl12.setPonencia = "WWE";
            userControl12.setInv = "Las luchas...";
            userControl12.Img2();

            userControl13.setNombre = "James Hunt";
            userControl13.setResena = "Reseña";
            userControl13.setEsc = "Universidad";
            userControl13.setPonencia = "F1";
            userControl13.setInv = "Algo acerca de la fórmula 1";
            userControl13.Img3();

            userControl14.setNombre = "Thanos";
            userControl14.setResena = "Reseña";
            userControl14.setEsc = "Desconocido";
            userControl14.setPonencia = "Gemas del Infinito";
            userControl14.setInv = "El fin de los vengadores";
            userControl14.Img4();

            userControl15.setNombre = "Steve Jobs";
            userControl15.setResena = "Reseña";
            userControl15.setEsc = "Universidad";
            userControl15.setPonencia = "Iphone";
            userControl15.setInv = "El nuevo Iphone y sus nuevas características";
            userControl15.Img5();

            userControl16.setNombre = "Perro Pinguino";
            userControl16.setResena = "Reseña";
            userControl16.setEsc = "Primaria";
            userControl16.setPonencia = "Mutación";
            userControl16.setInv = "Mutación";
            userControl16.Img6();

            


        }

        private void userControl11_Load(object sender, EventArgs e)
        {
           
        }
        
    }
}
