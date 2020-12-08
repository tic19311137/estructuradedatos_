namespace EstructuraDeDatos
{
    partial class FrmRecursividad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecursividad));
            this.lblLimite = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgLimite = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(12, 60);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(94, 31);
            this.lblLimite.TabIndex = 0;
            this.lblLimite.Text = "Limite:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Lime;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(364, 53);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(151, 44);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgLimite
            // 
            this.dgLimite.AllowUserToAddRows = false;
            this.dgLimite.AllowUserToDeleteRows = false;
            this.dgLimite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLimite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLimite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLimite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLimite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLimite.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLimite.Location = new System.Drawing.Point(71, 132);
            this.dgLimite.Name = "dgLimite";
            this.dgLimite.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLimite.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLimite.RowHeadersWidth = 120;
            this.dgLimite.Size = new System.Drawing.Size(417, 295);
            this.dgLimite.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serie de Fibonacci";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtLimite
            // 
            this.txtLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite.Location = new System.Drawing.Point(127, 60);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(180, 31);
            this.txtLimite.TabIndex = 3;
            this.txtLimite.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(506, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 214);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.dgLimite);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblLimite);
            this.Name = "FrmRecursividad";
            this.Text = "FrmRecursividad";
            this.Load += new System.EventHandler(this.FrmRecursividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgLimite;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}