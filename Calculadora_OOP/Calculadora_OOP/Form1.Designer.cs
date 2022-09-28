namespace Calculadora_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubt = new System.Windows.Forms.Button();
            this.buttonDivi = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(75, 140);
            this.labelNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(203, 20);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "Insira o primeiro Numero:";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(75, 220);
            this.labelNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(205, 20);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "Insira o segundo Numero:";
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(286, 137);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(141, 26);
            this.textBoxNum1.TabIndex = 2;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(286, 220);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(141, 26);
            this.textBoxNum2.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(63, 366);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(88, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Resultado";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(176, 366);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(0, 20);
            this.labelValor.TabIndex = 5;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSoma.Location = new System.Drawing.Point(125, 293);
            this.buttonSoma.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(52, 35);
            this.buttonSoma.TabIndex = 6;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubt
            // 
            this.buttonSubt.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubt.Location = new System.Drawing.Point(210, 293);
            this.buttonSubt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubt.Name = "buttonSubt";
            this.buttonSubt.Size = new System.Drawing.Size(52, 35);
            this.buttonSubt.TabIndex = 7;
            this.buttonSubt.Text = "-";
            this.buttonSubt.UseVisualStyleBackColor = true;
            this.buttonSubt.Click += new System.EventHandler(this.buttonSubt_Click);
            // 
            // buttonDivi
            // 
            this.buttonDivi.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivi.Location = new System.Drawing.Point(300, 293);
            this.buttonDivi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDivi.Name = "buttonDivi";
            this.buttonDivi.Size = new System.Drawing.Size(52, 35);
            this.buttonDivi.TabIndex = 8;
            this.buttonDivi.Text = "/";
            this.buttonDivi.UseVisualStyleBackColor = true;
            this.buttonDivi.Click += new System.EventHandler(this.buttonDivi_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMult.Location = new System.Drawing.Point(393, 293);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(52, 35);
            this.buttonMult.TabIndex = 9;
            this.buttonMult.Text = "x";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonSaida
            // 
            this.buttonSaida.Location = new System.Drawing.Point(489, 427);
            this.buttonSaida.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(69, 36);
            this.buttonSaida.TabIndex = 10;
            this.buttonSaida.Text = "Sair";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculadora em OOP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(590, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaida);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonDivi);
            this.Controls.Add(this.buttonSubt);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNum1;
        private Label labelNum2;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label labelResult;
        private Label labelValor;
        private Button buttonSoma;
        private Button buttonSubt;
        private Button buttonDivi;
        private Button buttonMult;
        private Button buttonSaida;
        private Label label1;
    }
}