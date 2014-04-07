namespace MAE
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
            this.btnAddEstrato = new System.Windows.Forms.Button();
            this.cmbEstratos = new System.Windows.Forms.ComboBox();
            this.lstEstratos = new System.Windows.Forms.ListBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtAddV = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreParaM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddEstrato
            // 
            this.btnAddEstrato.Location = new System.Drawing.Point(17, 16);
            this.btnAddEstrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEstrato.Name = "btnAddEstrato";
            this.btnAddEstrato.Size = new System.Drawing.Size(132, 28);
            this.btnAddEstrato.TabIndex = 0;
            this.btnAddEstrato.Text = "Agregar Estrato";
            this.btnAddEstrato.UseVisualStyleBackColor = true;
            this.btnAddEstrato.Click += new System.EventHandler(this.btnAddEstrato_Click);
            // 
            // cmbEstratos
            // 
            this.cmbEstratos.FormattingEnabled = true;
            this.cmbEstratos.Location = new System.Drawing.Point(17, 53);
            this.cmbEstratos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstratos.Name = "cmbEstratos";
            this.cmbEstratos.Size = new System.Drawing.Size(131, 24);
            this.cmbEstratos.TabIndex = 1;
            this.cmbEstratos.SelectedIndexChanged += new System.EventHandler(this.cmbEstratos_SelectedIndexChanged);
            // 
            // lstEstratos
            // 
            this.lstEstratos.FormattingEnabled = true;
            this.lstEstratos.ItemHeight = 16;
            this.lstEstratos.Location = new System.Drawing.Point(17, 86);
            this.lstEstratos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEstratos.Name = "lstEstratos";
            this.lstEstratos.Size = new System.Drawing.Size(131, 468);
            this.lstEstratos.TabIndex = 2;
            // 
            // txtDatos
            // 
            this.txtDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatos.Location = new System.Drawing.Point(157, 18);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(447, 578);
            this.txtDatos.TabIndex = 3;
            this.txtDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.refrescar);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 571);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(88, 22);
            this.txtValor.TabIndex = 4;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeys);
            // 
            // txtAddV
            // 
            this.txtAddV.Location = new System.Drawing.Point(115, 569);
            this.txtAddV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddV.Name = "txtAddV";
            this.txtAddV.Size = new System.Drawing.Size(35, 28);
            this.txtAddV.TabIndex = 5;
            this.txtAddV.Text = "+";
            this.txtAddV.UseVisualStyleBackColor = true;
            this.txtAddV.Click += new System.EventHandler(this.txtAddV_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTamaño.Location = new System.Drawing.Point(57, 604);
            this.txtTamaño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(96, 22);
            this.txtTamaño.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 608);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "N=";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 608);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor de tabla =";
            // 
            // txtTabla
            // 
            this.txtTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTabla.Location = new System.Drawing.Point(279, 604);
            this.txtTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(96, 22);
            this.txtTabla.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 608);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "% para est media";
            // 
            // txtPreParaM
            // 
            this.txtPreParaM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreParaM.Location = new System.Drawing.Point(508, 604);
            this.txtPreParaM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreParaM.Name = "txtPreParaM";
            this.txtPreParaM.Size = new System.Drawing.Size(96, 22);
            this.txtPreParaM.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 647);
            this.Controls.Add(this.txtPreParaM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.txtAddV);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lstEstratos);
            this.Controls.Add(this.cmbEstratos);
            this.Controls.Add(this.btnAddEstrato);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Muestreo Aleatorio Estratificado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEstrato;
        private System.Windows.Forms.ComboBox cmbEstratos;
        private System.Windows.Forms.ListBox lstEstratos;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button txtAddV;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreParaM;
    }
}

