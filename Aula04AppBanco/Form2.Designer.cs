﻿
namespace Aula04AppBanco
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.listExtratos = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(112, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Extrato Bancário";
			// 
			// listExtratos
			// 
			this.listExtratos.ForeColor = System.Drawing.Color.Black;
			this.listExtratos.HideSelection = false;
			this.listExtratos.Location = new System.Drawing.Point(68, 82);
			this.listExtratos.Name = "listExtratos";
			this.listExtratos.Size = new System.Drawing.Size(289, 281);
			this.listExtratos.TabIndex = 1;
			this.listExtratos.UseCompatibleStateImageBehavior = false;
			this.listExtratos.View = System.Windows.Forms.View.List;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkViolet;
			this.ClientSize = new System.Drawing.Size(430, 450);
			this.Controls.Add(this.listExtratos);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listExtratos;
	}
}