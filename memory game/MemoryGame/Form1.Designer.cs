namespace MemoryGame
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
            this.components = new System.ComponentModel.Container();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.LabelLast = new System.Windows.Forms.Label();
            this.LastScoreCount = new System.Windows.Forms.Label();
            this.BestScore = new System.Windows.Forms.Label();
            this.BestScoreCouter = new System.Windows.Forms.Label();
            this.Duplicate8 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Duplicate7 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.Duplicate6 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Duplicate5 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Duplicate4 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Duplicate3 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Duplicate2 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Duplicate1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(537, 48);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(80, 25);
            this.ScoreLabel.TabIndex = 16;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.Location = new System.Drawing.Point(608, 48);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(25, 25);
            this.ScoreCounter.TabIndex = 17;
            this.ScoreCounter.Text = "0";
            // 
            // CardPanel
            // 
            this.CardPanel.Controls.Add(this.Duplicate8);
            this.CardPanel.Controls.Add(this.Card8);
            this.CardPanel.Controls.Add(this.Duplicate7);
            this.CardPanel.Controls.Add(this.Card7);
            this.CardPanel.Controls.Add(this.Duplicate6);
            this.CardPanel.Controls.Add(this.Card6);
            this.CardPanel.Controls.Add(this.Duplicate5);
            this.CardPanel.Controls.Add(this.Card5);
            this.CardPanel.Controls.Add(this.Duplicate4);
            this.CardPanel.Controls.Add(this.Card4);
            this.CardPanel.Controls.Add(this.Duplicate3);
            this.CardPanel.Controls.Add(this.Card3);
            this.CardPanel.Controls.Add(this.Duplicate2);
            this.CardPanel.Controls.Add(this.Card2);
            this.CardPanel.Controls.Add(this.Duplicate1);
            this.CardPanel.Controls.Add(this.Card1);
            this.CardPanel.Location = new System.Drawing.Point(0, 4);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(518, 509);
            this.CardPanel.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LabelLast
            // 
            this.LabelLast.AutoSize = true;
            this.LabelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLast.Location = new System.Drawing.Point(537, 118);
            this.LabelLast.Name = "LabelLast";
            this.LabelLast.Size = new System.Drawing.Size(114, 24);
            this.LabelLast.TabIndex = 20;
            this.LabelLast.Text = "Last Score:";
            // 
            // LastScoreCount
            // 
            this.LastScoreCount.AutoSize = true;
            this.LastScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastScoreCount.Location = new System.Drawing.Point(551, 159);
            this.LastScoreCount.Name = "LastScoreCount";
            this.LastScoreCount.Size = new System.Drawing.Size(58, 24);
            this.LastScoreCount.TabIndex = 21;
            this.LastScoreCount.Text = "none";
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScore.Location = new System.Drawing.Point(537, 222);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(117, 24);
            this.BestScore.TabIndex = 22;
            this.BestScore.Text = "Best Score:";
            // 
            // BestScoreCouter
            // 
            this.BestScoreCouter.AutoSize = true;
            this.BestScoreCouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScoreCouter.Location = new System.Drawing.Point(551, 270);
            this.BestScoreCouter.Name = "BestScoreCouter";
            this.BestScoreCouter.Size = new System.Drawing.Size(58, 24);
            this.BestScoreCouter.TabIndex = 23;
            this.BestScoreCouter.Text = "none";
            // 
            // Duplicate8
            // 
            this.Duplicate8.Location = new System.Drawing.Point(387, 380);
            this.Duplicate8.Name = "Duplicate8";
            this.Duplicate8.Size = new System.Drawing.Size(120, 120);
            this.Duplicate8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate8.TabIndex = 31;
            this.Duplicate8.TabStop = false;
            this.Duplicate8.Tag = "8";
            this.Duplicate8.Click += new System.EventHandler(this.Duplicate8_Click);
            // 
            // Card8
            // 
            this.Card8.Location = new System.Drawing.Point(261, 380);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(120, 120);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card8.TabIndex = 30;
            this.Card8.TabStop = false;
            this.Card8.Tag = "8";
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // Duplicate7
            // 
            this.Duplicate7.Location = new System.Drawing.Point(135, 380);
            this.Duplicate7.Name = "Duplicate7";
            this.Duplicate7.Size = new System.Drawing.Size(120, 120);
            this.Duplicate7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate7.TabIndex = 29;
            this.Duplicate7.TabStop = false;
            this.Duplicate7.Tag = "7";
            this.Duplicate7.Click += new System.EventHandler(this.Duplicate7_Click);
            // 
            // Card7
            // 
            this.Card7.Location = new System.Drawing.Point(9, 380);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(120, 120);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card7.TabIndex = 28;
            this.Card7.TabStop = false;
            this.Card7.Tag = "7";
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // Duplicate6
            // 
            this.Duplicate6.Location = new System.Drawing.Point(387, 254);
            this.Duplicate6.Name = "Duplicate6";
            this.Duplicate6.Size = new System.Drawing.Size(120, 120);
            this.Duplicate6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate6.TabIndex = 27;
            this.Duplicate6.TabStop = false;
            this.Duplicate6.Tag = "6";
            this.Duplicate6.Click += new System.EventHandler(this.Duplicate6_Click);
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(261, 254);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(120, 120);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card6.TabIndex = 26;
            this.Card6.TabStop = false;
            this.Card6.Tag = "6";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // Duplicate5
            // 
            this.Duplicate5.Location = new System.Drawing.Point(135, 254);
            this.Duplicate5.Name = "Duplicate5";
            this.Duplicate5.Size = new System.Drawing.Size(120, 120);
            this.Duplicate5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate5.TabIndex = 25;
            this.Duplicate5.TabStop = false;
            this.Duplicate5.Tag = "5";
            this.Duplicate5.Click += new System.EventHandler(this.Duplicate5_Click);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(9, 254);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(120, 120);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card5.TabIndex = 24;
            this.Card5.TabStop = false;
            this.Card5.Tag = "5";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // Duplicate4
            // 
            this.Duplicate4.Location = new System.Drawing.Point(387, 128);
            this.Duplicate4.Name = "Duplicate4";
            this.Duplicate4.Size = new System.Drawing.Size(120, 120);
            this.Duplicate4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate4.TabIndex = 23;
            this.Duplicate4.TabStop = false;
            this.Duplicate4.Tag = "4";
            this.Duplicate4.Click += new System.EventHandler(this.Duplicate4_Click);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(261, 128);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(120, 120);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card4.TabIndex = 22;
            this.Card4.TabStop = false;
            this.Card4.Tag = "4";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // Duplicate3
            // 
            this.Duplicate3.Location = new System.Drawing.Point(135, 128);
            this.Duplicate3.Name = "Duplicate3";
            this.Duplicate3.Size = new System.Drawing.Size(120, 120);
            this.Duplicate3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate3.TabIndex = 21;
            this.Duplicate3.TabStop = false;
            this.Duplicate3.Tag = "3";
            this.Duplicate3.Click += new System.EventHandler(this.Duplicate3_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(9, 128);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(120, 120);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card3.TabIndex = 20;
            this.Card3.TabStop = false;
            this.Card3.Tag = "3";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // Duplicate2
            // 
            this.Duplicate2.Location = new System.Drawing.Point(387, 2);
            this.Duplicate2.Name = "Duplicate2";
            this.Duplicate2.Size = new System.Drawing.Size(120, 120);
            this.Duplicate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate2.TabIndex = 19;
            this.Duplicate2.TabStop = false;
            this.Duplicate2.Tag = "2";
            this.Duplicate2.Click += new System.EventHandler(this.Duplicate2_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(261, 3);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(120, 120);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card2.TabIndex = 18;
            this.Card2.TabStop = false;
            this.Card2.Tag = "2";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Duplicate1
            // 
            this.Duplicate1.Location = new System.Drawing.Point(135, 2);
            this.Duplicate1.Name = "Duplicate1";
            this.Duplicate1.Size = new System.Drawing.Size(120, 120);
            this.Duplicate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Duplicate1.TabIndex = 17;
            this.Duplicate1.TabStop = false;
            this.Duplicate1.Tag = "1";
            this.Duplicate1.Click += new System.EventHandler(this.Duplicate1_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(9, 2);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(120, 120);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Card1.TabIndex = 16;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(552, 459);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(99, 51);
            this.MenuBtn.TabIndex = 24;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 525);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.BestScoreCouter);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.LastScoreCount);
            this.Controls.Add(this.LabelLast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duplicate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.PictureBox Duplicate8;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox Duplicate7;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Duplicate6;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Duplicate5;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Duplicate4;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Duplicate3;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Duplicate2;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Duplicate1;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelLast;
        private System.Windows.Forms.Label LastScoreCount;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.Label BestScoreCouter;
        private System.Windows.Forms.Button MenuBtn;
    }
}

