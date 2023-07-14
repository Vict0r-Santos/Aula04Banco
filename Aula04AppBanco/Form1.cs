using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
	public partial class Form1 : Form
	{
		public List<string> extratos = new List<string>();
		public Form1()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnsacar_Click(object sender, EventArgs e)
		{
			string nome;

			nome = lbldeposito.Text = "SAQUE";

			btndepositar.BackColor = Color.Gainsboro;
			btnsacar.BackColor = Color.PowderBlue;

			

		}

		private void btndepositar_Click(object sender, EventArgs e)
		{
			string nome;

			nome = lbldeposito.Text = "DEPÓSITO";

			btndepositar.BackColor = Color.PowderBlue;
			btnsacar.BackColor = Color.Gainsboro;

			txtvalor.Clear();
		}

		private void btnsalvar_Click(object sender, EventArgs e)
		{
			//double valor = double.Parse(txtvalor.Text); ;
			//double saldo = double.Parse(lblsaldo.Text.Relace("R$", "");
			//double soma = soma + valor;

			double valor;
			double saldo;

			if (lbldeposito.Text == "SAQUE")
			{

				valor = double.Parse(txtvalor.Text);
				saldo = double.Parse(lblsaldo.Text.Replace("R$", ""));
				double soma2 = saldo - valor;
				extratos.Add($"Saque no Valor de R$ {soma2}");

				lblsaldo.Text = $"R$ {soma2}";

				txtvalor.Clear();


			}
			else
			{

				valor = double.Parse(txtvalor.Text);
				saldo = double.Parse(lblsaldo.Text.Replace("R$", ""));
				double soma = saldo + valor;
				extratos.Add($"Saque no Valor de R$ {soma}");

				lblsaldo.Text = $"R$ {soma}";
				txtvalor.Clear();

			}

			
		}

		private void btnextrato_Click(object sender, EventArgs e)
		{
			Form2 telaextrato = new Form2();
			telaextrato.extratos = extratos;
			telaextrato.Show();
		}
	}
}
