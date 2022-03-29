using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Repositorio
{
    public class ReporteRepositorio
    {
        public DataTable ObtenerDatosTabla()
        {
            var sentenciaSql = "SELECT * FROM TABLAFRECUENCIA";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }
    }
}
