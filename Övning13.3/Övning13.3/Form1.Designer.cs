namespace Övning13._3
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
            this.btnNyKund = new System.Windows.Forms.Button();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.lblUt = new System.Windows.Forms.Label();
            this.btnExpediera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // btnNyKund
            // 
            this.btnNyKund.Location = new System.Drawing.Point(12, 106);
            this.btnNyKund.Name = "btnNyKund";
            this.btnNyKund.Size = new System.Drawing.Size(102, 23);
            this.btnNyKund.TabIndex = 1;
            this.btnNyKund.Text = "Ny Kund";
            this.btnNyKund.UseVisualStyleBackColor = true;
            this.btnNyKund.Click += new System.EventHandler(this.BtnNyKund_Click);
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(56, 22);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(173, 20);
            this.tbxNamn.TabIndex = 2;
            // 
            // lblUt
            // 
            this.lblUt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUt.Location = new System.Drawing.Point(15, 61);
            this.lblUt.Name = "lblUt";
            this.lblUt.Size = new System.Drawing.Size(214, 23);
            this.lblUt.TabIndex = 3;
            // 
            // btnExpediera
            // 
            this.btnExpediera.Location = new System.Drawing.Point(127, 106);
            this.btnExpediera.Name = "btnExpediera";
            this.btnExpediera.Size = new System.Drawing.Size(102, 23);
            this.btnExpediera.TabIndex = 4;
            this.btnExpediera.Text = "Expediera Kund";
            this.btnExpediera.UseVisualStyleBackColor = true;
            this.btnExpediera.Click += new System.EventHandler(this.BtnExpediera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 145);
            this.Controls.Add(this.btnExpediera);
            this.Controls.Add(this.lblUt);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.btnNyKund);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNyKund;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label lblUt;
        private System.Windows.Forms.Button btnExpediera;
    }
}

