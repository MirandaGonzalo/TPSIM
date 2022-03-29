using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int getCantIntervalos(string selected)
        {
            if (selected.Equals("5 intervalos"))
            {
                return 5;
            }
            else if (selected.Equals("10 intervalos"))
            {
                return 10;
            }
            else if (selected.Equals("20 intervalos"))
            {
                return 20;
            }
            else if (selected.Equals("25 intervalos"))
            {
                return 25;
            } 
            else
            {
                return -1;    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = this.CbIntervalos.GetItemText(this.CbIntervalos.SelectedItem);
            var cantInt = getCantIntervalos(selected);
            if (cantInt < 0)
            {
                MessageBox.Show("Seleccione una cantidad valida de intervalos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            } else
            {
                dataChi.Rows.Clear();
                dataInforme.Rows.Clear();
                Random random = new Random();
                var cantIntervalos = cantInt;
                var numeros = Form1.numeros;
                var leng = Form1.numeros.Count;
                for (int i = 0; i < leng; i++)
                {
                    double _NúmeroDecimalAleatorio = random.NextDouble();
                    numeros.Add((decimal)_NúmeroDecimalAleatorio);
                }
                List<int> frecObservada = new List<int>();
                List<decimal> limitesSup = new List<decimal>();
                for (int i = 0; i < cantIntervalos; i++)
                {
                    frecObservada.Add(0);
                    decimal aux = (i) + 1;
                    var aux2 = (decimal)0.01;
                    var limiteSuperior = (decimal)((aux / cantIntervalos) - aux2);
                    limitesSup.Add(limiteSuperior);
                }
                for (int i = 0; i < leng; i++)
                {
                    for (int j = 0; j < cantIntervalos; j++)
                    {
                        if (numeros[i] < limitesSup[j])
                        {
                            frecObservada[j]++;
                            break;
                        }
                    }
                }

                var items = new List<Registro>();
                var primero = true;
                decimal acumuladorDesde = 0;
                var frecEsperada = (leng / cantIntervalos);
                for (int a = 0; a < cantIntervalos; a++)
                {
                    var registro = new Registro();
                    if (primero)
                    {
                        registro.Desde = 0;
                        primero = false;
                    }
                    else
                    {
                        registro.Desde = acumuladorDesde + (limitesSup[a] - limitesSup[a - 1]);
                        acumuladorDesde += (limitesSup[a] - limitesSup[a - 1]);
                    }
                    registro.Hasta = (decimal)(limitesSup[a]);
                    registro.MarcaClase = acumuladorDesde + ((registro.Hasta - registro.Desde) / 2);
                    registro.FrecuenciaObservada = frecObservada[a];
                    registro.FrecuenciaEsperada = frecEsperada;
                    items.Add(registro);
                }

                decimal acumulado = 0;
                for (int i = 0; i < items.Count(); i++)
                {
                    var fila = new string[]
                    {
                        items[i].Desde.ToString(),
                        items[i].Hasta.ToString(),
                        items[i].MarcaClase.ToString(),
                        items[i].FrecuenciaObservada.ToString(),
                        items[i].FrecuenciaEsperada.ToString()
                    };
                    dataInforme.Rows.Add(fila);

                    var estaditicoM = CalcularEstadistico(items[i].FrecuenciaObservada, items[i].FrecuenciaEsperada);
                    acumulado += estaditicoM;
                    var filaChi = new string[]
                    {
                        items[i].Desde.ToString(),
                        items[i].Hasta.ToString(),
                        items[i].FrecuenciaObservada.ToString(),
                        items[i].FrecuenciaEsperada.ToString(),
                        estaditicoM.ToString(),
                        acumulado.ToString()
                    };
                    dataChi.Rows.Add(filaChi);
                }

                graficoHistograma.Series.Clear();
                graficoHistograma.Titles.Clear();
                graficoHistograma.Titles.Add("HISTOGRAMA");
                graficoHistograma.Palette = ChartColorPalette.Berry;
                foreach (var item in items)
                {
                    var serie = item.Desde.ToString();
                    Series ser = graficoHistograma.Series.Add(serie);
                    var label = "[" + item.Desde.ToString() + " - " + item.Hasta.ToString() + "]";
                    ser.Label = item.FrecuenciaObservada.ToString();
                    ser.Name = label;
                    ser.Points.Add((double)item.FrecuenciaObservada);
                }
            }   
        }

        private decimal CalcularEstadistico(decimal frecuenciaO, decimal frecuenciaE)
        {
            decimal result = (frecuenciaO - frecuenciaE) * (frecuenciaO - frecuenciaE) / (frecuenciaE);
            return result;
        }

        private void graficoHistograma_Click(object sender, EventArgs e)
        {

        }
    }
}
