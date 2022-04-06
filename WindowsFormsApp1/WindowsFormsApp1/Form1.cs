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
            DgvTablaIteraciones.AllowUserToAddRows = false;
        }

        private long calcularPotencia(int potencia)
        {
            long res = 1;
            for (int i = 0; i < potencia; i++)
            {
                res *= 2;
            }
            return res;
        }
        private void generarMetodoCongruencialMixto(int n)
        {
            //limpiamos la tabla de numeros random
            DgvTablaIteraciones.Rows.Clear();
            //se crea la lista de objetos iteracion para guadar los datos de los numneros pseudoaleatorios creados
            var listaIteracion = new List<Iteracion>();

            if (TxtSemilla.Text.Equals("") || TxtK.Text.Equals("") || TxtG.Text.Equals("") || TxtC.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                // obtenemos los paratros del metodo congruencial mixto ingresados por teclado
                var semilla = Convert.ToInt64(TxtSemilla.Text);
                var k = Convert.ToInt64(TxtK.Text);
                var g = Convert.ToInt64(TxtG.Text);
                var c = Convert.ToInt32(TxtC.Text);

                // asigamos los datos de los parametros al objeto generador
                generador.semilla = semilla;
                generador.valorA = 4 * k + 1;
                generador.valorM = calcularPotencia((int)g);
                generador.valorC = c;

                var cantMuestras = n;

                // validamos los datos ingresados que  sean correctos
                if (generador.validarDatosIngresados(generador))
                {
                    var cantMuestrasCalc = cantMuestras + 1;
                    //iteramos segun la cantidad de valores ingresados por teclado o seteado a 20
                    for (var iteracion = 1; cantMuestrasCalc > iteracion; iteracion++)
                    {
                        // se crea el numero pseudoaleatorio llamando al metodo del objeto generador 
                        // que se encarga de realizar el calculo de dicho nuemro RND
                        decimal NroRandom = (decimal)generador.GeneradorRandomCongruencial(generador);

                        // creamos un objeto iteracion para guardar los datos creados
                        var itera = new Iteracion()
                        {
                            numneroIteracion = iteracion,
                            valorRaizX = generador.semilla,
                            //truncamos el valor del RND obtenido
                            numeroRandom = Math.Truncate(NroRandom * 10000) / 10000
                        };
                        //agregamos a la lista cada iteracion para luego ser mostrada
                        listaIteracion.Add(itera);
                    }


                    //recorremos la lista de iteraciones para ser mostrados por tabla grafica
                    foreach (var item in listaIteracion)
                    {
                        var fila = new string[]
                        {
                        item.numneroIteracion.ToString(),
                        item.valorRaizX.ToString(),
                        item.numeroRandom.ToString(),
                        };
                        DgvTablaIteraciones.Rows.Add(fila);
                        //agregamos los numeros generados a una lista que luego se la pasaremos al 
                        //formulario 2 para realizar la parte de la tabla de frecuencia y prueba de bondad
                        numeros.Add(item.numeroRandom);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //este metodo nos permite generar otro numero pseudoaleatorio con el metodo cong mixto a la vez
        private void generarOtroCongruencialMIxto()
        {
            // volvemos a llamar a la funcion del objeto generar que realiza el calculo
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

        //este metodo nos permite generar otro numero pseudoaleatorio con el metodo cong multiplicativo a la vez
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


        //metodo que permite crear numeros aleatorios con el lenguaje c#
        private void generarOtroLenguaje()
        {
            //creamos un objeto random que a partir de el podremos generar numeros RND
            Random random = new Random();

            // metodo del objeto random que crea el RND
            double _NúmeroDecimalAleatorio = random.NextDouble();
            //truncamos el RND
            _NúmeroDecimalAleatorio = Math.Truncate(_NúmeroDecimalAleatorio * 10000) / 10000;    
            var segundo = "-";
            //mostramos el nuemro en la tabla
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


        //SIMILIRA AL METODO generarMetodoCongruncial mixto salvo que llamamos al metodo 
        // GeneradorRandomMultiplicativo del objeto generador
        private void GenerarMetodoCongruencialMultiplicativo(int n)
        {

            TxtC.Enabled = true;
            DgvTablaIteraciones.Rows.Clear();

            var listaIteracion = new List<Iteracion>();

            if (TxtSemilla.Text.Equals("") || TxtK.Text.Equals("") || TxtG.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // obtenemos los paratros del metodo congruencial mixto ingresados por teclado
                var semilla = Convert.ToInt64(TxtSemilla.Text);
                var k = Convert.ToInt64(TxtK.Text);
                var g = Convert.ToInt64(TxtG.Text);

                // asigamos los datos de los parametros al objeto generador
                generador.semilla = semilla;
                generador.valorA = 4 * k + 1;
                generador.valorM = calcularPotencia((int)g);
                generador.valorC = 0;

                var cantMuestras = n;

                // validamos los datos ingresados por parametro
                if (generador.validarDatosIngresados(generador))
                {

                    var cantMuestrasCalc = cantMuestras + 1;
                    //recorremos segun la cant ingresada o seteada a 20
                    for (var iteracion = 1; cantMuestrasCalc > iteracion; iteracion++)
                    {     
                        //llamamos al metodo correspondiente para generar el valor RND
                        decimal NroRandom = (decimal)generador.GeneradorRandomMultiplicativo(generador);
                        //generamos el string para mostrar en la tabla                   
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
        }


        //metodo para generar numeros RND a partir del lenguaje c#
        private void generarMetodoLenguaje(int n)
        {
            DgvTablaIteraciones.Rows.Clear();
            var cantMuestras = n;
            //creamos un objeto random que a partir de el podremos generar numeros RND
            Random random = new Random();
            var numerosAleatorios = new List<decimal>();
            var segundo = " ";
            for (int i = 0; i < cantMuestras; i++)
            {
                // metodo del objeto random que crea el RND
                double _NúmeroDecimalAleatorio = random.NextDouble();
                _NúmeroDecimalAleatorio = Math.Truncate(_NúmeroDecimalAleatorio * 10000) / 10000;
                // agregamos los numeros RND a una lista 
                numerosAleatorios.Add((decimal)_NúmeroDecimalAleatorio);
            }
            //recorremos la lista de los RND para ser mostrados por tabla
            foreach (var numero in numerosAleatorios)
            {

                var fila = new string[]
                {
                    (DgvTablaIteraciones.Rows.Count + 1).ToString(),
                    segundo,
                    numero.ToString()
                };
                DgvTablaIteraciones.Rows.Add(fila);
                numeros = numerosAleatorios;
            }
        }

        private void BotonSimular_Click(object sender, EventArgs e)
        {
            //cantidad de muestras seteados a 20 en caso que no se ingrese por parametro
            var n = 20;
            if (txtN.Text.Equals("") && CbGeneracionPorTeclado.Checked)
            {
                MessageBox.Show("Debe ingresar la cantidad de números a generar (n)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (CbGeneracionPorTeclado.Checked)
                {
                    // si se selecciona ingresar n por teclado ,tomamos el valor ingresado
                    n = Convert.ToInt32(txtN.Text);
                }
                //segun se seleccione un metodod se invoca a la funcion correspondiente
                if (RbCongruencialMIxto.Checked)
                {
                    generarMetodoCongruencialMixto(n);
                }
                else if (RbCongruencialMulti.Checked)
                {
                    //activamos el boton para ingresar el valor C
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

        //METODOS PARA AHCER VISIBLE O NO A LOS TEXTBOX
        private void habilitarTextBoxMulti()
        {
            TxtK.Enabled = true;
            TxtG.Enabled = true;
            TxtSemilla.Enabled = true;
            TxtC.Enabled = false;
        }
        private void habilitarTextBoxMixto()
        {
            TxtC.Enabled = true;
            TxtK.Enabled = true;
            TxtG.Enabled = true;
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
            TxtK.Enabled = false;
            TxtG.Enabled = false;
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

        // METODO QUE ABRE EL FORMULARIO 2 DE INFORMES .
        private void button2_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            for (int i = 0; i < DgvTablaIteraciones.Rows.Count; i++)
            {
                var colI = Convert.ToDecimal(DgvTablaIteraciones.Rows[i].Cells[2].Value);
                numeros.Add(colI);
            }
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DgvTablaIteraciones.Rows.Clear();
        }
    }
}
