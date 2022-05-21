namespace Bank
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LstResult1 = new System.Windows.Forms.ListBox();
            this.search1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 0;
            // 
            // LstResult1
            // 
            this.LstResult1.FormattingEnabled = true;
            this.LstResult1.Location = new System.Drawing.Point(60, 12);
            this.LstResult1.Name = "LstResult1";
            this.LstResult1.Size = new System.Drawing.Size(620, 121);
            this.LstResult1.TabIndex = 1;
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(432, 168);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(125, 23);
            this.search1.TabIndex = 2;
            this.search1.Text = "search";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(726, 286);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.LstResult1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListBox lstResult;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox LstResult1;
        private System.Windows.Forms.Button search1;
    }
}

