namespace MAEPP
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.cmbEstratos = new System.Windows.Forms.ComboBox();
            this.btnAddEstrato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNH = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(153, 15);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(447, 388);
            this.txtDatos.TabIndex = 15;
            this.txtDatos.DoubleClick += new System.EventHandler(this.calcular);
            // 
            // cmbEstratos
            // 
            this.cmbEstratos.FormattingEnabled = true;
            this.cmbEstratos.Location = new System.Drawing.Point(13, 113);
            this.cmbEstratos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstratos.Name = "cmbEstratos";
            this.cmbEstratos.Size = new System.Drawing.Size(131, 24);
            this.cmbEstratos.TabIndex = 13;
            // 
            // btnAddEstrato
            // 
            this.btnAddEstrato.Location = new System.Drawing.Point(13, 76);
            this.btnAddEstrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEstrato.Name = "btnAddEstrato";
            this.btnAddEstrato.Size = new System.Drawing.Size(132, 28);
            this.btnAddEstrato.TabIndex = 12;
            this.btnAddEstrato.Text = "Agregar Estrato";
            this.btnAddEstrato.UseVisualStyleBackColor = true;
            this.btnAddEstrato.Click += new System.EventHandler(this.btnAddEstrato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "N:";
            // 
            // txtNG
            // 
            this.txtNG.Location = new System.Drawing.Point(44, 15);
            this.txtNG.Name = "txtNG";
            this.txtNG.Size = new System.Drawing.Size(100, 22);
            this.txtNG.TabIndex = 18;
            this.txtNG.TextChanged += new System.EventHandler(this.cambiaN);
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(63, 43);
            this.txtConf.Name = "txtConf";
            this.txtConf.Size = new System.Drawing.Size(81, 22);
            this.txtConf.TabIndex = 20;
            this.txtConf.TextChanged += new System.EventHandler(this.cambiaConf);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Conf:";
            // 
            // txtNH
            // 
            this.txtNH.Location = new System.Drawing.Point(54, 144);
            this.txtNH.Name = "txtNH";
            this.txtNH.Size = new System.Drawing.Size(90, 22);
            this.txtNH.TabIndex = 21;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(44, 172);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 22);
            this.txtn.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "n:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(46, 200);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "a:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar Estrato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNH);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.cmbEstratos);
            this.Controls.Add(this.btnAddEstrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.ComboBox cmbEstratos;
        private System.Windows.Forms.Button btnAddEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNH;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

