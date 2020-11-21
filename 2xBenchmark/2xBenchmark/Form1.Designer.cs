namespace _2xBenchmark{
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
            this.btnRunBenchmark = new System.Windows.Forms.Button();
            this.txtboxResultBox = new System.Windows.Forms.TextBox();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunBenchmark
            // 
            this.btnRunBenchmark.Location = new System.Drawing.Point(57, 56);
            this.btnRunBenchmark.Name = "btnRunBenchmark";
            this.btnRunBenchmark.Size = new System.Drawing.Size(888, 83);
            this.btnRunBenchmark.TabIndex = 0;
            this.btnRunBenchmark.Text = "Run Benchmark";
            this.btnRunBenchmark.UseVisualStyleBackColor = true;
            this.btnRunBenchmark.Click += new System.EventHandler(this.btnRunBenchmark_Click);
            // 
            // txtboxResultBox
            // 
            this.txtboxResultBox.Location = new System.Drawing.Point(57, 210);
            this.txtboxResultBox.Multiline = true;
            this.txtboxResultBox.Name = "txtboxResultBox";
            this.txtboxResultBox.ReadOnly = true;
            this.txtboxResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxResultBox.Size = new System.Drawing.Size(888, 261);
            this.txtboxResultBox.TabIndex = 1;
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(57, 500);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(211, 60);
            this.btnClearResults.TabIndex = 2;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy All Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.txtboxResultBox);
            this.Controls.Add(this.btnRunBenchmark);
            this.Name = "Form1";
            this.Text = "2x Benchmark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunBenchmark;
        private System.Windows.Forms.TextBox txtboxResultBox;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Button button1;
    }
}

