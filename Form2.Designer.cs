namespace SIMULACION_EXAMEN_PARCIAL
{
    partial class Form2
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
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(106, 300);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(140, 42);
            this.buttonVer.TabIndex = 1;
            this.buttonVer.Text = "Mostrar Registros";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(263, 300);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(140, 42);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "---";
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(428, 300);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(140, 42);
            this.buttonPromedio.TabIndex = 4;
            this.buttonPromedio.Text = "PROMEDIO ";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROMEDIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(749, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temp. Minima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(750, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temp. Maxima:";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(750, 58);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(16, 13);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "---";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(751, 142);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(16, 13);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "---";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
    }
}