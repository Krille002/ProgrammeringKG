namespace Övning9._7
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
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxniva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(13, 13);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxOutput.Size = new System.Drawing.Size(572, 195);
            this.txtBxOutput.TabIndex = 0;
            this.txtBxOutput.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbxniva
            // 
            this.txtbxniva.Location = new System.Drawing.Point(659, 109);
            this.txtbxniva.Name = "txtbxniva";
            this.txtbxniva.Size = new System.Drawing.Size(100, 20);
            this.txtbxniva.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nivå";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxniva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbxniva;
        private System.Windows.Forms.Label label1;
    }
}

