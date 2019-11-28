namespace Övning11._4
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
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnVanster = new System.Windows.Forms.Button();
            this.btnHoger = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(250, 12);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(26, 23);
            this.btnUpp.TabIndex = 0;
            this.btnUpp.Text = "U";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // btnVanster
            // 
            this.btnVanster.Location = new System.Drawing.Point(12, 126);
            this.btnVanster.Name = "btnVanster";
            this.btnVanster.Size = new System.Drawing.Size(28, 23);
            this.btnVanster.TabIndex = 1;
            this.btnVanster.Text = "L";
            this.btnVanster.UseVisualStyleBackColor = true;
            this.btnVanster.Click += new System.EventHandler(this.btnVanster_Click);
            // 
            // btnHoger
            // 
            this.btnHoger.Location = new System.Drawing.Point(488, 126);
            this.btnHoger.Name = "btnHoger";
            this.btnHoger.Size = new System.Drawing.Size(27, 23);
            this.btnHoger.TabIndex = 2;
            this.btnHoger.Text = "H";
            this.btnHoger.UseVisualStyleBackColor = true;
            this.btnHoger.Click += new System.EventHandler(this.btnHoger_Click);
            // 
            // btnNer
            // 
            this.btnNer.Location = new System.Drawing.Point(250, 229);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(26, 23);
            this.btnNer.TabIndex = 3;
            this.btnNer.Text = "N";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.btnNer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 264);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnHoger);
            this.Controls.Add(this.btnVanster);
            this.Controls.Add(this.btnUpp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnVanster;
        private System.Windows.Forms.Button btnHoger;
        private System.Windows.Forms.Button btnNer;
    }
}

