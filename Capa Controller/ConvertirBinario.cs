using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas_controladora_y_vista.Capa_Controller
{
   public  class ConvertirBinario
    {
      public  ConvertirBinario()
        {

        }

        public string conversionbinario(int valor)
        {
            string val = Convert.ToString( valor);
            int from = 10;
            int to = 2;

            string binary = Convert.ToString(Convert.ToInt32(val, from), to);
            
            return binary;

        }
    }
}
