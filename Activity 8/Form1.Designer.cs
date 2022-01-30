namespace Activity_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumGrams_lbl = new System.Windows.Forms.Label();
            this.NumCarbs_lbl = new System.Windows.Forms.Label();
            this.FatGrams_txt = new System.Windows.Forms.TextBox();
            this.CarbGrams_txt = new System.Windows.Forms.TextBox();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.NumFatCal_lbl = new System.Windows.Forms.Label();
            this.NumCalCarbs_lbl = new System.Windows.Forms.Label();
            this.NumCalFat_txt = new System.Windows.Forms.TextBox();
            this.NumCalCarbs_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumGrams_lbl
            // 
            this.NumGrams_lbl.AutoSize = true;
            this.NumGrams_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumGrams_lbl.Location = new System.Drawing.Point(32, 68);
            this.NumGrams_lbl.Name = "NumGrams_lbl";
            this.NumGrams_lbl.Size = new System.Drawing.Size(331, 29);
            this.NumGrams_lbl.TabIndex = 0;
            this.NumGrams_lbl.Text = "Enter Number of Fat Grams";
            // 
            // NumCarbs_lbl
            // 
            this.NumCarbs_lbl.AutoSize = true;
            this.NumCarbs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCarbs_lbl.Location = new System.Drawing.Point(32, 193);
            this.NumCarbs_lbl.Name = "NumCarbs_lbl";
            this.NumCarbs_lbl.Size = new System.Drawing.Size(696, 44);
            this.NumCarbs_lbl.TabIndex = 1;
            this.NumCarbs_lbl.Text = "Enter Number of Carbohydrates Grams";
            // 
            // FatGrams_txt
            // 
            this.FatGrams_txt.Location = new System.Drawing.Point(536, 68);
            this.FatGrams_txt.Name = "FatGrams_txt";
            this.FatGrams_txt.Size = new System.Drawing.Size(240, 26);
            this.FatGrams_txt.TabIndex = 2;
            // 
            // CarbGrams_txt
            // 
            this.CarbGrams_txt.Location = new System.Drawing.Point(536, 193);
            this.CarbGrams_txt.Name = "CarbGrams_txt";
            this.CarbGrams_txt.Size = new System.Drawing.Size(240, 26);
            this.CarbGrams_txt.TabIndex = 3;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(536, 279);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(240, 34);
            this.Calculate_btn.TabIndex = 4;
            this.Calculate_btn.Text = "Calculate";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // NumFatCal_lbl
            // 
            this.NumFatCal_lbl.AutoSize = true;
            this.NumFatCal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFatCal_lbl.Location = new System.Drawing.Point(32, 382);
            this.NumFatCal_lbl.Name = "NumFatCal_lbl";
            this.NumFatCal_lbl.Size = new System.Drawing.Size(352, 29);
            this.NumFatCal_lbl.TabIndex = 5;
            this.NumFatCal_lbl.Text = "Number of Calories From Fat";
            // 
            // NumCalCarbs_lbl
            // 
            this.NumCalCarbs_lbl.AutoSize = true;
            this.NumCalCarbs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCalCarbs_lbl.Location = new System.Drawing.Point(37, 490);
            this.NumCalCarbs_lbl.Name = "NumCalCarbs_lbl";
            this.NumCalCarbs_lbl.Size = new System.Drawing.Size(485, 29);
            this.NumCalCarbs_lbl.TabIndex = 6;
            this.NumCalCarbs_lbl.Text = "Number of Calories From Carbohydrates";
            // 
            // NumCalFat_txt
            // 
            this.NumCalFat_txt.Location = new System.Drawing.Point(536, 385);
            this.NumCalFat_txt.Name = "NumCalFat_txt";
            this.NumCalFat_txt.Size = new System.Drawing.Size(240, 26);
            this.NumCalFat_txt.TabIndex = 7;
            // 
            // NumCalCarbs_txt
            // 
            this.NumCalCarbs_txt.Location = new System.Drawing.Point(536, 490);
            this.NumCalCarbs_txt.Name = "NumCalCarbs_txt";
            this.NumCalCarbs_txt.Size = new System.Drawing.Size(240, 26);
            this.NumCalCarbs_txt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(844, 546);
            this.Controls.Add(this.NumCalCarbs_txt);
            this.Controls.Add(this.NumCalFat_txt);
            this.Controls.Add(this.NumCalCarbs_lbl);
            this.Controls.Add(this.NumFatCal_lbl);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.CarbGrams_txt);
            this.Controls.Add(this.FatGrams_txt);
            this.Controls.Add(this.NumCarbs_lbl);
            this.Controls.Add(this.NumGrams_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calorie Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumGrams_lbl;
        private System.Windows.Forms.Label NumCarbs_lbl;
        private System.Windows.Forms.TextBox FatGrams_txt;
        private System.Windows.Forms.TextBox CarbGrams_txt;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.Label NumFatCal_lbl;
        private System.Windows.Forms.Label NumCalCarbs_lbl;
        private System.Windows.Forms.TextBox NumCalFat_txt;
        private System.Windows.Forms.TextBox NumCalCarbs_txt;
    }
}

