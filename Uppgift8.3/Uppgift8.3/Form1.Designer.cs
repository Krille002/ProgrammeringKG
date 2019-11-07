namespace Uppgift8._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPase = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnSpela = new System.Windows.Forms.Button();
            this.gbxStenSaxPåse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            this.gbxMinaResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.label2);
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.label1);
            this.gbxStenSaxPåse.Controls.Add(this.pbxPase);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Enabled = false;
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(28, 35);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(650, 254);
            this.gbxStenSaxPåse.TabIndex = 0;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten, sax eller påse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Välj sten, sax eller påse genom att klicka på en bild";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(27, 209);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(385, 21);
            this.lblResultat.TabIndex = 5;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Location = new System.Drawing.Point(121, 170);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(52, 23);
            this.lblDatornsVal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datorn valde:";
            // 
            // pbxPase
            // 
            this.pbxPase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPase.BackgroundImage")));
            this.pbxPase.Location = new System.Drawing.Point(342, 73);
            this.pbxPase.Name = "pbxPase";
            this.pbxPase.Size = new System.Drawing.Size(70, 70);
            this.pbxPase.TabIndex = 2;
            this.pbxPase.TabStop = false;
            this.pbxPase.Click += new System.EventHandler(this.pbxPase_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSax.BackgroundImage")));
            this.pbxSax.Location = new System.Drawing.Point(183, 73);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(70, 70);
            this.pbxSax.TabIndex = 1;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxSten
            // 
            this.pbxSten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSten.BackgroundImage")));
            this.pbxSten.Location = new System.Drawing.Point(27, 73);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(70, 70);
            this.pbxSten.TabIndex = 0;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Enabled = false;
            this.gbxMinaResultat.Location = new System.Drawing.Point(724, 108);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(227, 181);
            this.gbxMinaResultat.TabIndex = 1;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina Resultat";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMinaResultat.Location = new System.Drawing.Point(3, 16);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ReadOnly = true;
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(221, 162);
            this.tbxMinaResultat.TabIndex = 0;
            // 
            // btnSpela
            // 
            this.btnSpela.Location = new System.Drawing.Point(727, 48);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(221, 23);
            this.btnSpela.TabIndex = 2;
            this.btnSpela.Text = "Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 310);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornsVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxPase;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpela;
    }
}

