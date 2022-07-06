using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhos2
{
    internal class Lanterna
    {
        public Bateria bateriaAtual;
        public bool ligado;

        public Button ligaDesligaBtn;
        public Label statusBateria;
        public PictureBox imgLigada, imgDesligada;

        public void LigaDesliga()
        {
            if (bateriaAtual.carga > 0 && ligado == false)
            {
                ligado = true;

                Program.aTimer.Enabled = true;
                Program.aTimer.Interval = 1000;
                Program.aTimer.Start();
                imgLigada.Visible = true;
                imgDesligada.Visible = false;
            }
            else
            {
                ligado = false;
                imgDesligada.Visible = true;
                imgLigada.Visible = false;
                Program.aTimer.Enabled = false;
            }
        }

        public void ConsomeBateria(Object objeto, EventArgs eventoArgs)
        {
            if (bateriaAtual.carga > 0)
            {
                bateriaAtual.carga--;
                statusBateria.Text = bateriaAtual.carga.ToString();

                if (bateriaAtual.carga == 0)
                {
                    ligado = false;
                    Program.aTimer.Enabled = false;
                    ligaDesligaBtn.Text = "LIGAR";
                    ligaDesligaBtn.BackColor = Color.Red;
                    imgDesligada.Visible = true;
                    imgLigada.Visible = false;
                }
            }
        }

        public void TrocaBateria()
        {
            bateriaAtual = new Bateria();
            statusBateria.Text = bateriaAtual.carga.ToString();
        }
    }
}
