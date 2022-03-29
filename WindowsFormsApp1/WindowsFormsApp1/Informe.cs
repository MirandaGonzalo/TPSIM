using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repositorio;

namespace WindowsFormsApp1
{
    public partial class Informe : Form
    {
        private ReporteRepositorio reportesRepositorio;
        public Informe()
        {
            reportesRepositorio = new ReporteRepositorio();
            InitializeComponent();
            
        }

        public void cargarReporte()
        {
            
             var datos = reportesRepositorio.ObtenerDatosTabla();
             this.ReportTablaFrecuencia.LocalReport.DataSources.Clear();

             var ds = new ReportDataSource("DataSet", datos);

             this.ReportTablaFrecuencia.LocalReport.DataSources.Add(ds);

             this.ReportTablaFrecuencia.RefreshReport();
            
        }
        private void Informe_Load(object sender, EventArgs e)
        {
            cargarReporte();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
