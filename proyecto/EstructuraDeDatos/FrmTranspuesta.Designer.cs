namespace EstructuraDeDatos
{
    partial class FrmTranspuesta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTranspuesta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRenglones = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "M^T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "M=";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 169);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(109, 350);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(354, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRandom.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(620, 197);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(139, 47);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTranspuesta
            // 
            this.btnTranspuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTranspuesta.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranspuesta.Location = new System.Drawing.Point(597, 392);
            this.btnTranspuesta.Name = "btnTranspuesta";
            this.btnTranspuesta.Size = new System.Drawing.Size(174, 49);
            this.btnTranspuesta.TabIndex = 5;
            this.btnTranspuesta.Text = "Transpuesta";
            this.btnTranspuesta.UseVisualStyleBackColor = false;
            this.btnTranspuesta.Click += new System.EventHandler(this.btnTranspuesta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renglones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtRenglones
            // 
            this.txtRenglones.Location = new System.Drawing.Point(205, 23);
            this.txtRenglones.Name = "txtRenglones";
            this.txtRenglones.Size = new System.Drawing.Size(100, 20);
            this.txtRenglones.TabIndex = 8;
            this.txtRenglones.TextChanged += new System.EventHandler(this.txtRenglones_TextChanged);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(205, 64);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 20);
            this.txtColumnas.TabIndex = 10;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Lime;
            this.btnGenerar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(369, 35);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(139, 47);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(761, 149);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(100, 20);
            this.txtInferior.TabIndex = 15;
            this.txtInferior.Text = "-100";
            // 
            // txtSuperior
            // 
            this.txtSuperior.Location = new System.Drawing.Point(761, 108);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(100, 20);
            this.txtSuperior.TabIndex = 14;
            this.txtSuperior.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Limite Inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Limite Superior";
            // 
            // FrmTranspuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(874, 512);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtRenglones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTranspuesta);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTranspuesta";
            this.Text = "FrmTranspuesta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTranspuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRenglones;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}