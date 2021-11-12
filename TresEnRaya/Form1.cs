using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TresEnRaya.Properties;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private static List<String> x = new List<string>();
        private static List<String> o = new List<string>();

        private static int contTurnos = 1;

        

        private void btn0_0_Click(object sender, EventArgs e)
        {
            turno("0.0");

            evaluarTurno();
        }

        private void btn1_0_Click(object sender, EventArgs e)
        {
            turno("1.0");
            evaluarTurno();


        }

        private void btn2_0_Click(object sender, EventArgs e)
        {
            turno("2.0");
            evaluarTurno();

        }

        private void btn0_1_Click(object sender, EventArgs e)
        {
            turno("0.1");
            evaluarTurno();

        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            turno("1.1");
            evaluarTurno();

        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            turno("2.1");
            evaluarTurno();

        }

        private void btn0_2_Click(object sender, EventArgs e)
        {
            turno("0.2");
            evaluarTurno();

        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            turno("1.2");
            evaluarTurno();

        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            turno("2.2");
            evaluarTurno();

        }

        public void turno(String boton)
        {
            String turno = "";
            if (contTurnos % 2 == 0)
            {
                turno = "o";
            } else
            {
                turno = "x";
            }

            contTurnos++;

            switch (boton)
            {
                case "0.0":
                    if (turno.Equals("o"))
                    {
                        btn0_0.Text = "o";
                        o.Add(boton);
                    } else
                    {
                        btn0_0.Text = "x";
                        x.Add(boton);
                    }
                    btn0_0.Enabled = false;
                break;

                case "0.1":
                    if (turno.Equals("o"))
                    {
                        btn0_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn0_1.Text = "x";
                        x.Add(boton);

                    }
                    btn0_1.Enabled = false;

                break;

                case "0.2":
                    if (turno.Equals("o"))
                    {
                        btn0_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn0_2.Text = "x";
                        x.Add(boton);

                    }
                    btn0_2.Enabled = false;

                break;

                case "1.0":
                    if (turno.Equals("o"))
                    {
                        btn1_0.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_0.Text = "x";
                        x.Add(boton);

                    }
                    btn1_0.Enabled = false;

                break;

                case "1.1":
                    if (turno.Equals("o"))
                    {
                        btn1_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_1.Text = "x";
                        x.Add(boton);

                    }
                    btn1_1.Enabled = false;

                break;

                case "1.2":
                    if (turno.Equals("o"))
                    {
                        btn1_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn1_2.Text = "x";
                        x.Add(boton);

                    }
                    btn1_2.Enabled = false;

                break;

                case "2.0":
                    if (turno.Equals("o"))
                    {
                        btn2_0.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn2_0.Text = "x";
                        x.Add(boton);

                    }
                    btn2_0.Enabled = false;

                break;

                case "2.1":
                    if (turno.Equals("o"))
                    {
                        btn2_1.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn2_1.Text = "x";
                        x.Add(boton);

                    }
                    btn2_1.Enabled = false;

                break;

                case "2.2":
                    if (turno.Equals("o"))
                    {
                        btn2_2.Text = "o";
                        o.Add(boton);

                    }
                    else
                    {
                        btn2_2.Text = "x";
                        x.Add(boton);

                    }
                    btn2_2.Enabled = false;

                break;


            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            contTurnos = 1;
            btn0_0.Enabled = true;
            btn1_1.Enabled = true;
            btn2_2.Enabled = true;
            btn0_1.Enabled = true;
            btn0_2.Enabled = true;
            btn1_0.Enabled = true;
            btn2_0.Enabled = true;
            btn2_1.Enabled = true;
            btn1_2.Enabled = true;

            btn0_0.Text = "";
            btn1_1.Text = "";
            btn2_2.Text = "";
            btn0_1.Text = "";
            btn0_2.Text = "";
            btn1_0.Text = "";
            btn2_0.Text = "";
            btn2_1.Text = "";
            btn1_2.Text = "";

            lblVictoria.Text = "";

           x.Clear();
           o.Clear();
        }

        private void evaluarTurno()
        {
            String victoriaO = "GANA O";
            String victoriaX = "GANA X";

            Console.WriteLine("O:");

            for (int i = 0; i < o.Count(); i++) {
                Console.Write(o[i] + ", ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("X:");

            for (int i = 0; i < x.Count(); i++)
            {
                Console.Write(x[i] + ", ");

            }

            if ((x.Contains("0.0") && x.Contains("1.1") && x.Contains("2.2")) || (x.Contains("2.0") && x.Contains("1.1") && x.Contains("0.2")) ||
                (x.Contains("0.0") && x.Contains("0.1") && x.Contains("0.2")) || (x.Contains("1.0") && x.Contains("1.1") && x.Contains("1.2")) || (x.Contains("2.0") && x.Contains("2.1") && x.Contains("2.2")) ||
                (x.Contains("0.0") && x.Contains("1.0") && x.Contains("2.0")) || (x.Contains("0.1") && x.Contains("1.1") && x.Contains("2.1")) || (x.Contains("0.2") && x.Contains("1.2") && x.Contains("2.2")))
                {
                    declararVictoria();
                    lblVictoria.Text = victoriaX;
                }
                else if ((o.Contains("0.0") && o.Contains("1.1") && o.Contains("2.2")) || (o.Contains("2.0") && o.Contains("1.1") && o.Contains("0.2")) ||
                  (o.Contains("0.0") && o.Contains("0.1") && o.Contains("0.2")) || (o.Contains("1.0") && o.Contains("1.1") && o.Contains("1.2")) || (o.Contains("2.0") && o.Contains("2.1") && o.Contains("2.2")) ||
                  (o.Contains("0.0") && o.Contains("1.0") && o.Contains("2.0")) || (o.Contains("0.1") && o.Contains("1.1") && o.Contains("2.1")) || (o.Contains("0.2") && o.Contains("1.2") && o.Contains("2.2")))
                {
                    declararVictoria();
                    lblVictoria.Text = victoriaO;
                } else if (contTurnos == 10)
                {
                    declararVictoria();
                    lblVictoria.Text = "EMPATE";
                }
             

            


        }

        private void declararVictoria()
        {
            btn0_0.Enabled = false;
            btn1_1.Enabled = false;
            btn2_2.Enabled = false;
            btn0_1.Enabled = false;
            btn0_2.Enabled = false;
            btn1_0.Enabled = false;
            btn2_0.Enabled = false;
            btn2_1.Enabled = false;
            btn1_2.Enabled = false;
        }
    }
}
