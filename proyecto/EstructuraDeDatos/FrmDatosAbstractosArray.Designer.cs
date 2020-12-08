namespace EstructuraDeDatos
{
    partial class FrmDatosAbstractosArray
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblElemento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dgElementos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblColumna = new System.Windows.Forms.Label();
            this.lblRenglon = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgElementos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElemento.Location = new System.Drawing.Point(11, 90);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(212, 31);
            this.lblElemento.TabIndex = 0;
            this.lblElemento.Text = "Elemento [0,0] =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento [0,0] Seleccionado =";
            // 
            // txtElementos
            // 
            this.txtElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElementos.ForeColor = System.Drawing.Color.Red;
            this.txtElementos.Location = new System.Drawing.Point(218, 99);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(219, 35);
            this.txtElementos.TabIndex = 2;
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCapturar.FlatAppearance.BorderSize = 0;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(449, 93);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(166, 59);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "CAPTURAR";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(638, 92);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(150, 60);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // dgElementos
            // 
            this.dgElementos.AllowUserToAddRows = false;
            this.dgElementos.AllowUserToDeleteRows = false;
            this.dgElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgElementos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgElementos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgElementos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgElementos.Location = new System.Drawing.Point(1, 206);
            this.dgElementos.Name = "dgElementos";
            this.dgElementos.ReadOnly = true;
            this.dgElementos.RowHeadersWidth = 135;
            this.dgElementos.Size = new System.Drawing.Size(800, 243);
            this.dgElementos.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Columna 1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Columna 2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Columna 3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblColumna
            // 
            this.lblColumna.AutoSize = true;
            this.lblColumna.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumna.Location = new System.Drawing.Point(144, 70);
            this.lblColumna.Name = "lblColumna";
            this.lblColumna.Size = new System.Drawing.Size(20, 21);
            this.lblColumna.TabIndex = 6;
            this.lblColumna.Text = "C";
            // 
            // lblRenglon
            // 
            this.lblRenglon.AutoSize = true;
            this.lblRenglon.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenglon.Location = new System.Drawing.Point(170, 69);
            this.lblRenglon.Name = "lblRenglon";
            this.lblRenglon.Size = new System.Drawing.Size(20, 21);
            this.lblRenglon.TabIndex = 7;
            this.lblRenglon.Text = "R";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato.ForeColor = System.Drawing.Color.Red;
            this.lblDato.Location = new System.Drawing.Point(21, 129);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(0, 28);
            this.lblDato.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 74);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Captura de matrices";
            // 
            // FrmDatosAbstractosArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblRenglon);
            this.Controls.Add(this.lblColumna);
            this.Controls.Add(this.dgElementos);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElemento);
            this.Name = "FrmDatosAbstractosArray";
            this.Text = "FrmDatosAbstractosArray";
            this.Load += new System.EventHandler(this.FrmDatosAbstractosArray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgElementos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dgElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblColumna;
        private System.Windows.Forms.Label lblRenglon;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}