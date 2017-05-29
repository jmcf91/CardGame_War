namespace CardGame_War
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
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblPlayer1Deck = new System.Windows.Forms.Label();
            this.lblPlayer2Deck = new System.Windows.Forms.Label();
            this.lstPlayer1Cards = new System.Windows.Forms.ListView();
            this.lstPlayer2Cards = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblP1Card = new System.Windows.Forms.Label();
            this.lblP2Card = new System.Windows.Forms.Label();
            this.lstWarCards = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(39, 34);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(96, 46);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblPlayer1Deck
            // 
            this.lblPlayer1Deck.AutoSize = true;
            this.lblPlayer1Deck.Location = new System.Drawing.Point(393, 22);
            this.lblPlayer1Deck.Name = "lblPlayer1Deck";
            this.lblPlayer1Deck.Size = new System.Drawing.Size(84, 13);
            this.lblPlayer1Deck.TabIndex = 1;
            this.lblPlayer1Deck.Text = "Player 1\'s Deck:";
            // 
            // lblPlayer2Deck
            // 
            this.lblPlayer2Deck.AutoSize = true;
            this.lblPlayer2Deck.Location = new System.Drawing.Point(393, 275);
            this.lblPlayer2Deck.Name = "lblPlayer2Deck";
            this.lblPlayer2Deck.Size = new System.Drawing.Size(84, 13);
            this.lblPlayer2Deck.TabIndex = 2;
            this.lblPlayer2Deck.Text = "Player 2\'s Deck:";
            // 
            // lstPlayer1Cards
            // 
            this.lstPlayer1Cards.Location = new System.Drawing.Point(259, 38);
            this.lstPlayer1Cards.Name = "lstPlayer1Cards";
            this.lstPlayer1Cards.Size = new System.Drawing.Size(355, 116);
            this.lstPlayer1Cards.TabIndex = 4;
            this.lstPlayer1Cards.UseCompatibleStateImageBehavior = false;
            // 
            // lstPlayer2Cards
            // 
            this.lstPlayer2Cards.Location = new System.Drawing.Point(259, 291);
            this.lstPlayer2Cards.Name = "lstPlayer2Cards";
            this.lstPlayer2Cards.Size = new System.Drawing.Size(355, 116);
            this.lstPlayer2Cards.TabIndex = 5;
            this.lstPlayer2Cards.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player 1 Score:";
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Location = new System.Drawing.Point(652, 304);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(13, 13);
            this.lblP2Score.TabIndex = 7;
            this.lblP2Score.Text = "0";
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Location = new System.Drawing.Point(652, 51);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(13, 13);
            this.lblP1Score.TabIndex = 8;
            this.lblP1Score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 2 Score:";
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(681, 177);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(96, 46);
            this.btnBattle.TabIndex = 10;
            this.btnBattle.Text = "Battle!";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "C - Clubs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "D - Diamonds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "H - Hearts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "S - Spades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Player 1 Card:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Player 2 Card:";
            // 
            // lblP1Card
            // 
            this.lblP1Card.AutoSize = true;
            this.lblP1Card.Location = new System.Drawing.Point(328, 208);
            this.lblP1Card.Name = "lblP1Card";
            this.lblP1Card.Size = new System.Drawing.Size(13, 13);
            this.lblP1Card.TabIndex = 14;
            this.lblP1Card.Text = "0";
            // 
            // lblP2Card
            // 
            this.lblP2Card.AutoSize = true;
            this.lblP2Card.Location = new System.Drawing.Point(551, 208);
            this.lblP2Card.Name = "lblP2Card";
            this.lblP2Card.Size = new System.Drawing.Size(13, 13);
            this.lblP2Card.TabIndex = 15;
            this.lblP2Card.Text = "0";
            // 
            // lstWarCards
            // 
            this.lstWarCards.FormattingEnabled = true;
            this.lstWarCards.Location = new System.Drawing.Point(39, 172);
            this.lstWarCards.Name = "lstWarCards";
            this.lstWarCards.Size = new System.Drawing.Size(120, 95);
            this.lstWarCards.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "War Cards:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(393, 208);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 419);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstWarCards);
            this.Controls.Add(this.lblP2Card);
            this.Controls.Add(this.lblP1Card);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblP1Score);
            this.Controls.Add(this.lblP2Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPlayer2Cards);
            this.Controls.Add(this.lstPlayer1Cards);
            this.Controls.Add(this.lblPlayer2Deck);
            this.Controls.Add(this.lblPlayer1Deck);
            this.Controls.Add(this.btnDeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblPlayer1Deck;
        private System.Windows.Forms.Label lblPlayer2Deck;
        private System.Windows.Forms.ListView lstPlayer1Cards;
        private System.Windows.Forms.ListView lstPlayer2Cards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblP1Card;
        private System.Windows.Forms.Label lblP2Card;
        private System.Windows.Forms.ListBox lstWarCards;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblWinner;
    }
}

