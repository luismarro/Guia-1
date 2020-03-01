namespace Ejercicio_2
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
            this.txtdec = new System.Windows.Forms.TextBox();
            this.txtbin = new System.Windows.Forms.TextBox();
            this.txtoct = new System.Windows.Forms.TextBox();
            this.txthex = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero decimal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Octal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hexadecimal:";
            // 
            // txtdec
            // 
            this.txtdec.Location = new System.Drawing.Point(125, 29);
            this.txtdec.Name = "txtdec";
            this.txtdec.Size = new System.Drawing.Size(100, 20);
            this.txtdec.TabIndex = 4;
            // 
            // txtbin
            // 
            this.txtbin.Location = new System.Drawing.Point(95, 122);
            this.txtbin.Name = "txtbin";
            this.txtbin.Size = new System.Drawing.Size(100, 20);
            this.txtbin.TabIndex = 5;
            // 
            // txtoct
            // 
            this.txtoct.Location = new System.Drawing.Point(78, 167);
            this.txtoct.Name = "txtoct";
            this.txtoct.Size = new System.Drawing.Size(100, 20);
            this.txtoct.TabIndex = 6;
            // 
            // txthex
            // 
            this.txthex.Location = new System.Drawing.Point(113, 203);
            this.txthex.Name = "txthex";
            this.txthex.Size = new System.Drawing.Size(100, 20);
            this.txthex.TabIndex = 7;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(203, 71);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(227, 129);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 297);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txthex);
            this.Controls.Add(this.txtoct);
            this.Controls.Add(this.txtbin);
            this.Controls.Add(this.txtdec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Decimal a:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdec;
        private System.Windows.Forms.TextBox txtbin;
        private System.Windows.Forms.TextBox txtoct;
        private System.Windows.Forms.TextBox txthex;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

