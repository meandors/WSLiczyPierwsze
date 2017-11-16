namespace ClientAsync
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
            this.tbBottomRange = new System.Windows.Forms.TextBox();
            this.tbTopRange = new System.Windows.Forms.TextBox();
            this.GetPrimeAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBottomRange
            // 
            this.tbBottomRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBottomRange.Location = new System.Drawing.Point(192, 47);
            this.tbBottomRange.Name = "tbBottomRange";
            this.tbBottomRange.Size = new System.Drawing.Size(60, 23);
            this.tbBottomRange.TabIndex = 0;
            this.tbBottomRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTopRange
            // 
            this.tbTopRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTopRange.Location = new System.Drawing.Point(192, 75);
            this.tbTopRange.Name = "tbTopRange";
            this.tbTopRange.Size = new System.Drawing.Size(60, 23);
            this.tbTopRange.TabIndex = 1;
            this.tbTopRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GetPrimeAsync
            // 
            this.GetPrimeAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetPrimeAsync.Location = new System.Drawing.Point(64, 132);
            this.GetPrimeAsync.Name = "GetPrimeAsync";
            this.GetPrimeAsync.Size = new System.Drawing.Size(173, 72);
            this.GetPrimeAsync.TabIndex = 2;
            this.GetPrimeAsync.Text = "Get Prime Numbers";
            this.GetPrimeAsync.UseVisualStyleBackColor = true;
            this.GetPrimeAsync.Click += new System.EventHandler(this.GetPrimeAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dolny zakres przedzialu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Górny zakres przedziału:";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(321, 47);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(287, 157);
            this.rtbResult.TabIndex = 5;
            this.rtbResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(318, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liczby pierwsze:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetPrimeAsync);
            this.Controls.Add(this.tbTopRange);
            this.Controls.Add(this.tbBottomRange);
            this.Name = "Form1";
            this.Text = "Client Async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBottomRange;
        private System.Windows.Forms.TextBox tbTopRange;
        private System.Windows.Forms.Button GetPrimeAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label3;
    }
}

