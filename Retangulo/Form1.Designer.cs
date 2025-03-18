namespace Retangulo
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
            this.lblAlturaA = new System.Windows.Forms.Label();
            this.lblAlturaB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblValorAl = new System.Windows.Forms.Label();
            this.lblValorPer = new System.Windows.Forms.Label();
            this.lblresultadoAl = new System.Windows.Forms.Label();
            this.lblResultaPe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlturaA
            // 
            this.lblAlturaA.AutoSize = true;
            this.lblAlturaA.Location = new System.Drawing.Point(130, 38);
            this.lblAlturaA.Name = "lblAlturaA";
            this.lblAlturaA.Size = new System.Drawing.Size(81, 13);
            this.lblAlturaA.TabIndex = 0;
            this.lblAlturaA.Text = "valor do lado A:";
            // 
            // lblAlturaB
            // 
            this.lblAlturaB.AutoSize = true;
            this.lblAlturaB.Location = new System.Drawing.Point(104, 74);
            this.lblAlturaB.Name = "lblAlturaB";
            this.lblAlturaB.Size = new System.Drawing.Size(107, 13);
            this.lblAlturaB.TabIndex = 1;
            this.lblAlturaB.Text = "VALOR DO LADO B:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(218, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(218, 74);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(229, 117);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblValorAl
            // 
            this.lblValorAl.AutoSize = true;
            this.lblValorAl.Location = new System.Drawing.Point(107, 161);
            this.lblValorAl.Name = "lblValorAl";
            this.lblValorAl.Size = new System.Drawing.Size(110, 13);
            this.lblValorAl.TabIndex = 5;
            this.lblValorAl.Text = "VALOR DA ALTURA:";
            // 
            // lblValorPer
            // 
            this.lblValorPer.AutoSize = true;
            this.lblValorPer.Location = new System.Drawing.Point(107, 200);
            this.lblValorPer.Name = "lblValorPer";
            this.lblValorPer.Size = new System.Drawing.Size(132, 13);
            this.lblValorPer.TabIndex = 6;
            this.lblValorPer.Text = "VALOR DO PERIMETRO:";
            // 
            // lblresultadoAl
            // 
            this.lblresultadoAl.AutoSize = true;
            this.lblresultadoAl.Location = new System.Drawing.Point(252, 161);
            this.lblresultadoAl.Name = "lblresultadoAl";
            this.lblresultadoAl.Size = new System.Drawing.Size(35, 13);
            this.lblresultadoAl.TabIndex = 7;
            this.lblresultadoAl.Text = "label1";
            // 
            // lblResultaPe
            // 
            this.lblResultaPe.AutoSize = true;
            this.lblResultaPe.Location = new System.Drawing.Point(255, 200);
            this.lblResultaPe.Name = "lblResultaPe";
            this.lblResultaPe.Size = new System.Drawing.Size(35, 13);
            this.lblResultaPe.TabIndex = 8;
            this.lblResultaPe.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 357);
            this.Controls.Add(this.lblResultaPe);
            this.Controls.Add(this.lblresultadoAl);
            this.Controls.Add(this.lblValorPer);
            this.Controls.Add(this.lblValorAl);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblAlturaB);
            this.Controls.Add(this.lblAlturaA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlturaA;
        private System.Windows.Forms.Label lblAlturaB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblValorAl;
        private System.Windows.Forms.Label lblValorPer;
        private System.Windows.Forms.Label lblresultadoAl;
        private System.Windows.Forms.Label lblResultaPe;
    }
}

