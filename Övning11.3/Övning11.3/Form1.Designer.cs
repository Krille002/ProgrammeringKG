namespace Övning11._2
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
            this.btnRadie = new System.Windows.Forms.Button();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRadie
            // 
            this.btnRadie.Location = new System.Drawing.Point(410, 614);
            this.btnRadie.Name = "btnRadie";
            this.btnRadie.Size = new System.Drawing.Size(75, 23);
            this.btnRadie.TabIndex = 0;
            this.btnRadie.Text = "Sätt Radie";
            this.btnRadie.UseVisualStyleBackColor = true;
            this.btnRadie.Click += new System.EventHandler(this.BtnRadie_Click_1);
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(278, 616);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.btnRadie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadie;
        private System.Windows.Forms.TextBox tbxRadie;
    }
}

