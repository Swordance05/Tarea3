using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAgilidad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            suma = 1;
            valor = 0;

            InitializeComponent();
            arreglo = new int[2];
        }

        Random r = new Random();
        Form1 f1 = new Form1();
        String binario = "";
        String octal = "";
        public String resultado;
        int numero = 0;
        int numero2 = 0;
        int minutos = 0;
        int segundos = 0;
        int tipo = 0;
        int valor = 0;
        int conteo = 1;
        int pregunta = 0;
        int suma = 1;
        int[] arreglo;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos == 59)
            {

                minutos = minutos + 1;
                segundos = 0;

            }
            segundos = segundos + 1;


            label1.Text = minutos.ToString() + " : " + segundos.ToString();

            if (minutos == 1)
            {

                suma++;
                conteo++;
                binario = "";
                octal = "";
                //textBox1.Text = "";
                Iniciar();
                minutos = 0;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            suma = 1;
            timer1.Enabled = true;

            textBox1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            Iniciar();

            button1.Visible = false;
            button1.Enabled = false;
            button4.Visible = true;
            minutos = 0;
            pregunta = 0;
        }

        public void Iniciar()
        {

            tipo = r.Next(1, 10);
            textBox1.Text = "";
            minutos = 0;

            if (tipo % 2 == 0)
            {
                textBox1.Visible = true;
                label5.Text = "";
                label5.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;
                label4.Text = "Conversion de binario a hexadecimal";
                label3.Text = "Valor a convertir";
                label3.Text = "";
                label3.Visible = true;
                //conteo++;

                label8.Text = "Numero de pregunta: " + conteo;

                valor = r.Next(1, 1000);

                numero = valor;

                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }

                label3.Text = binario;

                numero2 = valor;

                //Hexa
                octal = Convert.ToString(numero2, 16);

                label7.Text = octal;

            }

            else
            {

                textBox1.Visible = true;
                label5.Text = "";
                label5.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;
                label4.Text = "Conversion de hexadecimal a binario";
                label3.Text = "Valor a convertir";
                label3.Text = "";
                label3.Visible = true;
                //conteo++;

                label8.Text = "Numero de pregunta: " + conteo;

                valor = r.Next(1, 1000);

                numero = valor;

                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }



                numero2 = valor;

                //hexa

                octal = Convert.ToString(numero2, 16);

                label3.Text = octal;
                label7.Text = binario;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String texto1 = textBox1.Text;
            label9.Text = texto1;
            label7.Text = octal;

            if (conteo >= 10)
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult imprimir;

                imprimir = MessageBox.Show(VerNotas(), "Completo las 10 preguntas", buttons);

                if (imprimir == System.Windows.Forms.DialogResult.Yes)
                {

                    this.Show();

                }
                else
                {

                    Application.Exit();

                }

            }
            else
            {

                if (tipo % 2 == 0)
                {


                    if (texto1.CompareTo(octal) == 0)
                    {

                        label5.Text = "Correcto";

                        pregunta++;
                    }// Si la conversion a octal es correcta

                    else
                    {

                        label5.Text = "Incorrecto";

                    }//Si la conversion a octal es incorrecta
                }

                else
                {


                    if (texto1.CompareTo(binario) == 0)
                    {

                        label5.Text = "Correcto";

                        pregunta++;
                    }// Si la conversion a octal es correcta

                    else
                    {

                        label5.Text = "Incorrecto";

                    }//Si la conversion a octal es incorrecta
                }


            }

            label6.Text = "Respuestas correctas " + pregunta + " /10";
            label10.Text = arreglo[0].ToString() + arreglo[1].ToString();

            suma++;
            arreglo[1] = pregunta;
            String resultado = "";

            resultado = "Respuestas correctas de binario hexadecimal - hexadecimal binario \n" + arreglo[1];

            //f1.getNotas(resultado);
            conteo++;
            binario = "";
            octal = "";
            //textBox1.Text = "";
            Iniciar();
             

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult imprimir;

            imprimir = MessageBox.Show(resultado, "Ver notas", buttons);


            if (imprimir == System.Windows.Forms.DialogResult.Yes)
            {

                this.Show();

            }
            else
            {

                Application.Exit();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String VerNotas()
        {


            resultado = "";

            if (arreglo[0] < 8)
            {


                resultado = "Respuestas correctas de octal binario - binario octal \n" + arreglo[0] + "\n Respuestas correctas de binario hexadecimanl - hexadecimal binario \n" + arreglo[1] + "\nReprobado";
            }
            else
            {

                resultado = "Respuestas correctas de octal binario - binario octal \n" + arreglo[0] + "\n Respuestas correctas de binario hexadecimanl - hexadecimal binario \n" + arreglo[1] + "\nAprobado";
            }


            return resultado;

        }



    }
}
