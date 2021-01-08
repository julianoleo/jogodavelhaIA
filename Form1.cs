using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelhaIA
{
    public partial class Form1 : Form
    {
        bool vez, button_disable;
        int x_vitoria, o_vitoria, empate = 0, rodadas = 0, vencedor = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (vez == false && button_disable == false && button1.Text == "")
            {
                button1.Text = "X";
                rodadas++;
                vez = true;
                checagemVencedor();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            rodadas++;
            vez = true;
            checagemVencedor();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = Enabled;
            button2.Enabled = Enabled;
            button3.Enabled = Enabled;
            button4.Enabled = Enabled;
            button5.Enabled = Enabled;
            button6.Enabled = Enabled;
            button7.Enabled = Enabled;
            button8.Enabled = Enabled;
            button9.Enabled = Enabled;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
            //
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            rodadas = 0;
            button_disable = false;
            if (vencedor == 1 || vencedor == 0)
            {
                vez = false;
                vencedor = 0;
            }
            else
            {
                vez = true;
                vencedor = 0;
                checagemVencedor();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ofensivo()
        {
            if (vez == true)
            {
                for (int i = 1; i <= 17; i++)
                {
                    if (i == 17 && vez == true)
                    {
                        Defensivo();
                    }

                    if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && vez == true || button6.Text == "O" && button6.Text == "O" && button3.Text == "" && vez == true)
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && vez == true || button5.Text == "O" && button8.Text == "O" && button2.Text == "" && vez == true)
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && vez == true || button4.Text == "O" && button7.Text == "O" && button1.Text == "" && vez == true)
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && vez == true || button3.Text == "O" && button9.Text == "O" && button6.Text == "" && vez == true)
                    {
                        button6.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && vez == true || button1.Text == "O" && button7.Text == "O" && button4.Text == "" && vez == true)
                    {
                        button4.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && vez == true || button2.Text == "O" && button8.Text == "O" && button5.Text == "" && vez == true)
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && vez == true || button3.Text == "O" && button6.Text == "O" && button9.Text == "" && vez == true)
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && vez == true || button1.Text == "O" && button4.Text == "O" && button7.Text == "" && vez == true)
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && vez == true || button2.Text == "O" && button5.Text == "O" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button2.Text == "O" && button4.Text == "O" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "O" && button8.Text == "O" && button2.Text == "" && vez == true)
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && vez == true)
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && vez == true)
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && vez == true)
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && vez == true)
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && vez == true || button3.Text == "O" && button7.Text == "O" && button5.Text == "" && vez == true)
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                }
            }
        }
        private void Defensivo()
        {
            if (vez == true)
            {
                for (int r = 1; r <= 17; r++)
                {
                    if (r == 17 && vez == true)
                    {
                        Randomico();
                    }

                    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "" && vez == true || button6.Text == "X" && button6.Text == "X" && button3.Text == "" && vez == true)
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button1.Text == "X" && button3.Text == "X" && button2.Text == "" && vez == true || button5.Text == "X" && button8.Text == "X" && button2.Text == "" && vez == true)
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button2.Text == "X" && button3.Text == "X" && button1.Text == "" && vez == true || button4.Text == "X" && button7.Text == "X" && button1.Text == "" && vez == true)
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "X" && button5.Text == "X" && button6.Text == "" && vez == true || button3.Text == "X" && button9.Text == "X" && button6.Text == "" && vez == true)
                    {
                        button6.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button5.Text == "X" && button6.Text == "X" && button4.Text == "" && vez == true || button1.Text == "X" && button7.Text == "X" && button4.Text == "" && vez == true)
                    {
                        button4.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "X" && button6.Text == "X" && button5.Text == "" && vez == true || button2.Text == "X" && button8.Text == "X" && button5.Text == "" && vez == true)
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "X" && button8.Text == "X" && button9.Text == "" && vez == true || button3.Text == "X" && button6.Text == "X" && button9.Text == "" && vez == true)
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }

                    if (button8.Text == "X" && button9.Text == "X" && button7.Text == "" && vez == true || button1.Text == "X" && button4.Text == "X" && button7.Text == "" && vez == true)
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "X" && button9.Text == "X" && button8.Text == "" && vez == true || button2.Text == "X" && button5.Text == "X" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button2.Text == "X" && button4.Text == "X" && button8.Text == "" && vez == true)
                    {
                        button8.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button4.Text == "X" && button8.Text == "X" && button2.Text == "" && vez == true)
                    {
                        button2.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button1.Text == "X" && button5.Text == "X" && button9.Text == "" && vez == true)
                    {
                        button9.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button3.Text == "X" && button5.Text == "X" && button7.Text == "" && vez == true)
                    {
                        button7.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button5.Text == "X" && button9.Text == "X" && button1.Text == "" && vez == true)
                    {
                        button1.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button7.Text == "X" && button5.Text == "X" && button3.Text == "" && vez == true)
                    {
                        button3.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                    if (button1.Text == "X" && button9.Text == "X" && button5.Text == "" && vez == true || button3.Text == "X" && button7.Text == "X" && button5.Text == "" && vez == true)
                    {
                        button5.Text = "O";
                        rodadas++;
                        vez = false;
                        checagemVencedor();
                    }
                }
            }
        }

        private void Randomico()
        {
            bool looping = false;

            if (vez == true)
            {
                looping = true;
            }

            while (looping != false)
            {
                Random rdn = new Random();
                int randomizar = rdn.Next(1, 9);

                switch (randomizar)
                {
                    case 1:
                        if (button1.Text == "" && vez == true)
                        {
                            button1.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 2:
                        if (button2.Text == "" && vez == true)
                        {
                            button2.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 3:
                        if (button3.Text == "" && vez == true)
                        {
                            button3.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 4:
                        if (button4.Text == "" && vez == true)
                        {
                            button4.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 5:
                        if (button5.Text == "" && vez == true)
                        {
                            button5.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 6:
                        if (button6.Text == "" && vez == true)
                        {
                            button6.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 7:
                        if (button7.Text == "" && vez == true)
                        {
                            button7.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 8:
                        if (button8.Text == "" && vez == true)
                        {
                            button8.Text = "O";
                            rodadas++;
                            vez = false;
                            looping = false;
                            checagemVencedor();
                        }
                        break;
                    case 9:
                        if (button9.Text == "" && vez == true)
                        {
                            button9.Text = "O";
                            rodadas++;
                            looping = false;
                            vez = false;
                            checagemVencedor();
                        }
                        break;
                }
            }
        }


        private void reiniciaGame()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;           
        }

        private void Havencedor()
        {
            if (vencedor == 1)
            {
                x_vitoria++;
                label6.Text = Convert.ToString(x_vitoria);
                MessageBox.Show("Humano venceu!");
                button_disable = true;
                reiniciaGame();
            }
            else if (vencedor == 2)
            {
                o_vitoria++;
                label5.Text = Convert.ToString(o_vitoria);
                MessageBox.Show("Computador venceu!");
                button_disable = true;
                reiniciaGame();
            }
        }


        private void checagemVencedor()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                vencedor = 1;
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;
                Havencedor();

            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                vencedor = 1;
                button4.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                Havencedor();

            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                button7.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                vencedor = 1;
                button1.ForeColor = Color.Red;
                button4.ForeColor = Color.Red;
                button7.ForeColor = Color.Red;
                Havencedor();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                vencedor = 1;
                button2.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                Havencedor();

            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                button3.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                vencedor = 1;
                button1.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                vencedor = 1;
                button3.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button7.ForeColor = Color.Red;
                Havencedor();

            }

            // Player 2

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                vencedor = 2;
                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;
                Havencedor();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                vencedor = 2;
                button4.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                Havencedor();

            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                button7.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                vencedor = 2;
                button1.ForeColor = Color.Red;
                button4.ForeColor = Color.Red;
                button7.ForeColor = Color.Red;
                Havencedor();

            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                vencedor = 2;
                button2.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                Havencedor();

            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                button3.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                vencedor = 2;
                button1.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                Havencedor();

            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                vencedor = 2;
                button3.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button7.ForeColor = Color.Red;
                Havencedor();

            }

            if (rodadas == 9 && vencedor == 0)
            {
                MessageBox.Show("Empate");
                empate++;
                label4.Text = Convert.ToString(empate);
                button_disable = true;
                reiniciaGame();
            }

            if (vez == true && vencedor == 0 && rodadas != 9)
            {
                Ofensivo();
            }
        }
    }
}