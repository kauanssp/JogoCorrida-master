using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCorridaWinFormsApp
{
    public partial class FormsInicio : Form
    {
        public FormsInicio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormsInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Fácil");
            jogo.ShowDialog();
        }


        private void btnMedio_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Médio");
            jogo.ShowDialog();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            var jogo = new FormJogoCorrida("Difícil");
            jogo.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
