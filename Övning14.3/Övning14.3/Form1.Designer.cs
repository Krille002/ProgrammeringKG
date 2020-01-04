namespace Övning14._3
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
            this.lblUt = new System.Windows.Forms.Label();
            this.btnVisaRatt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUt
            // 
            this.lblUt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUt.Location = new System.Drawing.Point(12, 9);
            this.lblUt.Name = "lblUt";
            this.lblUt.Size = new System.Drawing.Size(160, 23);
            this.lblUt.TabIndex = 0;
            // 
            // btnVisaRatt
            // 
            this.btnVisaRatt.Location = new System.Drawing.Point(12, 76);
            this.btnVisaRatt.Name = "btnVisaRatt";
            this.btnVisaRatt.Size = new System.Drawing.Size(160, 23);
            this.btnVisaRatt.TabIndex = 1;
            this.btnVisaRatt.Text = "Visa i rättvänd ordning";
            this.btnVisaRatt.UseVisualStyleBackColor = true;
            this.btnVisaRatt.Click += new System.EventHandler(this.BtnVisaRatt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.btnVisaRatt);
            this.Controls.Add(this.lblUt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUt;
        private System.Windows.Forms.Button btnVisaRatt;
    }
}

