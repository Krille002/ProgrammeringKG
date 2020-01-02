namespace Övning13._2
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
            this.tbxOrd = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKontrollera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ord:";
            // 
            // tbxOrd
            // 
            this.tbxOrd.Location = new System.Drawing.Point(45, 40);
            this.tbxOrd.Name = "tbxOrd";
            this.tbxOrd.Size = new System.Drawing.Size(168, 20);
            this.tbxOrd.TabIndex = 1;
            // 
            // lblSvar
            // 
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(15, 77);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(198, 23);
            this.lblSvar.TabIndex = 2;
            // 
            // btnKontrollera
            // 
            this.btnKontrollera.Location = new System.Drawing.Point(72, 117);
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
            this.ClientSize = new System.Drawing.Size(225, 152);
            this.Controls.Add(this.btnKontrollera);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxOrd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOrd;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKontrollera;
    }
}

