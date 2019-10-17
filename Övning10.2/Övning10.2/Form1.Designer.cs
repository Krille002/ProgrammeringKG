namespace Övning10._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.tbxHojd = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnVlym = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höjd";
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(235, 43);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 2;
            // 
            // tbxHojd
            // 
            this.tbxHojd.Location = new System.Drawing.Point(235, 97);
            this.tbxHojd.Name = "tbxHojd";
            this.tbxHojd.Size = new System.Drawing.Size(100, 20);
            this.tbxHojd.TabIndex = 3;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(232, 153);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(2, 15);
            this.lblSvar.TabIndex = 6;
            // 
            // btnVlym
            // 
            this.btnVlym.Location = new System.Drawing.Point(111, 148);
            this.btnVlym.Name = "btnVlym";
            this.btnVlym.Size = new System.Drawing.Size(75, 23);
            this.btnVlym.TabIndex = 7;
            this.btnVlym.Text = "Volym";
            this.btnVlym.UseVisualStyleBackColor = true;
            this.btnVlym.Click += new System.EventHandler(this.BtnVlym_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 235);
            this.Controls.Add(this.btnVlym);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxHojd);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.TextBox tbxHojd;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnVlym;
    }
}

