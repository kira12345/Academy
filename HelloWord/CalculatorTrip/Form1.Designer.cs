namespace CalculatorTrip
{
    partial class Calculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayKm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numericUpDown1Starting = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Ending = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Starting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Ending)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(180, 179);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(23, 28);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(92, 20);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Starting Km";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ending Km";
            // 
            // btnDisplayKm
            // 
            this.btnDisplayKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayKm.Location = new System.Drawing.Point(302, 179);
            this.btnDisplayKm.Name = "btnDisplayKm";
            this.btnDisplayKm.Size = new System.Drawing.Size(131, 30);
            this.btnDisplayKm.TabIndex = 5;
            this.btnDisplayKm.Text = "Display Km";
            this.btnDisplayKm.UseVisualStyleBackColor = true;
            this.btnDisplayKm.Click += new System.EventHandler(this.btnDisplayKm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount Owed";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(146, 117);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 20);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "$0.0";
            // 
            // numericUpDown1Starting
            // 
            this.numericUpDown1Starting.Location = new System.Drawing.Point(150, 28);
            this.numericUpDown1Starting.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1Starting.Name = "numericUpDown1Starting";
            this.numericUpDown1Starting.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown1Starting.TabIndex = 8;
            // 
            // numericUpDown2Ending
            // 
            this.numericUpDown2Ending.Location = new System.Drawing.Point(150, 74);
            this.numericUpDown2Ending.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown2Ending.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2Ending.Name = "numericUpDown2Ending";
            this.numericUpDown2Ending.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown2Ending.TabIndex = 9;
            this.numericUpDown2Ending.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Option travel:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown2Ending);
            this.Controls.Add(this.numericUpDown1Starting);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplayKm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorTrip";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Starting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Ending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1Starting;
        private System.Windows.Forms.NumericUpDown numericUpDown2Ending;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

