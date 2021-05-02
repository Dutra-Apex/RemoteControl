using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;

namespace controleCarrinho
{
    public partial class Form1 : Form
    {

        private string comando = "S";
        private bool farolLigado = false;
        private bool lanternaLigada = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           // label1.Text = e.KeyCode.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //label1.Text = "S";
        }
      
        private void btn_Frente_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Frente.Image = Properties.Resources.seta_frente;
            comando = "F";
        }

        private void btn_Frente_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Frente.Image = Properties.Resources.seta_frente_off;
            comando = "S";
        }
      
        private void btn_Esquerda_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Esquerda.Image = Properties.Resources.seta_esquerda;
            comando = "L";
        }

        private void btn_Esquerda_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Esquerda.Image = Properties.Resources.seta_esquerda_off;
            comando = "S";
        }

        private void btn_Re_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Re.Image = Properties.Resources.seta_re;
            comando = "B";
        }

        private void btn_Re_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Re.Image = Properties.Resources.seta_re_off;
            comando = "S";
        }

        private void btn_Direita_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Direita.Image = Properties.Resources.seta_direita;
            comando = "R";
        }

        private void btn_Direita_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Direita.Image = Properties.Resources.seta_direita_off;
            comando = "S";
        }

        private void btn_Buzina_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Buzina.Image = Properties.Resources.buzina;
            comando = "V";
        }

        private void btn_Buzina_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Buzina.Image = Properties.Resources.buzina_off;
            comando = "v";
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine(comando);
            //label1.Text = comando;
        }

        private void btn_ConectarSerial_Click(object sender, EventArgs e)
        {
            
            if(!serialPort1.IsOpen)
            {
                serialPort1.PortName = tb_Serial.Text;
                serialPort1.Open();

                btn_ConectarSerial.Text = "Desconectar";
                loop.Enabled = true;
            }
            else
            {
                loop.Enabled = false;
                serialPort1.Close();
                btn_ConectarSerial.Text = "Conectar";

            }
       
        }

        private void tb_Velocidade_Scroll(object sender, EventArgs e)
        {
            if(tb_Velocidade.Value != 10)
            {
                comando = Convert.ToString(tb_Velocidade.Value);
            }
            else
            {
                comando = "q";
            }
        }

        private void btn_Farol_Click(object sender, EventArgs e)
        {
            if(!farolLigado)
            {
                farolLigado = true;
                comando = "W";
                btn_Farol.Text = "Turn Lights Off";
            }
            else
            {
                farolLigado = false;
                comando = "w";
                btn_Farol.Text = "Turn Lights On";
            }
        }

        private void btn_Lanterna_Click(object sender, EventArgs e)
        {
            if (!lanternaLigada)
            {
                lanternaLigada = true;
                comando = "U";
                btn_Lanterna.Text = "Desligar Lanterna";
            }
            else
            {
                lanternaLigada = false;
                comando = "u";
                btn_Lanterna.Text = "Ligar Lanterna";
            }
        }
    }
}
