﻿namespace Pclasse
{
    partial class frmMensalista
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.Não = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(274, 21);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(274, 165);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(184, 26);
            this.txtData.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(274, 115);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(184, 26);
            this.txtSalario.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(274, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 26);
            this.txtNome.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Não);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Location = new System.Drawing.Point(571, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office?";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(7, 91);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(61, 24);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            this.rbtnSim.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Não
            // 
            this.Não.AutoSize = true;
            this.Não.Location = new System.Drawing.Point(7, 121);
            this.Não.Name = "Não";
            this.Não.Size = new System.Drawing.Size(63, 24);
            this.Não.TabIndex = 1;
            this.Não.TabStop = true;
            this.Não.Text = "Não";
            this.Não.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 111);
            this.button1.TabIndex = 9;
            this.button1.Text = "Instanciar Mensalista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 111);
            this.button2.TabIndex = 10;
            this.button2.Text = "Instanciar Mensalista passando parâmetro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.Load += new System.EventHandler(this.FrmMensalista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Não;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}