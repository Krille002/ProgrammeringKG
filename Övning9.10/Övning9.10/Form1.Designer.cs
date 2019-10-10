namespace Övning9._10
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxRad1 = new System.Windows.Forms.TextBox();
            this.tbxRad2 = new System.Windows.Forms.TextBox();
            this.tbxRad3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerera = new System.Windows.Forms.Button();
            this.lbxMeny = new System.Windows.Forms.ListBox();
            this.tbxVal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnValj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Styrka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Smidighet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hälsa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelligens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Viljestyrka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Karisma";
            // 
            // tbxRad1
            // 
            this.tbxRad1.Location = new System.Drawing.Point(115, 53);
            this.tbxRad1.Multiline = true;
            this.tbxRad1.Name = "tbxRad1";
            this.tbxRad1.Size = new System.Drawing.Size(37, 94);
            this.tbxRad1.TabIndex = 6;
            // 
            // tbxRad2
            // 
            this.tbxRad2.Location = new System.Drawing.Point(171, 53);
            this.tbxRad2.Multiline = true;
            this.tbxRad2.Name = "tbxRad2";
            this.tbxRad2.Size = new System.Drawing.Size(37, 94);
            this.tbxRad2.TabIndex = 7;
            // 
            // tbxRad3
            // 
            this.tbxRad3.Location = new System.Drawing.Point(227, 53);
            this.tbxRad3.Multiline = true;
            this.tbxRad3.Name = "tbxRad3";
            this.tbxRad3.Size = new System.Drawing.Size(37, 94);
            this.tbxRad3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rad 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Rad 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rad 3";
            // 
            // btnGenerera
            // 
            this.btnGenerera.Location = new System.Drawing.Point(115, 165);
            this.btnGenerera.Name = "btnGenerera";
            this.btnGenerera.Size = new System.Drawing.Size(149, 23);
            this.btnGenerera.TabIndex = 12;
            this.btnGenerera.Text = "Generera";
            this.btnGenerera.UseVisualStyleBackColor = true;
            this.btnGenerera.Click += new System.EventHandler(this.BtnGenerera_Click);
            // 
            // lbxMeny
            // 
            this.lbxMeny.FormattingEnabled = true;
            this.lbxMeny.Items.AddRange(new object[] {
            "Rad 1",
            "Rad 2",
            "Rad 3"});
            this.lbxMeny.Location = new System.Drawing.Point(284, 104);
            this.lbxMeny.Name = "lbxMeny";
            this.lbxMeny.Size = new System.Drawing.Size(48, 43);
            this.lbxMeny.TabIndex = 13;
            this.lbxMeny.SelectedIndexChanged += new System.EventHandler(this.LbxMeny_SelectedIndexChanged);
            // 
            // tbxVal
            // 
            this.tbxVal.Location = new System.Drawing.Point(355, 53);
            this.tbxVal.Multiline = true;
            this.tbxVal.Name = "tbxVal";
            this.tbxVal.Size = new System.Drawing.Size(37, 135);
            this.tbxVal.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Val";
            // 
            // btnValj
            // 
            this.btnValj.Location = new System.Drawing.Point(284, 165);
            this.btnValj.Name = "btnValj";
            this.btnValj.Size = new System.Drawing.Size(48, 23);
            this.btnValj.TabIndex = 17;
            this.btnValj.Text = "Välj";
            this.btnValj.UseVisualStyleBackColor = true;
            this.btnValj.Click += new System.EventHandler(this.BtnValj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 224);
            this.Controls.Add(this.btnValj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxVal);
            this.Controls.Add(this.lbxMeny);
            this.Controls.Add(this.btnGenerera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxRad3);
            this.Controls.Add(this.tbxRad2);
            this.Controls.Add(this.tbxRad1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxRad1;
        private System.Windows.Forms.TextBox tbxRad2;
        private System.Windows.Forms.TextBox tbxRad3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerera;
        private System.Windows.Forms.ListBox lbxMeny;
        private System.Windows.Forms.TextBox tbxVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnValj;
    }
}

