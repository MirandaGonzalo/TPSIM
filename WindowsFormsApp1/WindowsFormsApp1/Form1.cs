using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public static Generador generador;
        public static List<decimal> numeros;
        public Form1()
        {
            InitializeComponent();
            generador = new Generador();
            numeros = new List<decimal>(); 
        }


        private void generarMetodoCongruencialMixto(int n)
        {
            DgvTablaIteraciones.Rows.Clear();

            var listaIteracion = new List<Iteracion>();

            var semilla = Convert.ToInt32(TxtSemilla.Text);
            var a = Convert.ToInt32(TxtA.Text);
            var m = Convert.ToInt32(TxtM.Text);
            var c = Convert.ToInt32(TxtC.Text);

            generador.semilla = semilla;
            generador.valorA = a;
            generador.valorM = m;
            generador.valorC = c;

            var cantMuestras = n;

            if (generador.validarDatosIngresados(generador))
            {
                var cantMuestrasCalc = cantMuestras + 1;
                for (var iteracion = 1; cantMuestrasCalc > iteracion; iteracion++)
                {
                    decimal NroRandom = (decimal)generador.GeneradorRandomCongruencial(generador);

                    var itera = new Iteracion()
                    {
                        numneroIteracion = iteracion,
                        valorRaizX = generador.semilla,
                        numeroRandom = Math.Truncate(NroRandom * 10000) / 10000
                    };

                    listaIteracion.Add(itera);
                }

                foreach (var item in listaIteracion)
                {
                    var fila = new string[]
                    {
                        item.numneroIteracion.ToString(),
                        item.valorRaizX.ToString(),
                        item.numeroRandom.ToString(),
                    };
                    DgvTablaIteraciones.Rows.Add(fila);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void generarOtroCongruencialMIxto()
        {
            decimal NroRandom = (decimal)generador.GeneradorRandomCongruencial(generador);
            var numeroRandom = Math.Truncate(NroRandom * 10000) / 10000;
            var fila = new string[]
            {
                    (DgvTablaIteraciones.Rows.Count).ToString(),
                    generador.semilla.ToString(),
                    numeroRandom.ToString(),
            };
            DgvTablaIteraciones.Rows.Add(fila);
        }

        private void generarOtroCongruencialMultiplicativo()
        {
            decimal NroRandom = (decimal)generador.GeneradorRandomMultiplicativo(generador);
            var numeroRandom = Math.Truncate(NroRandom * 10000) / 10000;

            var fila = new string[]
            {
                    (DgvTablaIteraciones.Rows.Count).ToString(),
                    generador.semilla.ToString(),
                    numeroRandom.ToString(),
            };
            DgvTablaIteraciones.Rows.Add(fila);
        }

        private void generarOtroLenguaje()
        {
            Random random = new Random();

            double _NúmeroDecimalAleatorio = random.NextDouble();
            _NúmeroDecimalAleatorio = Math.Truncate(_NúmeroDecimalAleatorio * 10000) / 10000;    
            var segundo = " ";
            var fila = new string[]
            {
                    (DgvTablaIteraciones.Rows.Count).ToString(),
                    segundo,
                    _NúmeroDecimalAleatorio.ToString()
            };
            DgvTablaIteraciones.Rows.Add(fila);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RbCongruencialMIxto.Checked)
            {
                generarOtroCongruencialMIxto();
            }
            else if (RbCongruencialMulti.Checked)
            {
                generarOtroCongruencialMultiplicativo();
            }
            else
            {
                generarOtroLenguaje();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GenerarMetodoCongruencialMultiplicativo(int n)
        {

            TxtC.Enabled = true;
            DgvTablaIteraciones.Rows.Clear();

            var listaIteracion = new List<Iteracion>();
            var semilla = Convert.ToInt32(TxtSemilla.Text);
            var a = Convert.ToInt32(TxtA.Text);
            var m = Convert.ToInt32(TxtM.Text);

            generador.semilla = semilla;
            generador.valorA = a;
            generador.valorM = m;

            var cantMuestras = n;

            if (generador.validarDatosIngresados(generador))
            {

                var cantMuestrasCalc = cantMuestras + 1;
                for (var iteracion = 1; cantMuestrasCalc > iteracion; iteracion++)
                {                    
                    decimal NroRandom = (decimal)generador.GeneradorRandomMultiplicativo(generador);
                    var fila = new string[]
                    {
                        iteracion.ToString(),
                        generador.semilla.ToString(),
                        (Math.Truncate(NroRandom * 10000) / 10000).ToString(),
                    };
                    DgvTablaIteraciones.Rows.Add(fila);
                    numeros.Add((Math.Truncate(NroRandom * 10000) / 10000));
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void generarMetodoLenguaje(int n)
        {
            DgvTablaIteraciones.Rows.Clear();
            var cantMuestras = n;
            Random random = new Random();
            var numerosAleatorios = new List<double>();
            var segundo = " ";
            for (int i = 0; i < cantMuestras; i++)
            {
                double _NúmeroDecimalAleatorio = random.NextDouble();
                _NúmeroDecimalAleatorio = Math.Truncate(_NúmeroDecimalAleatorio * 10000) / 10000;
                numerosAleatorios.Add(_NúmeroDecimalAleatorio);
            }

            foreach (var numero in numerosAleatorios)
            {

                var fila = new string[]
                {
                    (DgvTablaIteraciones.Rows.Count).ToString(),
                    segundo,
                    numero.ToString()
                };
                DgvTablaIteraciones.Rows.Add(fila);
            }

        }


        private void BotonSimular_Click(object sender, EventArgs e)
        {
            var n = 20;
            if (txtN.Text.Equals("") && CbGeneracionPorTeclado.Checked)
            {
                MessageBox.Show("Debe ingresar la cantidad de números a generar (n)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (CbGeneracionPorTeclado.Checked)
                {
                    n = Convert.ToInt32(txtN.Text);
                }
                if (RbCongruencialMIxto.Checked)
                {
                    generarMetodoCongruencialMixto(n);
                }
                else if (RbCongruencialMulti.Checked)
                {
                    TxtC.Enabled = true;
                    GenerarMetodoCongruencialMultiplicativo(n);
                }
                else
                {
                    generarMetodoLenguaje(n);
                }
            }
        }
        private void RbCongruencialMulti_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTextBoxMulti();
        }

        private void habilitarTextBoxMulti()
        {
            TxtA.Enabled = true;
            TxtM.Enabled = true;
            TxtSemilla.Enabled = true;
            TxtC.Enabled = false;
        }
        private void habilitarTextBoxMixto()
        {
            TxtC.Enabled = true;
            TxtA.Enabled = true;
            TxtM.Enabled = true;
            TxtSemilla.Enabled = true;
        }
        private void RbCongruencialMIxto_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTextBoxMixto();
        }

        private void deshabilitarLenguaje()
        {
            TxtSemilla.Enabled = false;
            TxtC.Enabled = false;
            TxtA.Enabled = false;
            TxtM.Enabled = false;
        }
        private void RbLenguajeC_CheckedChanged(object sender, EventArgs e)
        {
            deshabilitarLenguaje();
        }

        private void CbGeneracionPorTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (CbGeneracionPorTeclado.Checked)
            {
                txtN.Enabled = true;
            }
            else
            {
                txtN.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            for (int i = 0; i < DgvTablaIteraciones.Rows.Count-1; i++)
            {
                var colI = Convert.ToDecimal(DgvTablaIteraciones.Rows[i].Cells[2].Value);
                numeros.Add(colI);
            }
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
