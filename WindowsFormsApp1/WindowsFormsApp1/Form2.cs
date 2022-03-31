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
        public static double Acumulado;
        public static double AcumuladorMedia;

        public Form2()
        {
            InitializeComponent();
            dataInforme.AllowUserToAddRows = false;
        }

        private int getCantIntervalos(string selected)
        {
            if (selected.Equals("5 intervalos"))
            {
                return 5;
            }
            else if (selected.Equals("8 intervalos"))
            {
                return 8;
            }
            else if (selected.Equals("10 intervalos"))
            {
                return 10;
            }
            else if (selected.Equals("12 intervalos"))
            {
                return 12;
            } 
            else
            {
                return -1;    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcumuladorMedia = 0;
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

                List<int> frecObservada = new List<int>();
                List<decimal> limitesSup = new List<decimal>();


                //en esta iteracion obtenemos una arreglo de los valores(limitesSup) de los limites superiores
                // de cada intervalo
                for (int i = 0; i < cantIntervalos; i++)
                {
                    frecObservada.Add(0);
                    decimal aux = (i) + 1;
                    //creamos aux2 para modificar el limite superior del intervalo
                    var aux2 = (decimal)0.01;
                    var limiteSuperior = (decimal)((aux / cantIntervalos) - aux2);
                    limitesSup.Add(limiteSuperior);
                }

                //iteramos segun la cantidad de numeros que generamos en el formulario 1 y acumulamos 
                // la frecuencia de cada intervalo en un arreglo llamada frecObservada.
                for (int i = 0; i < leng; i++)
                {
                    for (int j = 0; j < cantIntervalos; j++)
                    {
                        if (numeros[i] <= limitesSup[j])
                        {
                            AcumuladorMedia += (double)numeros[i];
                            frecObservada[j]++;
                            break;
                        }
                    }
                }

                //creamos el arreglo de registros
                var items = new List<Registro>();
                var primero = true;
                decimal acumuladorDesde = 0;

                var frecEsperada = (decimal)(leng / cantIntervalos);

                //CALCULAMOS LA MEDIA DE LA SERIE GENERADA
                var media = AcumuladorMedia / (leng);
                //mediaTxt.Text = "La media es : " + Math.Truncate(media * 1000 / 10000).ToString();
                
                for (int a = 0; a < cantIntervalos; a++)
                {
                    //creamos la variable registro y le asignamos sus atributos
                    var registro = new Registro();
                    //el primer registro el valor desde del primer intervalo debe ser 0.
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
                    // aca guardamos los valores de cada registro que seran los datos que mostraremos 
                    // en la tabla de frecuencias
                    registro.Hasta = (decimal)(limitesSup[a]);
                    registro.MarcaClase = acumuladorDesde + ((registro.Hasta - registro.Desde) / 2);
                    registro.FrecuenciaObservada = frecObservada[a];
                    registro.FrecuenciaEsperada = frecEsperada;
                    //Agregamos los registros a una lista de objetos registros
                    items.Add(registro);
                }

                decimal acumulado = 0;

                for (int i = 0; i < items.Count(); i++)
                {
                    //PRUEBA DE BONDAD DE AJUSTE CON CHI
                    // calculamos el estadistico llamando a la funcion calcularEstadistico 
                    // Luego lo acumulamos en acumulado para obtener el valor de chi cuadrado
                    var estaditicoM = CalcularEstadistico(items[i].FrecuenciaObservada, items[i].FrecuenciaEsperada);
                    acumulado += estaditicoM;
                    Acumulado = (double)(Math.Truncate(acumulado * 10000) / 10000);
                    //Armamos el string que mostraremos en la tabla grafica(dataGrid)
                    var fila = new string[]
                    {
                        //items[i].Desde.ToString(),
                        items[i].Desde.ToString(),
                        items[i].Hasta.ToString(),
                        items[i].MarcaClase.ToString(),
                        items[i].FrecuenciaObservada.ToString(),
                        items[i].FrecuenciaEsperada.ToString(),
                        estaditicoM.ToString(),
                        Acumulado.ToString()
                    };
                    dataInforme.Rows.Add(fila);
                    //var filaChi = new string[]
                    //{
                    //    items[i].Desde.ToString(),
                    //    items[i].Hasta.ToString(),
                    //    items[i].FrecuenciaObservada.ToString(),
                    //    items[i].FrecuenciaEsperada.ToString(),
                    //    estaditicoM.ToString(),
                    //    acumulado.ToString()
                    //};
                    //dataChi.Rows.Add(filaChi);
                }

                //GENERACION DE GRAFICO CON HERRAMIENTA CHART

                //limpiamos el grafico para nuevos informes
                graficoHistograma.Series.Clear();
                graficoHistograma.Titles.Clear();
                graficoHistograma.Titles.Add("HISTOGRAMA FREC OBSERVADA");
                graficoHistograma.Palette = ChartColorPalette.Berry;
                foreach (var item in items)
                {
                    var serie = item.Desde.ToString();
                    // creamos el objeto serie para trabajar con el grafico
                    Series ser = graficoHistograma.Series.Add(serie);
                    // creamos el string con los datos de cada intervalo
                    var label = "[" + item.Desde.ToString() + " - " + item.Hasta.ToString() + "]";
                    // con la propiedad label muestro el valor de la frec observada a intervalos del histograma
                    ser.Label = item.FrecuenciaObservada.ToString();
                    //asignamos el label
                    ser.Name = label;
                    //con este metodo se visualiza en la tabla el histograma con cada valor de frec observada en su respectivo intervalo
                    ser.Points.Add((double)item.FrecuenciaObservada);
                }

                //limpiamos el grafico para nuevos informes
                graficoFrecEsperada.Series.Clear();
                graficoFrecEsperada.Titles.Clear();

                //hacemos el mismo grafico pero para frec esperadas 
                graficoFrecEsperada.Titles.Add("HISTOGRAMA FREC ESPERADA");
                graficoFrecEsperada.Palette = ChartColorPalette.Berry;
                foreach (var item in items)
                {
                    var serie = item.Desde.ToString();
                    Series ser = graficoFrecEsperada.Series.Add(serie);
                    var label = "[" + item.Desde.ToString() + " - " + item.Hasta.ToString() + "]";
                    ser.Label = item.FrecuenciaEsperada.ToString();
                    ser.Name = label;
                    ser.Points.Add((double)item.FrecuenciaEsperada);
                }

                hipotesisNulaTxt.Text = "Hipótesis nula: “la serie de datos corresponde a una distribución uniforme entre 0 y 1”.";

                var seAcepta = "NO SE RECHAZA LA HIPOTESIS";

                var noSeAcepta = "SE RECHAZA LA HIPOTESIS";

                // Comparamos el valor obtenido de la prueba de bondad de chi cuadrado 
                // para saber si la serie generada pertenece a la distribucion uniforme

                if (cantInt == 5)
                {
                    if (Acumulado > 9.49)
                    {
                        HipotesisTxt.Text = noSeAcepta;
                    }
                    else { HipotesisTxt.Text = seAcepta; };
                }
                else if (cantInt == 10)
                {
                    if (Acumulado > 16.9)
                    {
                        HipotesisTxt.Text = noSeAcepta;
                    }
                    else { HipotesisTxt.Text = seAcepta; };
                }
                else if (cantInt == 20)
                {
                    if (Acumulado > 30.1)
                    {
                        HipotesisTxt.Text = noSeAcepta;
                    }
                    else { HipotesisTxt.Text = seAcepta; };
                }
                else
                {
                    if (Acumulado > 36.4)
                    {
                        HipotesisTxt.Text = noSeAcepta;
                    }
                    else { HipotesisTxt.Text = seAcepta; };
                }

            }
        }


        // METODO QUE CALCULA EL VALOR DEL ESTADISTICO DE PRUEBA
        private decimal CalcularEstadistico(decimal frecuenciaO, decimal frecuenciaE)
        {
            decimal result = (frecuenciaO - frecuenciaE) * (frecuenciaO - frecuenciaE) / (frecuenciaE);
            var Resultado = Math.Truncate(result * 10000) / 10000;
            return Resultado;
        }
    }
}
