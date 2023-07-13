
namespace Aula04AppBanco
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblsaldo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btndepositar = new System.Windows.Forms.Button();
			this.btnsacar = new System.Windows.Forms.Button();
			this.btnextrato = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbldeposito = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtvalor = new System.Windows.Forms.TextBox();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.DarkViolet;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(121, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "SuS Bank ඞ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DarkViolet;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(55, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seu Saldo Atual";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblsaldo
			// 
			this.lblsaldo.AutoSize = true;
			this.lblsaldo.BackColor = System.Drawing.Color.DarkViolet;
			this.lblsaldo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsaldo.ForeColor = System.Drawing.Color.White;
			this.lblsaldo.Location = new System.Drawing.Point(60, 89);
			this.lblsaldo.Name = "lblsaldo";
			this.lblsaldo.Size = new System.Drawing.Size(56, 27);
			this.lblsaldo.TabIndex = 2;
			this.lblsaldo.Text = "R$ 0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Operações Disponíveis";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// btndepositar
			// 
			this.btndepositar.BackColor = System.Drawing.Color.PowderBlue;
			this.btndepositar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndepositar.ForeColor = System.Drawing.Color.Black;
			this.btndepositar.Location = new System.Drawing.Point(12, 29);
			this.btndepositar.Name = "btndepositar";
			this.btndepositar.Size = new System.Drawing.Size(149, 50);
			this.btndepositar.TabIndex = 0;
			this.btndepositar.Text = "Depositar";
			this.btndepositar.UseVisualStyleBackColor = false;
			this.btndepositar.Click += new System.EventHandler(this.btndepositar_Click);
			// 
			// btnsacar
			// 
			this.btnsacar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsacar.ForeColor = System.Drawing.Color.Black;
			this.btnsacar.Location = new System.Drawing.Point(167, 29);
			this.btnsacar.Name = "btnsacar";
			this.btnsacar.Size = new System.Drawing.Size(144, 50);
			this.btnsacar.TabIndex = 1;
			this.btnsacar.Text = "Sacar";
			this.btnsacar.UseVisualStyleBackColor = true;
			this.btnsacar.Click += new System.EventHandler(this.btnsacar_Click);
			// 
			// btnextrato
			// 
			this.btnextrato.Location = new System.Drawing.Point(280, 75);
			this.btnextrato.Name = "btnextrato";
			this.btnextrato.Size = new System.Drawing.Size(103, 29);
			this.btnextrato.TabIndex = 2;
			this.btnextrato.Text = "Ver Extrato";
			this.btnextrato.UseVisualStyleBackColor = true;
			this.btnextrato.Click += new System.EventHandler(this.btnextrato_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.btndepositar);
			this.groupBox1.Controls.Add(this.btnsacar);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(58, 163);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(327, 253);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operações Disponíveis";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkViolet;
			this.panel1.Controls.Add(this.btnsalvar);
			this.panel1.Controls.Add(this.txtvalor);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.lbldeposito);
			this.panel1.Location = new System.Drawing.Point(7, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 152);
			this.panel1.TabIndex = 2;
			// 
			// lbldeposito
			// 
			this.lbldeposito.AutoSize = true;
			this.lbldeposito.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbldeposito.Location = new System.Drawing.Point(20, 18);
			this.lbldeposito.Name = "lbldeposito";
			this.lbldeposito.Size = new System.Drawing.Size(88, 21);
			this.lbldeposito.TabIndex = 0;
			this.lbldeposito.Text = "DEPÓSITO";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Informe o Valor";
			// 
			// txtvalor
			// 
			this.txtvalor.Location = new System.Drawing.Point(24, 80);
			this.txtvalor.Name = "txtvalor";
			this.txtvalor.Size = new System.Drawing.Size(267, 20);
			this.txtvalor.TabIndex = 7;
			// 
			// btnsalvar
			// 
			this.btnsalvar.ForeColor = System.Drawing.Color.Black;
			this.btnsalvar.Location = new System.Drawing.Point(113, 106);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(103, 23);
			this.btnsalvar.TabIndex = 3;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = true;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkViolet;
			this.panel2.Controls.Add(this.btnextrato);
			this.panel2.Location = new System.Drawing.Point(2, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(426, 162);
			this.panel2.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrchid;
			this.ClientSize = new System.Drawing.Size(428, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblsaldo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblsaldo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btndepositar;
		private System.Windows.Forms.Button btnsacar;
		private System.Windows.Forms.Button btnextrato;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbldeposito;
		private System.Windows.Forms.Button btnsalvar;
		private System.Windows.Forms.TextBox txtvalor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
	}
}

