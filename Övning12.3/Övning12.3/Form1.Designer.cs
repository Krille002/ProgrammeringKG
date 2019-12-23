namespace Övning12._3
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
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.tbxSok = new System.Windows.Forms.TextBox();
            this.btnSortera = new System.Windows.Forms.Button();
            this.btnBinarsok = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerera = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.tbxLista = new System.Windows.Forms.TextBox();
            this.cbxDebug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(141, 51);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxAntal.TabIndex = 0;
            // 
            // tbxSok
            // 
            this.tbxSok.Location = new System.Drawing.Point(141, 108);
            this.tbxSok.Name = "tbxSok";
            this.tbxSok.Size = new System.Drawing.Size(100, 20);
            this.tbxSok.TabIndex = 1;
            // 
            // btnSortera
            // 
            this.btnSortera.Enabled = false;
            this.btnSortera.Location = new System.Drawing.Point(73, 189);
            this.btnSortera.Name = "btnSortera";
            this.btnSortera.Size = new System.Drawing.Size(75, 23);
            this.btnSortera.TabIndex = 2;
            this.btnSortera.Text = "Sortera";
            this.btnSortera.UseVisualStyleBackColor = true;
            this.btnSortera.Click += new System.EventHandler(this.BtnSortera_Click);
            // 
            // btnBinarsok
            // 
            this.btnBinarsok.Enabled = false;
            this.btnBinarsok.Location = new System.Drawing.Point(166, 189);
            this.btnBinarsok.Name = "btnBinarsok";
            this.btnBinarsok.Size = new System.Drawing.Size(75, 23);
            this.btnBinarsok.TabIndex = 3;
            this.btnBinarsok.Text = "Binärsök";
            this.btnBinarsok.UseVisualStyleBackColor = true;
            this.btnBinarsok.Click += new System.EventHandler(this.BtnBinarsok_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(70, 315);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sök";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Antal";
            // 
            // btnGenerera
            // 
            this.btnGenerera.Location = new System.Drawing.Point(302, 49);
            this.btnGenerera.Name = "btnGenerera";
            this.btnGenerera.Size = new System.Drawing.Size(75, 23);
            this.btnGenerera.TabIndex = 7;
            this.btnGenerera.Text = "Generera";
            this.btnGenerera.UseVisualStyleBackColor = true;
            this.btnGenerera.Click += new System.EventHandler(this.BtnGenerera_Click);
            // 
            // btnSok
            // 
            this.btnSok.Enabled = false;
            this.btnSok.Location = new System.Drawing.Point(302, 106);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(75, 23);
            this.btnSok.TabIndex = 8;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // tbxLista
            // 
            this.tbxLista.Location = new System.Drawing.Point(514, 12);
            this.tbxLista.Multiline = true;
            this.tbxLista.Name = "tbxLista";
            this.tbxLista.ReadOnly = true;
            this.tbxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLista.Size = new System.Drawing.Size(168, 417);
            this.tbxLista.TabIndex = 9;
            // 
            // cbxDebug
            // 
            this.cbxDebug.AutoSize = true;
            this.cbxDebug.Location = new System.Drawing.Point(12, 412);
            this.cbxDebug.Name = "cbxDebug";
            this.cbxDebug.Size = new System.Drawing.Size(58, 17);
            this.cbxDebug.TabIndex = 10;
            this.cbxDebug.Text = "Debug";
            this.cbxDebug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(this.cbxDebug);
            this.Controls.Add(this.tbxLista);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.btnGenerera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnBinarsok);
            this.Controls.Add(this.btnSortera);
            this.Controls.Add(this.tbxSok);
            this.Controls.Add(this.tbxAntal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.TextBox tbxSok;
        private System.Windows.Forms.Button btnSortera;
        private System.Windows.Forms.Button btnBinarsok;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerera;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.TextBox tbxLista;
        private System.Windows.Forms.CheckBox cbxDebug;
    }
}

