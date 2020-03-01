namespace ejerci1_guia1_pro2
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
            this.cal = new System.Windows.Forms.Button();
            this.lim = new System.Windows.Forms.Button();
            this.sal = new System.Windows.Forms.Button();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examen 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Examen 3:";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(57, 311);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 3;
            this.cal.Text = "Calcular";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // lim
            // 
            this.lim.Location = new System.Drawing.Point(156, 311);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(75, 23);
            this.lim.TabIndex = 4;
            this.lim.Text = "Limpiar";
            this.lim.UseVisualStyleBackColor = true;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(255, 311);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(75, 23);
            this.sal.TabIndex = 5;
            this.sal.Text = "Salir";
            this.sal.UseVisualStyleBackColor = true;
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(95, 61);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 6;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(95, 114);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 7;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(95, 165);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 8;
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(270, 247);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(100, 20);
            this.txtpro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Promedio";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(196, 84);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 13);
            this.lab1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 366);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.cal);
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
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button lim;
        private System.Windows.Forms.Button sal;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab1;
    }
}

