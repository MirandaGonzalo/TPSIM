using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servicios
{
    public class Generador
    {
        public Int64 semilla { get; set; }
        public Int64 valorA { get; set; }
        public int valorC { get; set; }
        public Int64 valorM { get; set; }

        

        //METODO QUE GENERA UN NUMERO PSEUDOALEATORIO POR EL METODO CONGRUNCIAL MIXTO/LINEAL 
        public  decimal GeneradorRandomCongruencial(Generador generador)
        {
            decimal semillaNueva = (generador.valorA * generador.semilla + generador.valorC) % generador.valorM;

            decimal random = (decimal)(semillaNueva / (decimal)generador.valorM);

            //seteamos el valor de la semilla con el valor de la nueva semilla obtenida en el calculo del numero pseudoaleatorio anterior
            generador.semilla = (Int64)semillaNueva;
            
            //retornamos el valor RND generado
            return random;

        }

        public  decimal GeneradorRandomMultiplicativo(Generador generador)
        {

            decimal semillaNueva = (generador.valorA * generador.semilla) % generador.valorM;

            var random = (decimal)(semillaNueva / (decimal)generador.valorM);

            //seteamos el valor de la semilla con el valor de la nueva semilla obtenida en el calculo del numero pseudoaleatorio anterior
            generador.semilla = (Int64)semillaNueva;

            //retornamos el valor RND generado
            return random;
            
        }

        public bool validarDatosIngresados(Generador generador)
        {
            //validamos que los datos ingresados por parametro sean ingresados correctamente
            //en caso de ser correctos devuelve un true
            if (generador.semilla > 0 && generador.valorA > 0 && generador.valorM > 0 && generador.valorC >= 0)
            {
                return true;
            }
            return false;
            
        }

    }


}
