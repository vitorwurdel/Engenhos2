using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "LIGAR";
            button2.Text = "TROCAR BATERIA";
            button2.BackColor = Color.Yellow;
            label1.Text = "100";
            button1.BackColor = Color.Red;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            Program.lanterna.ligaDesligaBtn = button1;
            Program.lanterna.statusBateria = label1;
            Program.lanterna.imgDesligada = pictureBox1;
            Program.lanterna.imgLigada = pictureBox2;

            Program.aTimer.Tick += new EventHandler(Program.lanterna.ConsomeBateria);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.lanterna.LigaDesliga();
            if (Program.lanterna.ligado == true)
            {
                button1.Text = "DESLIGAR";
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.Text = "LIGAR";
                button1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Program.lanterna.TrocaBateria(); 
        }
    }
}
