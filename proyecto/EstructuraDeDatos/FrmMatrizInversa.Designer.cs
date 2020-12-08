namespace EstructuraDeDatos
{
    partial class FrmMatrizInversa
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
            this.dgDeterminante = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnInversa = new System.Windows.Forms.Button();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.lblCxF = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.txtLimInf = new System.Windows.Forms.TextBox();
            this.txtLimSup = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDet = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeterminante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "[A^-1] = ";
            // 
            // dgDeterminante
            // 
            this.dgDeterminante.AllowUserToAddRows = false;
            this.dgDeterminante.AllowUserToDeleteRows = false;
            this.dgDeterminante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeterminante.Location = new System.Drawing.Point(12, 138);
            this.dgDeterminante.Name = "dgDeterminante";
            this.dgDeterminante.Size = new System.Drawing.Size(334, 197);
            this.dgDeterminante.TabIndex = 2;
            this.dgDeterminante.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matriz Inversa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "A*=";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(373, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(348, 197);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(12, 397);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(837, 300);
            this.dataGridView5.TabIndex = 11;
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(877, 216);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(249, 47);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnInversa
            // 
            this.btnInversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversa.Location = new System.Drawing.Point(877, 347);
            this.btnInversa.Name = "btnInversa";
            this.btnInversa.Size = new System.Drawing.Size(249, 50);
            this.btnInversa.TabIndex = 13;
            this.btnInversa.Text = "Inversa";
            this.btnInversa.UseVisualStyleBackColor = true;
            this.btnInversa.Click += new System.EventHandler(this.btnInversa_Click);
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo.Location = new System.Drawing.Point(877, 147);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(249, 54);
            this.btnEjemplo.TabIndex = 14;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // lblCxF
            // 
            this.lblCxF.AutoSize = true;
            this.lblCxF.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCxF.Location = new System.Drawing.Point(12, 41);
            this.lblCxF.Name = "lblCxF";
            this.lblCxF.Size = new System.Drawing.Size(218, 21);
            this.lblCxF.TabIndex = 15;
            this.lblCxF.Text = "Num. Cols x Rens";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.Location = new System.Drawing.Point(245, 35);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(196, 31);
            this.txtColumnas.TabIndex = 17;
            this.txtColumnas.Text = "3";
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDimensionar.Location = new System.Drawing.Point(877, 287);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(249, 48);
            this.btnDimensionar.TabIndex = 18;
            this.btnDimensionar.Text = "Dimensionar Array";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // txtLimInf
            // 
            this.txtLimInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimInf.Location = new System.Drawing.Point(900, 4);
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.Size = new System.Drawing.Size(175, 31);
            this.txtLimInf.TabIndex = 22;
            this.txtLimInf.Text = "-100";
            // 
            // txtLimSup
            // 
            this.txtLimSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimSup.Location = new System.Drawing.Point(900, 63);
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.Size = new System.Drawing.Size(175, 31);
            this.txtLimSup.TabIndex = 21;
            this.txtLimSup.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(644, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Limite Inferior";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(644, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Limite Superior";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(429, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Matriz Transpuesta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Matriz Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(929, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Determinante:";
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.Location = new System.Drawing.Point(986, 475);
            this.lblDet.Name = "lblDet";
            this.lblDet.Size = new System.Drawing.Size(24, 25);
            this.lblDet.TabIndex = 26;
            this.lblDet.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 197);
            this.dataGridView1.TabIndex = 27;
            // 
            // FrmMatrizInversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLimInf);
            this.Controls.Add(this.txtLimSup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDimensionar);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.lblCxF);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.btnInversa);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDeterminante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatrizInversa";
            this.Text = "FrmMatrizInversa";
            this.Load += new System.EventHandler(this.FrmMatrizInversa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeterminante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDeterminante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnInversa;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Label lblCxF;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.TextBox txtLimInf;
        private System.Windows.Forms.TextBox txtLimSup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}