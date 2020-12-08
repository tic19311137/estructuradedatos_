namespace EstructuraDeDatos
{
    partial class FrmTriangular
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtRenglones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(888, 53);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(100, 20);
            this.txtInferior.TabIndex = 19;
            this.txtInferior.Text = "-100";
            // 
            // txtSuperior
            // 
            this.txtSuperior.Location = new System.Drawing.Point(888, 12);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(100, 20);
            this.txtSuperior.TabIndex = 18;
            this.txtSuperior.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Limite Inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Limite Superior";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(496, 18);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(139, 47);
            this.btnRandom.TabIndex = 20;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(328, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(139, 47);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtRenglones
            // 
            this.txtRenglones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenglones.Location = new System.Drawing.Point(52, 60);
            this.txtRenglones.Name = "txtRenglones";
            this.txtRenglones.Size = new System.Drawing.Size(158, 31);
            this.txtRenglones.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Renglones y Columnas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(543, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(515, 293);
            this.dataGridView2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Matriz triangular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matriz Original";
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.Location = new System.Drawing.Point(888, 91);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(100, 20);
            this.txtDeterminante.TabIndex = 28;
            this.txtDeterminante.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Determinante";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(372, 103);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 47);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmTriangular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 498);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDeterminante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtRenglones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTriangular";
            this.Text = "FrmTriangular";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtRenglones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
    }
}