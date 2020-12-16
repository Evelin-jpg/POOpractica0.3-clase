using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._3__clase_
{
    class Libro : Cuaderno
    {
        //Variable
       public string paginasEnumeradas;

        //Propiedad
        public string PaginasEnumeradas
        {
            get
            {
                return paginasEnumeradas; 
            }
            set
            {
                paginasEnumeradas = value; 
            }
        }

        //Constructor
        public Libro() : base()
        {
            paginasEnumeradas = "";
        }

        public Libro(string pasta,string hojas,string paginasEnumeradas) : base(pasta,hojas)
        {
            this.paginasEnumeradas = paginasEnumeradas;
        }

        //Metodo
        public void Subrayar()
        {
            System.Windows.Forms.MessageBox.Show("Subrayar el primer parrafo");
        }

        public void Subrayar_Parrafo()
        {

        }















    }
}
