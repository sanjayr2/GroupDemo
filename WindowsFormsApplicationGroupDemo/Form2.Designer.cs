namespace WindowsFormsApplicationGroupDemo
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
            this.btnGoBacktoMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBacktoMain
            // 
            this.btnGoBacktoMain.Location = new System.Drawing.Point(439, 248);
            this.btnGoBacktoMain.Name = "btnGoBacktoMain";
            this.btnGoBacktoMain.Size = new System.Drawing.Size(790, 303);
            this.btnGoBacktoMain.TabIndex = 0;
            this.btnGoBacktoMain.Text = "Go Back to Main Form";
            this.btnGoBacktoMain.UseVisualStyleBackColor = true;
            this.btnGoBacktoMain.Click += new System.EventHandler(this.btnGoBacktoMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello I\'m Form 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoBacktoMain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBacktoMain;
        private System.Windows.Forms.Label label1;
    }
}