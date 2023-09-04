using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoAula1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4;

            if (!string.IsNullOrEmpty(txtNota1.Text) && !string.IsNullOrEmpty(txtNota2.Text) &&
                !string.IsNullOrEmpty(txtNota3.Text) && !string.IsNullOrEmpty(txtNota4.Text))
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
                nota2 = Convert.ToDouble(txtNota2.Text);
                nota3 = Convert.ToDouble(txtNota3.Text);
                nota4 = Convert.ToDouble(txtNota4.Text);

                if((nota1 <=10) && (nota2 <=10) && (nota3 <=10) && (nota4 <=10))
                {
                    double resultado =  (nota1 + nota2 + nota3 + nota4) / 4;

                    txtNotaAnual.Text = resultado.ToString();

                    if(resultado <7)
                    {

                        lblMensagem.Visible = true;
                        lblMensagem.ForeColor = Color.Red;
                        lblMensagem.Text = "Aluno de Exame !";
                        lblMediaExame.Visible = true;
                        lblNotaExame.Visible=true;
                        txtMediaExame.Visible = true;
                        txtNotaExame.Visible = true;
                        btnCalcularExame.Visible= true;
                    }
                    else
                    {
                        lblMensagem.Visible = true;
                        lblMensagem.ForeColor = Color.Green;
                        lblMensagem.Text = "Aluno Aprovado !";
                    }
                    
                }
                else 
                {
                    MessageBox.Show("As notas devem ser de zero a dez !", "Erro");              
                }

            }
            else
            {
                MessageBox.Show("Erro notas em branco", "atenção");
            }

        }

        private void btnCalcularExame_Click(object sender, EventArgs e)
        {
            double notaExame = Convert.ToDouble(txtNotaExame.Text);
            double MediaAnual = Convert.ToDouble(txtNotaAnual.Text);

            double MediaExame = (notaExame + MediaAnual) / 2; 
            
            
            txtMediaExame.Text = MediaExame.ToString();
            if(MediaExame >=7)
            {
                lblMensagem2.Visible = true;
                lblMensagem2.Text = "Aluno Aprovado no exame !";
                lblMensagem2.ForeColor = Color.Green;
            }
            else 
            {
                lblMensagem2.Visible = true;
                lblMensagem2.Text = "Aluno Reprovado no exame !";
                lblMensagem2.ForeColor = Color.Red;
                
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult opSair = MessageBox.Show("Deseja realmente sair ?", "atenção", MessageBoxButtons.YesNo);

            if(opSair == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNotaExame.Text = "";
            txtNotaAnual.Text = "";
            //reseta os campos
            lblMediaExame.Visible = false;
            lblNotaExame.Visible = false;
            txtMediaExame.Visible = false;
            txtNotaExame.Visible = false;
            btnCalcularExame.Visible = false;
            lblMediaExame.Visible = false;
            lblMensagem.Visible = false;
            lblMensagem2.Visible = false;

            //Programar e legal
                
        }


    }
}
