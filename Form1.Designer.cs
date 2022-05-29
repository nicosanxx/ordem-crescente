
namespace ordem_crescente
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valor01 = new System.Windows.Forms.TextBox();
            this.txt_valor02 = new System.Windows.Forms.TextBox();
            this.txt_valor03 = new System.Windows.Forms.TextBox();
            this.txt_menor = new System.Windows.Forms.TextBox();
            this.txt_medio = new System.Windows.Forms.TextBox();
            this.txt_maior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Efetuar a leitura de três valores e apresentá-los dispostos em ordem crescente. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor03";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ORDEM CRESCENTE";
            // 
            // txt_valor01
            // 
            this.txt_valor01.Location = new System.Drawing.Point(30, 50);
            this.txt_valor01.Name = "txt_valor01";
            this.txt_valor01.Size = new System.Drawing.Size(100, 20);
            this.txt_valor01.TabIndex = 12;
            // 
            // txt_valor02
            // 
            this.txt_valor02.Location = new System.Drawing.Point(30, 110);
            this.txt_valor02.Name = "txt_valor02";
            this.txt_valor02.Size = new System.Drawing.Size(100, 20);
            this.txt_valor02.TabIndex = 13;
            // 
            // txt_valor03
            // 
            this.txt_valor03.Location = new System.Drawing.Point(30, 156);
            this.txt_valor03.Name = "txt_valor03";
            this.txt_valor03.Size = new System.Drawing.Size(100, 20);
            this.txt_valor03.TabIndex = 14;
            // 
            // txt_menor
            // 
            this.txt_menor.Enabled = false;
            this.txt_menor.Location = new System.Drawing.Point(270, 50);
            this.txt_menor.Name = "txt_menor";
            this.txt_menor.Size = new System.Drawing.Size(100, 20);
            this.txt_menor.TabIndex = 15;
            // 
            // txt_medio
            // 
            this.txt_medio.Enabled = false;
            this.txt_medio.Location = new System.Drawing.Point(270, 107);
            this.txt_medio.Name = "txt_medio";
            this.txt_medio.Size = new System.Drawing.Size(100, 20);
            this.txt_medio.TabIndex = 16;
            // 
            // txt_maior
            // 
            this.txt_maior.Enabled = false;
            this.txt_maior.Location = new System.Drawing.Point(270, 156);
            this.txt_maior.Name = "txt_maior";
            this.txt_maior.Size = new System.Drawing.Size(100, 20);
            this.txt_maior.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 375);
            this.Controls.Add(this.txt_maior);
            this.Controls.Add(this.txt_medio);
            this.Controls.Add(this.txt_menor);
            this.Controls.Add(this.txt_valor03);
            this.Controls.Add(this.txt_valor02);
            this.Controls.Add(this.txt_valor01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valor01;
        private System.Windows.Forms.TextBox txt_valor02;
        private System.Windows.Forms.TextBox txt_valor03;
        private System.Windows.Forms.TextBox txt_menor;
        private System.Windows.Forms.TextBox txt_medio;
        private System.Windows.Forms.TextBox txt_maior;
    }
}

