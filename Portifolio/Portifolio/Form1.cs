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
            QuestaoA(40,this);
            QuestaoB(this);
            QuestaoC(this);
            QuestaoD(this);
            QuestaoE(this);
        }

      
        static void QuestaoA(int limite, Form1 form)
        {
            string result = "";
            for (int i = 1; i <= limite; i += 2)
            {
                Console.Write(i + " ");
                result = result + "," + i.ToString();
            }
            form.A.Text = "RESPOSTA : " + result;
        }
        static void QuestaoB(Form1 form)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

 
            form.B.Text = "RESPOSTA : " + soma.ToString();
        }
        static void QuestaoC(Form1 form)
        {
            string result = "";
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    result = result + "," + i.ToString();
                }
            }

            form.C.Text = "RESPOSTA : " +  result;
        }
        static void QuestaoD(Form1 form)
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
            form.D.Font = new Font(form.D.Font.FontFamily, 10);
            form.D.Text = "RESPOSTA : " + quadrados;
        }
        static void QuestaoE(Form1 form)
        {
            int soma = 0;

            for (int i = 1; i <= 50; i++)
            {
               
                if (i % 2 == 0)
                {
                  
                    soma += i;
                }
            }

            form.E.Text = "RESPOSTA : "+ soma.ToString(); ;
        }
    }
}
