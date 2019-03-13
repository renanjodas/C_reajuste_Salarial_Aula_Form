namespace reajuste_Salarial
{
	partial class FormReajusteSalarial
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
			this.lblSalarioMin = new System.Windows.Forms.Label();
			this.lblHorastrab = new System.Windows.Forms.Label();
			this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
			this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
			this.gbxCategoria = new System.Windows.Forms.GroupBox();
			this.gbxTurno = new System.Windows.Forms.GroupBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.rbCalouro = new System.Windows.Forms.RadioButton();
			this.rbVeterano = new System.Windows.Forms.RadioButton();
			this.rbMatutino = new System.Windows.Forms.RadioButton();
			this.rbVespertino = new System.Windows.Forms.RadioButton();
			this.rbNoturno = new System.Windows.Forms.RadioButton();
			this.lbxResumo = new System.Windows.Forms.ListBox();
			this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
			this.gbxCategoria.SuspendLayout();
			this.gbxTurno.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSalarioMin
			// 
			this.lblSalarioMin.AutoSize = true;
			this.lblSalarioMin.Location = new System.Drawing.Point(18, 28);
			this.lblSalarioMin.Name = "lblSalarioMin";
			this.lblSalarioMin.Size = new System.Drawing.Size(77, 13);
			this.lblSalarioMin.TabIndex = 0;
			this.lblSalarioMin.Text = "Salário Mínimo";
			// 
			// lblHorastrab
			// 
			this.lblHorastrab.AutoSize = true;
			this.lblHorastrab.Location = new System.Drawing.Point(18, 59);
			this.lblHorastrab.Name = "lblHorastrab";
			this.lblHorastrab.Size = new System.Drawing.Size(93, 13);
			this.lblHorastrab.TabIndex = 1;
			this.lblHorastrab.Text = "Horas trabalhadas";
			// 
			// txtSalarioMinimo
			// 
			this.txtSalarioMinimo.Location = new System.Drawing.Point(117, 25);
			this.txtSalarioMinimo.Name = "txtSalarioMinimo";
			this.txtSalarioMinimo.Size = new System.Drawing.Size(111, 20);
			this.txtSalarioMinimo.TabIndex = 2;
			// 
			// txtHorasTrabalhadas
			// 
			this.txtHorasTrabalhadas.Location = new System.Drawing.Point(117, 56);
			this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
			this.txtHorasTrabalhadas.Size = new System.Drawing.Size(111, 20);
			this.txtHorasTrabalhadas.TabIndex = 3;
			// 
			// gbxCategoria
			// 
			this.gbxCategoria.Controls.Add(this.rbVeterano);
			this.gbxCategoria.Controls.Add(this.rbCalouro);
			this.gbxCategoria.Location = new System.Drawing.Point(21, 88);
			this.gbxCategoria.Name = "gbxCategoria";
			this.gbxCategoria.Size = new System.Drawing.Size(218, 87);
			this.gbxCategoria.TabIndex = 4;
			this.gbxCategoria.TabStop = false;
			this.gbxCategoria.Text = "Categoria";
			// 
			// gbxTurno
			// 
			this.gbxTurno.Controls.Add(this.rbNoturno);
			this.gbxTurno.Controls.Add(this.rbVespertino);
			this.gbxTurno.Controls.Add(this.rbMatutino);
			this.gbxTurno.Location = new System.Drawing.Point(245, 25);
			this.gbxTurno.Name = "gbxTurno";
			this.gbxTurno.Size = new System.Drawing.Size(118, 150);
			this.gbxTurno.TabIndex = 5;
			this.gbxTurno.TabStop = false;
			this.gbxTurno.Text = "Turno";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(288, 344);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// rbCalouro
			// 
			this.rbCalouro.AutoSize = true;
			this.rbCalouro.Location = new System.Drawing.Point(25, 38);
			this.rbCalouro.Name = "rbCalouro";
			this.rbCalouro.Size = new System.Drawing.Size(61, 17);
			this.rbCalouro.TabIndex = 0;
			this.rbCalouro.TabStop = true;
			this.rbCalouro.Text = "Calouro";
			this.rbCalouro.UseVisualStyleBackColor = true;
			// 
			// rbVeterano
			// 
			this.rbVeterano.AutoSize = true;
			this.rbVeterano.Location = new System.Drawing.Point(123, 38);
			this.rbVeterano.Name = "rbVeterano";
			this.rbVeterano.Size = new System.Drawing.Size(68, 17);
			this.rbVeterano.TabIndex = 1;
			this.rbVeterano.TabStop = true;
			this.rbVeterano.Text = "Veterano";
			this.rbVeterano.UseVisualStyleBackColor = true;
			// 
			// rbMatutino
			// 
			this.rbMatutino.AutoSize = true;
			this.rbMatutino.Location = new System.Drawing.Point(6, 31);
			this.rbMatutino.Name = "rbMatutino";
			this.rbMatutino.Size = new System.Drawing.Size(66, 17);
			this.rbMatutino.TabIndex = 0;
			this.rbMatutino.TabStop = true;
			this.rbMatutino.Text = "Matutino";
			this.rbMatutino.UseVisualStyleBackColor = true;
			// 
			// rbVespertino
			// 
			this.rbVespertino.AutoSize = true;
			this.rbVespertino.Location = new System.Drawing.Point(6, 70);
			this.rbVespertino.Name = "rbVespertino";
			this.rbVespertino.Size = new System.Drawing.Size(75, 17);
			this.rbVespertino.TabIndex = 1;
			this.rbVespertino.TabStop = true;
			this.rbVespertino.Text = "Vespertino";
			this.rbVespertino.UseVisualStyleBackColor = true;
			// 
			// rbNoturno
			// 
			this.rbNoturno.AutoSize = true;
			this.rbNoturno.Location = new System.Drawing.Point(6, 107);
			this.rbNoturno.Name = "rbNoturno";
			this.rbNoturno.Size = new System.Drawing.Size(63, 17);
			this.rbNoturno.TabIndex = 2;
			this.rbNoturno.TabStop = true;
			this.rbNoturno.Text = "Noturno";
			this.rbNoturno.UseVisualStyleBackColor = true;
			// 
			// lbxResumo
			// 
			this.lbxResumo.FormattingEnabled = true;
			this.lbxResumo.Location = new System.Drawing.Point(17, 191);
			this.lbxResumo.Name = "lbxResumo";
			this.lbxResumo.Size = new System.Drawing.Size(346, 147);
			this.lbxResumo.TabIndex = 9;
			// 
			// txtSituacaoEstagiario
			// 
			this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
			this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSituacaoEstagiario.Location = new System.Drawing.Point(17, 346);
			this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
			this.txtSituacaoEstagiario.ReadOnly = true;
			this.txtSituacaoEstagiario.Size = new System.Drawing.Size(250, 20);
			this.txtSituacaoEstagiario.TabIndex = 10;
			this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormReajusteSalarial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 397);
			this.Controls.Add(this.txtSituacaoEstagiario);
			this.Controls.Add(this.lbxResumo);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.gbxTurno);
			this.Controls.Add(this.gbxCategoria);
			this.Controls.Add(this.txtHorasTrabalhadas);
			this.Controls.Add(this.txtSalarioMinimo);
			this.Controls.Add(this.lblHorastrab);
			this.Controls.Add(this.lblSalarioMin);
			this.Name = "FormReajusteSalarial";
			this.gbxCategoria.ResumeLayout(false);
			this.gbxCategoria.PerformLayout();
			this.gbxTurno.ResumeLayout(false);
			this.gbxTurno.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSalarioMin;
		private System.Windows.Forms.Label lblHorastrab;
		private System.Windows.Forms.TextBox txtSalarioMinimo;
		private System.Windows.Forms.TextBox txtHorasTrabalhadas;
		private System.Windows.Forms.GroupBox gbxCategoria;
		private System.Windows.Forms.RadioButton rbVeterano;
		private System.Windows.Forms.RadioButton rbCalouro;
		private System.Windows.Forms.GroupBox gbxTurno;
		private System.Windows.Forms.RadioButton rbNoturno;
		private System.Windows.Forms.RadioButton rbVespertino;
		private System.Windows.Forms.RadioButton rbMatutino;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.ListBox lbxResumo;
		private System.Windows.Forms.TextBox txtSituacaoEstagiario;
	}
}