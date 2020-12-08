namespace EstructuraDeDatos
{
    partial class FrmTriangularYDeterminante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangularYDeterminante));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDeterminante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtRenglonesyCols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.btnEjemploSup = new System.Windows.Forms.Button();
            this.btnEjemploInferior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCalcular.FlatAppearance.BorderSize = 4;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(254, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 47);
            this.btnCalcular.TabIndex = 42;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDeterminante
            // 
            this.txtDeterminante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeterminante.Location = new System.Drawing.Point(883, 111);
            this.txtDeterminante.Name = "txtDeterminante";
            this.txtDeterminante.Size = new System.Drawing.Size(175, 24);
            this.txtDeterminante.TabIndex = 41;
            this.txtDeterminante.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(653, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Determinante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(128, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Matriz Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(685, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Matriz triangular";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnGenerar.FlatAppearance.BorderSize = 4;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(84, 108);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(139, 47);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtRenglonesyCols
            // 
            this.txtRenglonesyCols.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRenglonesyCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenglonesyCols.Location = new System.Drawing.Point(16, 62);
            this.txtRenglonesyCols.Name = "txtRenglonesyCols";
            this.txtRenglonesyCols.Size = new System.Drawing.Size(255, 24);
            this.txtRenglonesyCols.TabIndex = 36;
            this.txtRenglonesyCols.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Renglones y Columnas";
            // 
            // txtInferior
            // 
            this.txtInferior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInferior.Location = new System.Drawing.Point(883, 62);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(175, 24);
            this.txtInferior.TabIndex = 33;
            this.txtInferior.Text = "-100";
            // 
            // txtSuperior
            // 
            this.txtSuperior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperior.Location = new System.Drawing.Point(883, 17);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(175, 24);
            this.txtSuperior.TabIndex = 32;
            this.txtSuperior.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(653, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Limite Inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(653, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Limite Superior";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(543, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(515, 293);
            this.dataGridView2.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 293);
            this.dataGridView1.TabIndex = 43;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(350, 62);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(270, 21);
            this.lblError.TabIndex = 46;
            this.lblError.Text = "Ingresa solo números";
            this.lblError.Visible = false;
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEjemplo.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnEjemplo.FlatAppearance.BorderSize = 4;
            this.btnEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplo.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo.Location = new System.Drawing.Point(447, 111);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(173, 47);
            this.btnEjemplo.TabIndex = 47;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = false;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // btnEjemploSup
            // 
            this.btnEjemploSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEjemploSup.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnEjemploSup.FlatAppearance.BorderSize = 4;
            this.btnEjemploSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemploSup.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemploSup.Location = new System.Drawing.Point(389, 164);
            this.btnEjemploSup.Name = "btnEjemploSup";
            this.btnEjemploSup.Size = new System.Drawing.Size(249, 47);
            this.btnEjemploSup.TabIndex = 48;
            this.btnEjemploSup.Text = "Ejemplo Superior";
            this.btnEjemploSup.UseVisualStyleBackColor = false;
            this.btnEjemploSup.Click += new System.EventHandler(this.btnEjemploSup_Click);
            // 
            // btnEjemploInferior
            // 
            this.btnEjemploInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEjemploInferior.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnEjemploInferior.FlatAppearance.BorderSize = 4;
            this.btnEjemploInferior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemploInferior.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemploInferior.Location = new System.Drawing.Point(123, 164);
            this.btnEjemploInferior.Name = "btnEjemploInferior";
            this.btnEjemploInferior.Size = new System.Drawing.Size(249, 47);
            this.btnEjemploInferior.TabIndex = 49;
            this.btnEjemploInferior.Text = "Ejemplo Inferior";
            this.btnEjemploInferior.UseVisualStyleBackColor = false;
            this.btnEjemploInferior.Click += new System.EventHandler(this.btnEjemploInferior_Click);
            // 
            // FrmTriangularYDeterminante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1107, 725);
            this.Controls.Add(this.btnEjemploInferior);
            this.Controls.Add(this.btnEjemploSup);
            this.Controls.Add(this.btnEjemplo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDeterminante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtRenglonesyCols);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FrmTriangularYDeterminante";
            this.Text = "FrmTriangularYDeterminante";
            this.Load += new System.EventHandler(this.FrmTriangularYDeterminante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDeterminante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtRenglonesyCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Button btnEjemploSup;
        private System.Windows.Forms.Button btnEjemploInferior;
    }
}