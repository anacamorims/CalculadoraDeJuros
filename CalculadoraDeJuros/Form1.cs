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

        private void btnCalcular_Click(object sender, EventArgs e)
        { 
            //Declarando as Variaveis 
            
            double montante = 0;
            double capital  =0;
            double taxa = 0;    
            double tempo = 0;
            double juros = 0;

            int opcao =cbOpcoes.SelectedIndex;
            //montante = Convert.ToDouble(txtMontante.Text);
            //capital= Convert.ToDouble(txtCapital.Text);
            //taxa = Convert.ToDouble(txtTaxa.Text);
            //tempo = Convert.ToDouble(txtTempo.Text);
            //juros = Convert.ToDouble(txtJuros.Text);



            switch (opcao)
            {
                case 0:
                    capital = Convert.ToDouble(txtCapital.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);
                    
                    montante = capital * (1 + (taxa / 100) * tempo);
                    
                    txtMontante.Text= montante.ToString("F2");  
                    break;
                case 1:
                    montante = Convert.ToDouble(txtMontante.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);
                    
                    capital = montante / (1 + taxa *tempo);
                    txtCapital.Text = capital.ToString("F2");

                    break;
                
                case 2:
                    montante = Convert.ToDouble(txtMontante.Text);
                    capital = Convert.ToDouble(txtCapital.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);

                    taxa = montante
            }


            juros = montante - capital;








        }
        }
}
