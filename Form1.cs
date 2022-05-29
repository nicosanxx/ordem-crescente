using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordem_crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_valor01.Text == "" || txt_valor02.Text == "" || txt_valor03.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int valor01 = Convert.ToInt32(txt_valor01.Text);
                int valor02 = Convert.ToInt32(txt_valor02.Text);
                int valor03 = Convert.ToInt32(txt_valor03.Text);

                //VALOR 01

                if (valor01 < valor03)
                {

                    if (valor01 < valor02)
                    {

                        txt_menor.Text = valor01.ToString();



                    }
                    else if (valor01 < valor03)
                    {


                        txt_medio.Text = valor01.ToString();


                    }

                }
                
                if (valor01 > valor03)
                {

                    if (valor01 > valor02)
                    {

                        txt_maior.Text = valor01.ToString();



                    }
                    else if (valor01 > valor03)
                    {


                        txt_medio.Text = valor01.ToString();


                    }

                }

                //VALOR 02
                if (valor02 < valor01)
                {

                    if (valor02 < valor03)
                    {


                        txt_menor.Text = valor02.ToString();

                    }
                    else if (valor02 < valor01)
                    {


                        txt_medio.Text = valor02.ToString();


                    }

                }

                if (valor02 > valor01)
                {

                    if (valor02 > valor03)
                    {


                        txt_maior.Text = valor02.ToString();

                    }
                    else if (valor02 > valor01)
                    {


                        txt_medio.Text = valor02.ToString();


                    }

                }
                //VALOR 03

                if (valor03 < valor01)
                {

                    if (valor03 < valor02)
                    {


                        txt_menor.Text = valor03.ToString();

                    }
                    else if (valor03 < valor01)
                    {


                        txt_medio.Text = valor03.ToString();


                    }

                }

                if (valor03 > valor01)
                {

                    if(valor03 > valor02)
                    {


                        txt_maior.Text = valor03.ToString();

                    }
                    else if (valor03 > valor01)
                    {


                        txt_medio.Text = valor03.ToString();


                    }

                }
                

            }



        }
    }
}
