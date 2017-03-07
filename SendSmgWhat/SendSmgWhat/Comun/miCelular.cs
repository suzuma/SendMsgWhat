using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSmgWhat.Comun
{
    public class miCelular
    {
        public String Numero { get; set; }
        public String Propietario { get; set;}

        public miCelular() {
            this.Numero = "5216621030035";
            this.Propietario = String.Empty;
        }
    }

    public class miKey {
        public String Key { get; set; }

        public miKey() {
            this.Key = "";
        }
    }

}
