namespace Uppgift13._2
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
            this.tbxFoljd = new System.Windows.Forms.TextBox();
            this.lblUt = new System.Windows.Forms.Label();
            this.btnKontrollera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parantesföljd:";
            // 
            // tbxFoljd
            // 
            this.tbxFoljd.Location = new System.Drawing.Point(89, 22);
            this.tbxFoljd.Name = "tbxFoljd";
            this.tbxFoljd.Size = new System.Drawing.Size(132, 20);
            this.tbxFoljd.TabIndex = 1;
            // 
            // lblUt
            // 
            this.lblUt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUt.Location = new System.Drawing.Point(12, 63);
            this.lblUt.Name = "lblUt";
            this.lblUt.Size = new System.Drawing.Size(209, 23);
            this.lblUt.TabIndex = 2;
            // 
            // btnKontrollera
            // 
            this.btnKontrollera.Location = new System.Drawing.Point(80, 94);
            this.btnKontrollera.Name = "btnKontrollera";
            this.btnKontrollera.Size = new System.Drawing.Size(75, 23);
            this.btnKontrollera.TabIndex = 3;
            this.btnKontrollera.Text = "Kontrollera";
            this.btnKontrollera.UseVisualStyleBackColor = true;
            this.btnKontrollera.Click += new System.EventHandler(this.BtnKontrollera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 129);
            this.Controls.Add(this.btnKontrollera);
            this.Controls.Add(this.lblUt);
            this.Controls.Add(this.tbxFoljd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFoljd;
        private System.Windows.Forms.Label lblUt;
        private System.Windows.Forms.Button btnKontrollera;
    }
}

