using static System.Console;
using System.Collections;
using System;

using System.Data;
namespace WinFormsApp2
{
    public partial class Janela : Form
    {
        public string equaçao=string.Empty;
        
        public bool sinal=true;
        public int tamanho_geral=30;
        public bool aspas=false;
        public Janela()
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
            cochetes.Click += label1_Click_1;
            ac.Click += label1_Click_1;
            delete.Click += label1_Click_1;
            resultado.Click += label1_Click_1;
            Texto1.Text=equaçao;
            
            Texto1.Font=new Font(Texto1.Font.FontFamily,30);
        }
        private void aumentar_font(int tam=30)
        {
            Texto1.Font=new Font(Texto1.Font.FontFamily,tam);
        }
        private void Verificar_sinal()
        {
            if (sinal==true & equaçao!=string.Empty)
            {
                delete_de_veri();
            }
        }
        private void delete_de_veri()
        {
            //remove o ultimo elemento adicionado
            int n2=equaçao.Length-1;
            if (equaçao[n2]=='+' | equaçao[n2]=='-' |equaçao[n2]=='*' |equaçao[n2]=='%'|equaçao[n2]=='÷' |equaçao[n2]=='x' )
                {
                    string n3=equaçao.Remove(n2);
                    equaçao = n3;
                }
        }
        private void Sinais(string sinais)
        {   
            if (equaçao!=string.Empty)
            {
                equaçao+=sinais;
                sinal=true;
                if(equaçao.Length>=8)
                {
                    tamanho_geral--;
                    aumentar_font(tamanho_geral);
                }
                
            }
            
        }
        private void Numeros(string numero)
        {
            
            if (equaçao==string.Empty)
            {
                equaçao+=numero;
                sinal=false;
            }
            else if ((equaçao.Length-1)<=0 | equaçao[equaçao.Length-1]!=')')
            {
                equaçao+=numero;
                sinal=false;
            }
            
            if(equaçao.Length>=8&equaçao.Length<=20)
                {
                    tamanho_geral--;
                    aumentar_font(tamanho_geral);
                }

        }
        private void Menos_Click(object sender, EventArgs e )
        {
            Sinais("-");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Texto1.Text = equaçao;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numero0_Click(object sender, EventArgs e)
        {
            Numeros("0");
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            Numeros("1");
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            Numeros("2");
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            Numeros("3");
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            Numeros("4");
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            Numeros("5");
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            Numeros("6");
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            Numeros("7");
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            Numeros("8");
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            Numeros("9");
        }

        private void multi_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            Sinais("x");

        }

        private void menos_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            Sinais("-");
        }

        private void mais_Click(object sender, EventArgs e)
        {
            Verificar_sinal();
            Sinais("+");
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            //aqui faz um verificaçao pra saber se o ultimo item clicado era um sinal
            if (sinal==true)
            {
                
            }
            else if(equaçao!=string.Empty)
            {
                string copia = string.Empty;
                foreach(char c in equaçao)//aqui faz uma breve troca entre os caracteres
                {
                    if(c=='x')
                    {
                        copia+="*";
                    }
                    else if(c=='÷')
                    {
                        copia+='/';
                    }
                    else if(c==',')
                    {
                        copia+='.';
                    }
                    else
                    {
                        copia+=c;
                    }
                }
                
                //aqui converte tudo em um resultado
                try
                {
                    DataTable datatable = new DataTable();
                    var n2=datatable.Compute(copia, string.Empty);
                    equaçao = n2.ToString();
                    if (equaçao=="NaN")//aqui apaga tudo se for feito uma divisao de zero por zero
                        {
                            equaçao = string.Empty;
                            sinal=true;
                        }
                }
                catch (System.Exception)
                {
                    equaçao = string.Empty;
                    sinal=true;
                }
                
                
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            
            Verificar_sinal();
            Sinais("÷");
        }

        private void porcento_Click(object sender, EventArgs e)
        {
            Verificar_sinal();
            Sinais("%");
        }

        private void aspas_Click(object sender, EventArgs e)
        {
            if (aspas==false&equaçao!=string.Empty)
            {
                int veri=equaçao.Length-1;
                if(equaçao[veri]=='+' |equaçao[veri]=='-' |equaçao[veri]=='x' |equaçao[veri]=='÷' |equaçao[veri]=='%'  )
                    {
                        equaçao+="(";
                        aspas=true;
                    }
            }
            else
            {
                aspas=false;
                foreach( var c in equaçao)
                {
                    if (c=='(')
                    {
                        equaçao+=")";
                        aspas=false;
                    }
                }
                
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            //apaga tudo que esta na variavel
            equaçao = string.Empty;
            sinal=true;
        }

        private void delete_Click(object? sender, EventArgs e)
        {
            //remove o ultimo elemento adicionado
            try
            {
                if (equaçao==string.Empty)
                    {

                    }
                else
                    {
                        int n2=equaçao.Length-1;
                        if(equaçao[n2-1]==')')
                            {
                                aspas=false;
                            }
                        string n3=equaçao.Remove(n2);
                        equaçao = n3;
                    }
            }
            catch (System.Exception)
            {
                
                equaçao=string.Empty;
            }
            
            
            
            
        }
        private void virgula_Click(object sender, EventArgs e)
        {
            //adiciona a virgula
            Sinais(",");
        }
    }
}
