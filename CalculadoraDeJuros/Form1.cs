using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CalculadoraDeJuros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcao = cbOpcoes.SelectedIndex;

            txtMontante.BackColor = Color.White;
            txtCapital.BackColor = Color.White;
            txtTaxa.BackColor = Color.White;
            txtTempo.BackColor = Color.White;



            switch (opcao)
            {
                case 0:
                    txtMontante.BackColor = Color.Pink;
                    break;

                case 1:
                    txtCapital.BackColor = Color.Pink;

                    break;
                case 2:
                    txtTaxa.BackColor = Color.Pink;

                    break;
                case 3:
                    txtTempo.BackColor = Color.Pink;

                    break;
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            double montante = 0;
            double capital = 0;
            double taxa = 0;
            double tempo = 0;
            double juros = 0;

            int opcao = cbOpcoes.SelectedIndex;
            switch (opcao)
            {
                case 0:
                    capital = Convert.ToDouble(txtCapital.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);

                    montante = capital * (1 + (taxa / 100) * tempo);

                    txtMontante.Text = montante.ToString("F2");
                    break;
                case 1:
                    montante = Convert.ToDouble(txtMontante.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);

                    capital = montante / (1 + (taxa / 100) * tempo);
                    txtCapital.Text = capital.ToString("F2");

                    break;
                case 2:
                    montante = Convert.ToDouble(txtMontante.Text);
                    capital = Convert.ToDouble(txtCapital.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);

                    taxa = (montante - capital) / (capital * tempo);
                    txtTaxa.Text = (taxa * 100).ToString("F2");
                    break;
                case 3:
                    montante = Convert.ToDouble(txtMontante.Text);
                    capital = Convert.ToDouble(txtCapital.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text);

                    tempo = (montante - capital) / (capital * (taxa / 100));
                    txtTempo.Text = tempo.ToString("F2");
                    break;

            }

            juros = montante - capital;
            txtJuros.Text = juros.ToString("F2");

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbOpcoes.SelectedIndex = -1;
            txtMontante.Clear();
            txtCapital.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtJuros.Clear();
        }
    }
}

