namespace Ejercicio_3_guia1
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtinv1 = new System.Windows.Forms.TextBox();
            this.txtinv2 = new System.Windows.Forms.TextBox();
            this.txtinv3 = new System.Windows.Forms.TextBox();
            this.txtpor1 = new System.Windows.Forms.TextBox();
            this.txtpor2 = new System.Windows.Forms.TextBox();
            this.txtpor3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porcentajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "3:";
            // 
            // txtinv1
            // 
            this.txtinv1.Location = new System.Drawing.Point(83, 88);
            this.txtinv1.Name = "txtinv1";
            this.txtinv1.Size = new System.Drawing.Size(100, 20);
            this.txtinv1.TabIndex = 5;
            // 
            // txtinv2
            // 
            this.txtinv2.Location = new System.Drawing.Point(83, 128);
            this.txtinv2.Name = "txtinv2";
            this.txtinv2.Size = new System.Drawing.Size(100, 20);
            this.txtinv2.TabIndex = 6;
            // 
            // txtinv3
            // 
            this.txtinv3.Location = new System.Drawing.Point(86, 170);
            this.txtinv3.Name = "txtinv3";
            this.txtinv3.Size = new System.Drawing.Size(100, 20);
            this.txtinv3.TabIndex = 7;
            // 
            // txtpor1
            // 
            this.txtpor1.Location = new System.Drawing.Point(395, 81);
            this.txtpor1.Name = "txtpor1";
            this.txtpor1.Size = new System.Drawing.Size(100, 20);
            this.txtpor1.TabIndex = 8;
            // 
            // txtpor2
            // 
            this.txtpor2.Location = new System.Drawing.Point(395, 128);
            this.txtpor2.Name = "txtpor2";
            this.txtpor2.Size = new System.Drawing.Size(100, 20);
            this.txtpor2.TabIndex = 9;
            // 
            // txtpor3
            // 
            this.txtpor3.Location = new System.Drawing.Point(395, 169);
            this.txtpor3.Name = "txtpor3";
            this.txtpor3.Size = new System.Drawing.Size(100, 20);
            this.txtpor3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total inversión";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(83, 251);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 12;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(229, 280);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(322, 280);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(420, 280);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 320);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpor3);
            this.Controls.Add(this.txtpor2);
            this.Controls.Add(this.txtpor1);
            this.Controls.Add(this.txtinv3);
            this.Controls.Add(this.txtinv2);
            this.Controls.Add(this.txtinv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtinv1;
        private System.Windows.Forms.TextBox txtinv2;
        private System.Windows.Forms.TextBox txtinv3;
        private System.Windows.Forms.TextBox txtpor1;
        private System.Windows.Forms.TextBox txtpor2;
        private System.Windows.Forms.TextBox txtpor3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

