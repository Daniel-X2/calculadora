using static System.Console;
using System.Collections;
using System;
using System.Security.Permissions;
using System.Data;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public string n1;
        public Form1()
        {
            InitializeComponent();
            numero0.Click+= label1_Click_1;
            numero1.Click+= label1_Click_1;
            numero2.Click+= label1_Click_1;
            numero3.Click+= label1_Click_1;
            numero4.Click+= label1_Click_1;
            numero5.Click+= label1_Click_1;
            numero6.Click+= label1_Click_1;
            numero7.Click+= label1_Click_1;
            numero8.Click+= label1_Click_1;
            numero9.Click+= label1_Click_1;
            mais.Click+=label1_Click_1;
            dividir.Click += label1_Click_1;
            menos.Click += label1_Click_1;
            multiplica.Click += label1_Click_1;
            porcento.Click += label1_Click_1;
            virgula.Click += label1_Click_1;
            aspas.Click += label1_Click_1;
            ac.Click += label1_Click_1;
            delete.Click += label1_Click_1;
            resultado.Click += label1_Click_1;
        }

        private void Menos_Click(object? sender, EventArgs e )
        {
            n1 += "-";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text = n1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numero0_Click(object sender, EventArgs e)
        {
            n1 += "0";
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            n1 += "1";
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            n1 += "2";
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            n1 += "3";
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            n1 += "4";
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            n1 += "5";
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            n1 += "6";
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            n1 += "7";
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            n1 += "8";
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            n1 += "9";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            n1 += "x";
            

        }

        private void menos_Click(object sender, EventArgs e)
        {
            n1 += "-";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            n1 += "+";
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            string copia = null;
            int veri = n1.Length;
            for(int c=0;c<=veri;c++)
            {

                if (n1[c] == 'x')
                {
                    copia += "*";
                }
                else
                {   
                    
                    copia += c;
                }
                if (c == veri & n1[c] == '+') ;
                {
                    n1.Remove(c);
                }
            }
            
            n1 = copia;
            DataTable datatable = new DataTable();
            var n2=datatable.Compute(n1, string.Empty);
            n1 = n2.ToString();

        }

        private void dividir_Click(object sender, EventArgs e)
        {
            n1+="/";
        }

        private void porcento_Click(object sender, EventArgs e)
        {
            n1 += "%";
        }

        private void aspas_Click(object sender, EventArgs e)
        {
            
        }

        private void ac_Click(object sender, EventArgs e)
        {
            n1 = null;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //remove o ultimo elemento adicionado
           int n2=n1.Length-1;
            string n3=n1.Remove(n2);
            n1 = n3;
            
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            //adiciona a virgula

            n1 += ",";
        }
    }
}
