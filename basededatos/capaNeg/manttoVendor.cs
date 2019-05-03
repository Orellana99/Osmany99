using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
namespace capaNeg
{
    public class manttoVendor
    {
        bdConex test = new bdConex();
        public String prueba() {

            if(test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion Realizada";
            }
            else 
            {
                test.Desconectar();
                mensaje = "Conexion no Realizada";
            }
            return mensaje;


            test.Conectar();
        
        }

    }
}
