namespace WindowsFormsApplicationGroupDemo
{
    partial class Form3
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
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.Location = new System.Drawing.Point(539, 267);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(588, 232);
            this.btnBacktoMain.TabIndex = 0;
            this.btnBacktoMain.Text = "Back to Main Form";
            this.btnBacktoMain.UseVisualStyleBackColor = true;
            this.btnBacktoMain.Click += new System.EventHandler(this.btnBacktoMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Form 3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacktoMain);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBacktoMain;
        private System.Windows.Forms.Label label1;
    }
}