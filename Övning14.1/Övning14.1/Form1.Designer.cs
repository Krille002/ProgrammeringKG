namespace Övning14._1
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
            this.btnFakultet = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal:";
            // 
            // btnFakultet
            // 
            this.btnFakultet.Location = new System.Drawing.Point(60, 102);
            this.btnFakultet.Name = "btnFakultet";
            this.btnFakultet.Size = new System.Drawing.Size(80, 23);
            this.btnFakultet.TabIndex = 1;
            this.btnFakultet.Text = "Fakultet";
            this.btnFakultet.UseVisualStyleBackColor = true;
            this.btnFakultet.Click += new System.EventHandler(this.BtnFakultet_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(12, 60);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(159, 23);
            this.lblSvar.TabIndex = 2;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(43, 23);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(128, 20);
            this.tbxInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnFakultet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFakultet;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxInput;
    }
}

