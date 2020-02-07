namespace WindowsFormsApplicationGroupDemo
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
            this.btnMain = new System.Windows.Forms.Button();
            this.btnGetForm2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(467, 115);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(1213, 151);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "The Main Button";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnGetForm2
            // 
            this.btnGetForm2.Location = new System.Drawing.Point(467, 351);
            this.btnGetForm2.Name = "btnGetForm2";
            this.btnGetForm2.Size = new System.Drawing.Size(1213, 145);
            this.btnGetForm2.TabIndex = 1;
            this.btnGetForm2.Text = "View Form 2";
            this.btnGetForm2.UseVisualStyleBackColor = true;
            this.btnGetForm2.Click += new System.EventHandler(this.btnGetForm2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGetForm3
            // 
            this.btnGetForm3.Location = new System.Drawing.Point(467, 589);
            this.btnGetForm3.Name = "btnGetForm3";
            this.btnGetForm3.Size = new System.Drawing.Size(1213, 137);
            this.btnGetForm3.TabIndex = 3;
            this.btnGetForm3.Text = "View Form 3";
            this.btnGetForm3.UseVisualStyleBackColor = true;
            this.btnGetForm3.Click += new System.EventHandler(this.btnGetForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2144, 1056);
            this.Controls.Add(this.btnGetForm3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetForm2);
            this.Controls.Add(this.btnMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnGetForm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetForm3;
    }
}

