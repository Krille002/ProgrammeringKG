namespace Exempel8._1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.btnGissa = new System.Windows.Forms.Button();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSpeldata.SuspendLayout();
            this.gbxSpelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(12, 70);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(210, 70);
            this.gbxSpeldata.TabIndex = 1;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(80, 20);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(90, 30);
            this.lbxStörstaTalet.TabIndex = 0;
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.label1);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Enabled = false;
            this.gbxSpelet.Location = new System.Drawing.Point(12, 146);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(340, 110);
            this.gbxSpelet.TabIndex = 2;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(7, 20);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(61, 13);
            this.lblDator.TabIndex = 0;
            this.lblDator.Text = "Datorns tal:";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(7, 49);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(65, 13);
            this.lblGissa.TabIndex = 1;
            this.lblGissa.Text = "Gissa ett tal:";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(0, 80);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(108, 19);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.AutoSize = true;
            this.lblDatornsTal.Location = new System.Drawing.Point(80, 20);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(35, 13);
            this.lblDatornsTal.TabIndex = 3;
            this.lblDatornsTal.Text = "label1";
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(153, 49);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 4;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.BtnGissa_Click);
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(251, 81);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(75, 23);
            this.btnStartaSpelet.TabIndex = 3;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.BtnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(251, 111);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(75, 23);
            this.btnSpelaIgen.TabIndex = 4;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.BtnSpelaIgen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mina Resultat";
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(79, 49);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(36, 20);
            this.tbxGissa.TabIndex = 6;
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(244, 39);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxSpeldata;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
        private System.Windows.Forms.GroupBox gbxSpelet;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.Label lblDatornsTal;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblGissa;
        private System.Windows.Forms.Label lblDator;
        private System.Windows.Forms.Button btnStartaSpelet;
        private System.Windows.Forms.Button btnSpelaIgen;
    }
}

