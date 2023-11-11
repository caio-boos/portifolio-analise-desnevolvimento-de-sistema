using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Portifolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExibirImpares(40,this);
            CalcularSomaDosPrimeiros100B(this);
            ObterNumerosDivisiveisPor4(this);
            ObterQuadradosDe15a200(this);
            SomarValoresParesDe1a50(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se você precisar de ações ao clicar no botão, você pode adicionar o código aqui
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Se você precisar de ações ao clicar na label, você pode adicionar o código aqui
        }

        static void ExibirImpares(int limite, Form1 form)
        {
            string result = "";
            for (int i = 1; i <= limite; i += 2)
            {
                Console.Write(i + " ");
                result = result + "," + i.ToString();
            }
            form.ResultadoQuestaoA.Text = result;
        }
        static void CalcularSomaDosPrimeiros100B(Form1 form)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

 
            form.ResultadoQuestaoB.Text = soma.ToString();
        }
        static void ObterNumerosDivisiveisPor4(Form1 form)
        {
            string result = "";
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    result = result + "," + i.ToString();
                }
            }

            form.ResultadoQuestaoC.Text = result;
        }
        static void ObterQuadradosDe15a200(Form1 form)
        {

            string quadrados = "";

            for (int i = 15; i <= 200; i++)
            {
                quadrados += (i * i).ToString();

                if (i < 200)
                {
                    quadrados += ",";
                }

                if (i % 30 == 0 && i < 200)
                {
                    quadrados += "\n";
                }
            }
            form.ResultadoQuestaoD.Font = new Font(form.ResultadoQuestaoD.Font.FontFamily, 10);
            form.ResultadoQuestaoD.Text = quadrados;
        }
        static void SomarValoresParesDe1a50(Form1 form)
        {
            int soma = 0;

            for (int i = 1; i <= 50; i++)
            {
               
                if (i % 2 == 0)
                {
                  
                    soma += i;
                }
            }

            form.ResultadoQuestaoE.Text = soma.ToString(); ;
        }
    }
}
