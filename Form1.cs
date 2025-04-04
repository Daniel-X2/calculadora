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
        public bool sinal;
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
        private void Verificar_sinal()
        {
            if (sinal==true)
            {
                delete_de_veri();
            }
        }
        private void delete_de_veri()
        {
            //remove o ultimo elemento adicionado
            int n2=n1.Length-1;
            string n3=n1.Remove(n2);
            n1 = n3;
            
        }

        private void Menos_Click(object sender, EventArgs e )
        {
            n1 += "-";
            sinal=true;
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
            sinal=false;
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            n1 += "1";
            sinal=false;
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            n1 += "2";
            sinal=false;
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            n1 += "3";
            sinal=false;
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            n1 += "4";
            sinal=false;
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            n1 += "5";
            sinal=false;
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            n1 += "6";
            sinal=false;
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            n1 += "7";
            sinal=false;
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            n1 += "8";
            sinal=false;
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            n1 += "9";
            sinal=false;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            n1 += "x";
            sinal=true;

        }

        private void menos_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            n1 += "-";
            sinal=true;
        }

        private void mais_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            n1 += "+";
            sinal=true;
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            char veri;
            if (sinal==true)
            {
                
            }
            else
            {
                string copia = null;
                foreach(char c in n1)
                {
                    if(c=='x')
                    {
                        copia+="*";
                    }
                    else if(c=='/')
                    {
                        copia+='/';
                    }
                    else
                    {
                        copia+=c;
                    }
                }
                
                //int veri = n1.Length;
                DataTable datatable = new DataTable();
                var n2=datatable.Compute(copia, string.Empty);
                n1 = n2.ToString();
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            n1+="/";
            sinal=true;
        }

        private void porcento_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            n1 += "%";
            sinal=true;
        }

        private void aspas_Click(object sender, EventArgs e)
        {
            
        }

        private void ac_Click(object sender, EventArgs e)
        {
            n1 = null;
            sinal=true;
        }

        private void delete_Click(object? sender, EventArgs e)
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
