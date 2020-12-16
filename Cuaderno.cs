using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._3__clase_
{
    public class Cuaderno
    {
        //Variables

       public string pasta;
       public string hojas;
        

        //Propiedades
        public string Pasta
        {
            get 
            {

                return pasta; 

            }
            set 
            {

                pasta = value; 
            }
        }

        public string Hojas
        {
            get
            {

                return hojas;

            }
            set
            {

                hojas = value;
            }
        }

        //Constructores 
        public Cuaderno()
        {
            pasta = "";
            hojas = "";  
        }
        public Cuaderno (string pasta,string hojas)
        {
            this.pasta = pasta;
            this.hojas = hojas;
        }
       

        //Metodo
        public void Escribir()
        {
            System.Windows.Forms.MessageBox.Show("Redactar un texto en el cuaderno");
        }

        public void Escribir_texto()
        {


        }














    }
   












}
