namespace Övning14._2
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnHarmonisktTal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nummer:";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(69, 24);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(203, 20);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.TextChanged += new System.EventHandler(this.TbxInput_TextChanged);
            // 
            // lblSvar
            // 
            this.lblSvar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSvar.Location = new System.Drawing.Point(16, 61);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(256, 20);
            this.lblSvar.TabIndex = 2;
            // 
            // btnHarmonisktTal
            // 
            this.btnHarmonisktTal.Location = new System.Drawing.Point(100, 106);
            this.btnHarmonisktTal.Name = "btnHarmonisktTal";
            this.btnHarmonisktTal.Size = new System.Drawing.Size(100, 23);
            this.btnHarmonisktTal.TabIndex = 3;
            this.btnHarmonisktTal.Text = "Harmoniskt Tal";
            this.btnHarmonisktTal.UseVisualStyleBackColor = true;
            this.btnHarmonisktTal.Click += new System.EventHandler(this.BtnHarmonisktTal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnHarmonisktTal);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnHarmonisktTal;
    }
}

