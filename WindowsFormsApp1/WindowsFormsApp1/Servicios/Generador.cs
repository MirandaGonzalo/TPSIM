using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servicios
{
    public class Generador
    {
        public int semilla { get; set; }
        public int valorA { get; set; }
        public int valorC { get; set; }
        public int valorM { get; set; }

        //public int ultimaSemilla { get; set; }

        public  decimal GeneradorRandomCongruencial(Generador generador)
        {
            decimal semillaNueva = (generador.valorA * generador.semilla + generador.valorC) % generador.valorM;

            decimal random = (decimal)(semillaNueva / (decimal)generador.valorM);

            generador.semilla = (int)semillaNueva;

            return random;

        }

        public  decimal GeneradorRandomMultiplicativo(Generador generador)
        {

            decimal semillaNueva = (generador.valorA * generador.semilla) % generador.valorM;

            var random = (decimal)(semillaNueva / (decimal)generador.valorM);

            generador.semilla = (int)semillaNueva;

            return random;
            
        }

        public bool validarDatosIngresados(Generador generador)
        {
            if (generador.semilla > 0 && generador.valorA > 0 && generador.valorM > 0 && generador.valorC >= 0)
            {

                return true;
            }
            return false;
            
        }

    }


}
