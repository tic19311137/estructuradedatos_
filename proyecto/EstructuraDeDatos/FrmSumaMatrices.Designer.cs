namespace EstructuraDeDatos
{
    partial class FrmSumaMatrices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtRenglones = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtLimInf = new System.Windows.Forms.TextBox();
            this.txtLimSup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.Location = new System.Drawing.Point(36, 93);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(114, 21);
            this.lblColumnas.TabIndex = 0;
            this.lblColumnas.Text = "Columnas";
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenglones.Location = new System.Drawing.Point(36, 25);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(127, 21);
            this.lblRenglones.TabIndex = 1;
            this.lblRenglones.Text = "Renglones";
            // 
            // txtColumnas
            // 
            this.txtColumnas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColumnas.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.Location = new System.Drawing.Point(185, 90);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(214, 21);
            this.txtColumnas.TabIndex = 2;
            this.txtColumnas.Text = "3";
            // 
            // txtRenglones
            // 
            this.txtRenglones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenglones.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenglones.Location = new System.Drawing.Point(185, 25);
            this.txtRenglones.Name = "txtRenglones";
            this.txtRenglones.Size = new System.Drawing.Size(214, 21);
            this.txtRenglones.TabIndex = 3;
            this.txtRenglones.Text = "7";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(483, 431);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(118, 35);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(296, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(271, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(579, 208);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(273, 150);
            this.dataGridView3.TabIndex = 7;
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(642, 431);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(118, 35);
            this.btnSuma.TabIndex = 8;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Lime;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(442, 52);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(131, 35);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtLimInf
            // 
            this.txtLimInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimInf.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimInf.Location = new System.Drawing.Point(232, 407);
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.Size = new System.Drawing.Size(214, 21);
            this.txtLimInf.TabIndex = 13;
            this.txtLimInf.Text = "-100";
            // 
            // txtLimSup
            // 
            this.txtLimSup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimSup.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimSup.Location = new System.Drawing.Point(232, 474);
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.Size = new System.Drawing.Size(214, 21);
            this.txtLimSup.TabIndex = 12;
            this.txtLimSup.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Limite inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Limite superior";
            // 
            // FrmSumaMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(864, 507);
            this.Controls.Add(this.txtLimInf);
            this.Controls.Add(this.txtLimSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtRenglones);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.lblRenglones);
            this.Controls.Add(this.lblColumnas);
            this.Name = "FrmSumaMatrices";
            this.Text = "FrmSumaMatrices";
            this.Load += new System.EventHandler(this.FrmSumaMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtRenglones;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtLimInf;
        private System.Windows.Forms.TextBox txtLimSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}