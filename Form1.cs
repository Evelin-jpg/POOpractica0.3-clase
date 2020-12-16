using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOpractica0._3__clase_
{
    public partial class Form1 : Form
    {
        //Evento y Metodo
        Cuaderno Rayas = new Cuaderno(); //Se crea el objeto
        Libro Literatura = new Libro(); //Se crea el objeto 
        Revista Programacion = new Revista(); //Se crea el objeto

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Escribir_Click(object sender, EventArgs e)
        {
            Rayas.Escribir();
        }

        //Evento y Metodo


        private void btn2_Subrayar_Click(object sender, EventArgs e)
        {
            Literatura.Subrayar();
        }

        private void btnLeerRecortar_Click(object sender, EventArgs e)
        {
            Programacion.Leer_Y_Recortar();
        }
    }
}
