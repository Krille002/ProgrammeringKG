namespace Uppgift11._1_och_11._2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.rbtnFornamnForst = new System.Windows.Forms.RadioButton();
            this.rbtnEfternamnForst = new System.Windows.Forms.RadioButton();
            this.tbxFornamn = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Efternamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(12, 141);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(472, 225);
            this.lbxLista.TabIndex = 4;
            // 
            // rbtnFornamnForst
            // 
            this.rbtnFornamnForst.AutoSize = true;
            this.rbtnFornamnForst.Location = new System.Drawing.Point(36, 372);
            this.rbtnFornamnForst.Name = "rbtnFornamnForst";
            this.rbtnFornamnForst.Size = new System.Drawing.Size(85, 17);
            this.rbtnFornamnForst.TabIndex = 5;
            this.rbtnFornamnForst.TabStop = true;
            this.rbtnFornamnForst.Text = "radioButton1";
            this.rbtnFornamnForst.UseVisualStyleBackColor = true;
            // 
            // rbtnEfternamnForst
            // 
            this.rbtnEfternamnForst.AutoSize = true;
            this.rbtnEfternamnForst.Location = new System.Drawing.Point(188, 372);
            this.rbtnEfternamnForst.Name = "rbtnEfternamnForst";
            this.rbtnEfternamnForst.Size = new System.Drawing.Size(85, 17);
            this.rbtnEfternamnForst.TabIndex = 6;
            this.rbtnEfternamnForst.TabStop = true;
            this.rbtnEfternamnForst.Text = "radioButton2";
            this.rbtnEfternamnForst.UseVisualStyleBackColor = true;
            // 
            // tbxFornamn
            // 
            this.tbxFornamn.Location = new System.Drawing.Point(87, 27);
            this.tbxFornamn.Name = "tbxFornamn";
            this.tbxFornamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFornamn.TabIndex = 7;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(87, 70);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefon.TabIndex = 8;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(308, 27);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 20);
            this.tbxEfternamn.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxFornamn);
            this.Controls.Add(this.rbtnEfternamnForst);
            this.Controls.Add(this.rbtnFornamnForst);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.RadioButton rbtnFornamnForst;
        private System.Windows.Forms.RadioButton rbtnEfternamnForst;
        private System.Windows.Forms.TextBox tbxFornamn;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.Button button1;
    }
}

