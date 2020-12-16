using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._3__clase_
{
    class Revista : Libro 
    {
        //Variable
       public string impreso;

        //Propiedad
        public string Impreso
        {
            get
            {
                return impreso; 
            }
            set
            {
                impreso = value; 
            }
        }

        //Constructor
        public Revista() : base()
        {
            impreso = "";
        }

        public Revista(string pasta,string hojas,string paginasEnumeradas,string impreso) : base(pasta,hojas,paginasEnumeradas)
        {
            this.impreso = impreso;
        }

        //Metodo
        public void Leer_Y_Recortar()
        {
            System.Windows.Forms.MessageBox.Show("Leer informacion sobre el sistema operativo y recortar imagenes de ello ");
        }

        public void Analizar_Y_Obtener_Imagenes()
        {

        }


    }
}
