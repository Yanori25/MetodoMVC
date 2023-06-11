using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas_controladora_y_vista.Capa_Controller
{
    public class OrdenArray {

        public OrdenArray() { }

        public string OrdenaArray(bool orden, int a, int b, int c, int d)
        {

            int[] arreglo = new int[] { a, b, c, d };
            if(orden == true)
            {
                  Array.Sort(arreglo);

            }
            else
            {
                Array.Sort(arreglo);
                Array.Reverse(arreglo);
            }
            return string.Join(", ", arreglo);



            //return arreglo ;
        }


    }
}
