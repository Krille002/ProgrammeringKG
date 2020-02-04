namespace Slutprojekt___BlackJack
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.pnlYourCards = new System.Windows.Forms.Panel();
            this.pbxCard1 = new System.Windows.Forms.PictureBox();
            this.pbxCard2 = new System.Windows.Forms.PictureBox();
            this.pbxCard3 = new System.Windows.Forms.PictureBox();
            this.pbxCard4 = new System.Windows.Forms.PictureBox();
            this.pbxCard5 = new System.Windows.Forms.PictureBox();
            this.pbxCard6 = new System.Windows.Forms.PictureBox();
            this.pbxCard7 = new System.Windows.Forms.PictureBox();
            this.pbxCard8 = new System.Windows.Forms.PictureBox();
            this.pbxCard9 = new System.Windows.Forms.PictureBox();
            this.pbxCard10 = new System.Windows.Forms.PictureBox();
            this.pnlDealerDeck = new System.Windows.Forms.Panel();
            this.pbxOpponent1 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent2 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent3 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent4 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent5 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent6 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent7 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent8 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent9 = new System.Windows.Forms.PictureBox();
            this.pbxOpponent10 = new System.Windows.Forms.PictureBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pbxOpponent = new System.Windows.Forms.PictureBox();
            this.pnlAceValue = new System.Windows.Forms.Panel();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEleven = new System.Windows.Forms.Button();
            this.pnlHitStand = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cbxHard = new System.Windows.Forms.CheckBox();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.tbxBet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.pnlYourCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard10)).BeginInit();
            this.pnlDealerDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent10)).BeginInit();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent)).BeginInit();
            this.pnlAceValue.SuspendLayout();
            this.pnlHitStand.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blackjack V1";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(200, 0);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 40);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(0, 0);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(100, 40);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // pnlYourCards
            // 
            this.pnlYourCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlYourCards.Controls.Add(this.pbxCard1);
            this.pnlYourCards.Controls.Add(this.pbxCard2);
            this.pnlYourCards.Controls.Add(this.pbxCard3);
            this.pnlYourCards.Controls.Add(this.pbxCard4);
            this.pnlYourCards.Controls.Add(this.pbxCard5);
            this.pnlYourCards.Controls.Add(this.pbxCard6);
            this.pnlYourCards.Controls.Add(this.pbxCard7);
            this.pnlYourCards.Controls.Add(this.pbxCard8);
            this.pnlYourCards.Controls.Add(this.pbxCard9);
            this.pnlYourCards.Controls.Add(this.pbxCard10);
            this.pnlYourCards.Location = new System.Drawing.Point(168, 460);
            this.pnlYourCards.Name = "pnlYourCards";
            this.pnlYourCards.Size = new System.Drawing.Size(794, 173);
            this.pnlYourCards.TabIndex = 6;
            this.pnlYourCards.Visible = false;
            // 
            // pbxCard1
            // 
            this.pbxCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard1.Location = new System.Drawing.Point(10, 16);
            this.pbxCard1.Name = "pbxCard1";
            this.pbxCard1.Size = new System.Drawing.Size(100, 150);
            this.pbxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard1.TabIndex = 4;
            this.pbxCard1.TabStop = false;
            // 
            // pbxCard2
            // 
            this.pbxCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard2.Location = new System.Drawing.Point(85, 16);
            this.pbxCard2.Name = "pbxCard2";
            this.pbxCard2.Size = new System.Drawing.Size(100, 150);
            this.pbxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard2.TabIndex = 5;
            this.pbxCard2.TabStop = false;
            // 
            // pbxCard3
            // 
            this.pbxCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard3.Location = new System.Drawing.Point(160, 16);
            this.pbxCard3.Name = "pbxCard3";
            this.pbxCard3.Size = new System.Drawing.Size(100, 150);
            this.pbxCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard3.TabIndex = 6;
            this.pbxCard3.TabStop = false;
            // 
            // pbxCard4
            // 
            this.pbxCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard4.Location = new System.Drawing.Point(235, 16);
            this.pbxCard4.Name = "pbxCard4";
            this.pbxCard4.Size = new System.Drawing.Size(100, 150);
            this.pbxCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard4.TabIndex = 7;
            this.pbxCard4.TabStop = false;
            // 
            // pbxCard5
            // 
            this.pbxCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard5.Location = new System.Drawing.Point(310, 16);
            this.pbxCard5.Name = "pbxCard5";
            this.pbxCard5.Size = new System.Drawing.Size(100, 150);
            this.pbxCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard5.TabIndex = 8;
            this.pbxCard5.TabStop = false;
            // 
            // pbxCard6
            // 
            this.pbxCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard6.Location = new System.Drawing.Point(385, 16);
            this.pbxCard6.Name = "pbxCard6";
            this.pbxCard6.Size = new System.Drawing.Size(100, 150);
            this.pbxCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard6.TabIndex = 9;
            this.pbxCard6.TabStop = false;
            // 
            // pbxCard7
            // 
            this.pbxCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard7.Location = new System.Drawing.Point(460, 16);
            this.pbxCard7.Name = "pbxCard7";
            this.pbxCard7.Size = new System.Drawing.Size(100, 150);
            this.pbxCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard7.TabIndex = 10;
            this.pbxCard7.TabStop = false;
            // 
            // pbxCard8
            // 
            this.pbxCard8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard8.Location = new System.Drawing.Point(535, 16);
            this.pbxCard8.Name = "pbxCard8";
            this.pbxCard8.Size = new System.Drawing.Size(100, 150);
            this.pbxCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard8.TabIndex = 11;
            this.pbxCard8.TabStop = false;
            // 
            // pbxCard9
            // 
            this.pbxCard9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard9.Location = new System.Drawing.Point(610, 16);
            this.pbxCard9.Name = "pbxCard9";
            this.pbxCard9.Size = new System.Drawing.Size(100, 150);
            this.pbxCard9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard9.TabIndex = 12;
            this.pbxCard9.TabStop = false;
            // 
            // pbxCard10
            // 
            this.pbxCard10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCard10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCard10.Location = new System.Drawing.Point(685, 16);
            this.pbxCard10.Name = "pbxCard10";
            this.pbxCard10.Size = new System.Drawing.Size(100, 150);
            this.pbxCard10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCard10.TabIndex = 13;
            this.pbxCard10.TabStop = false;
            // 
            // pnlDealerDeck
            // 
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent1);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent2);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent3);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent4);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent5);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent6);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent7);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent8);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent9);
            this.pnlDealerDeck.Controls.Add(this.pbxOpponent10);
            this.pnlDealerDeck.Location = new System.Drawing.Point(36, 109);
            this.pnlDealerDeck.Name = "pnlDealerDeck";
            this.pnlDealerDeck.Size = new System.Drawing.Size(794, 173);
            this.pnlDealerDeck.TabIndex = 7;
            // 
            // pbxOpponent1
            // 
            this.pbxOpponent1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent1.Location = new System.Drawing.Point(10, 16);
            this.pbxOpponent1.Name = "pbxOpponent1";
            this.pbxOpponent1.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent1.TabIndex = 4;
            this.pbxOpponent1.TabStop = false;
            // 
            // pbxOpponent2
            // 
            this.pbxOpponent2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent2.Location = new System.Drawing.Point(85, 16);
            this.pbxOpponent2.Name = "pbxOpponent2";
            this.pbxOpponent2.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent2.TabIndex = 5;
            this.pbxOpponent2.TabStop = false;
            // 
            // pbxOpponent3
            // 
            this.pbxOpponent3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent3.Location = new System.Drawing.Point(160, 16);
            this.pbxOpponent3.Name = "pbxOpponent3";
            this.pbxOpponent3.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent3.TabIndex = 6;
            this.pbxOpponent3.TabStop = false;
            // 
            // pbxOpponent4
            // 
            this.pbxOpponent4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent4.Location = new System.Drawing.Point(235, 16);
            this.pbxOpponent4.Name = "pbxOpponent4";
            this.pbxOpponent4.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent4.TabIndex = 7;
            this.pbxOpponent4.TabStop = false;
            // 
            // pbxOpponent5
            // 
            this.pbxOpponent5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent5.Location = new System.Drawing.Point(310, 16);
            this.pbxOpponent5.Name = "pbxOpponent5";
            this.pbxOpponent5.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent5.TabIndex = 8;
            this.pbxOpponent5.TabStop = false;
            // 
            // pbxOpponent6
            // 
            this.pbxOpponent6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent6.Location = new System.Drawing.Point(385, 16);
            this.pbxOpponent6.Name = "pbxOpponent6";
            this.pbxOpponent6.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent6.TabIndex = 9;
            this.pbxOpponent6.TabStop = false;
            // 
            // pbxOpponent7
            // 
            this.pbxOpponent7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent7.Location = new System.Drawing.Point(460, 16);
            this.pbxOpponent7.Name = "pbxOpponent7";
            this.pbxOpponent7.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent7.TabIndex = 10;
            this.pbxOpponent7.TabStop = false;
            // 
            // pbxOpponent8
            // 
            this.pbxOpponent8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent8.Location = new System.Drawing.Point(535, 16);
            this.pbxOpponent8.Name = "pbxOpponent8";
            this.pbxOpponent8.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent8.TabIndex = 11;
            this.pbxOpponent8.TabStop = false;
            // 
            // pbxOpponent9
            // 
            this.pbxOpponent9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent9.Location = new System.Drawing.Point(610, 16);
            this.pbxOpponent9.Name = "pbxOpponent9";
            this.pbxOpponent9.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent9.TabIndex = 12;
            this.pbxOpponent9.TabStop = false;
            // 
            // pbxOpponent10
            // 
            this.pbxOpponent10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxOpponent10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxOpponent10.Location = new System.Drawing.Point(685, 16);
            this.pbxOpponent10.Name = "pbxOpponent10";
            this.pbxOpponent10.Size = new System.Drawing.Size(100, 150);
            this.pbxOpponent10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent10.TabIndex = 13;
            this.pbxOpponent10.TabStop = false;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(12, 626);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(49, 23);
            this.btnDebug.TabIndex = 8;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.pbxOpponent);
            this.pnlGame.Controls.Add(this.pnlDealerDeck);
            this.pnlGame.Enabled = false;
            this.pnlGame.Location = new System.Drawing.Point(140, 6);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(850, 289);
            this.pnlGame.TabIndex = 9;
            this.pnlGame.Visible = false;
            // 
            // pbxOpponent
            // 
            this.pbxOpponent.Location = new System.Drawing.Point(360, 3);
            this.pbxOpponent.Name = "pbxOpponent";
            this.pbxOpponent.Size = new System.Drawing.Size(100, 100);
            this.pbxOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOpponent.TabIndex = 1;
            this.pbxOpponent.TabStop = false;
            // 
            // pnlAceValue
            // 
            this.pnlAceValue.Controls.Add(this.btnOne);
            this.pnlAceValue.Controls.Add(this.btnEleven);
            this.pnlAceValue.Location = new System.Drawing.Point(400, 380);
            this.pnlAceValue.Name = "pnlAceValue";
            this.pnlAceValue.Size = new System.Drawing.Size(300, 40);
            this.pnlAceValue.TabIndex = 9;
            this.pnlAceValue.Visible = false;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(0, 0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(100, 40);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "One";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnEleven
            // 
            this.btnEleven.Location = new System.Drawing.Point(200, 0);
            this.btnEleven.Name = "btnEleven";
            this.btnEleven.Size = new System.Drawing.Size(100, 40);
            this.btnEleven.TabIndex = 2;
            this.btnEleven.Text = "Eleven";
            this.btnEleven.UseVisualStyleBackColor = true;
            this.btnEleven.Click += new System.EventHandler(this.btnEleven_Click);
            // 
            // pnlHitStand
            // 
            this.pnlHitStand.Controls.Add(this.btnStand);
            this.pnlHitStand.Controls.Add(this.btnHit);
            this.pnlHitStand.Location = new System.Drawing.Point(400, 380);
            this.pnlHitStand.Name = "pnlHitStand";
            this.pnlHitStand.Size = new System.Drawing.Size(300, 40);
            this.pnlHitStand.TabIndex = 8;
            this.pnlHitStand.Visible = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(17, 46);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(49, 23);
            this.btnStartGame.TabIndex = 10;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // cbxHard
            // 
            this.cbxHard.AutoSize = true;
            this.cbxHard.Location = new System.Drawing.Point(17, 75);
            this.cbxHard.Name = "cbxHard";
            this.cbxHard.Size = new System.Drawing.Size(49, 17);
            this.cbxHard.TabIndex = 11;
            this.cbxHard.Text = "Hard";
            this.cbxHard.UseVisualStyleBackColor = true;
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(17, 112);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(61, 20);
            this.tbxUser.TabIndex = 12;
            this.tbxUser.Text = "chrris0223";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "User:";
            // 
            // btnNextRound
            // 
            this.btnNextRound.Location = new System.Drawing.Point(12, 380);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(100, 40);
            this.btnNextRound.TabIndex = 14;
            this.btnNextRound.Text = "Next Round!";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Visible = false;
            this.btnNextRound.Click += new System.EventHandler(this.BtnNextRound_Click);
            // 
            // tbxBet
            // 
            this.tbxBet.Location = new System.Drawing.Point(12, 354);
            this.tbxBet.Name = "tbxBet";
            this.tbxBet.Size = new System.Drawing.Size(100, 20);
            this.tbxBet.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Your Cash:";
            // 
            // lblCash
            // 
            this.lblCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(11, 460);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(117, 23);
            this.lblCash.TabIndex = 17;
            this.lblCash.Text = "$123456789";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(12, 335);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(71, 16);
            this.lblBet.TabIndex = 18;
            this.lblBet.Text = "Your Bet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBet);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.cbxHard);
            this.Controls.Add(this.pnlAceValue);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pnlHitStand);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlYourCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlYourCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCard10)).EndInit();
            this.pnlDealerDeck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent10)).EndInit();
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxOpponent)).EndInit();
            this.pnlAceValue.ResumeLayout(false);
            this.pnlHitStand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxOpponent;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox pbxCard1;
        private System.Windows.Forms.PictureBox pbxCard2;
        private System.Windows.Forms.Panel pnlYourCards;
        private System.Windows.Forms.PictureBox pbxCard3;
        private System.Windows.Forms.PictureBox pbxCard4;
        private System.Windows.Forms.PictureBox pbxCard5;
        private System.Windows.Forms.PictureBox pbxCard6;
        private System.Windows.Forms.PictureBox pbxCard7;
        private System.Windows.Forms.PictureBox pbxCard8;
        private System.Windows.Forms.PictureBox pbxCard9;
        private System.Windows.Forms.PictureBox pbxCard10;
        private System.Windows.Forms.Panel pnlDealerDeck;
        private System.Windows.Forms.PictureBox pbxOpponent1;
        private System.Windows.Forms.PictureBox pbxOpponent2;
        private System.Windows.Forms.PictureBox pbxOpponent3;
        private System.Windows.Forms.PictureBox pbxOpponent4;
        private System.Windows.Forms.PictureBox pbxOpponent5;
        private System.Windows.Forms.PictureBox pbxOpponent6;
        private System.Windows.Forms.PictureBox pbxOpponent7;
        private System.Windows.Forms.PictureBox pbxOpponent8;
        private System.Windows.Forms.PictureBox pbxOpponent9;
        private System.Windows.Forms.PictureBox pbxOpponent10;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlHitStand;
        private System.Windows.Forms.Panel pnlAceValue;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEleven;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.CheckBox cbxHard;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.TextBox tbxBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblBet;
    }
}

