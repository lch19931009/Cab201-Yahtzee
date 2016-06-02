namespace Yahtzee_Game {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCheckBoxinstruction = new System.Windows.Forms.Label();
            this.lblLowerSection = new System.Windows.Forms.Label();
            this.lblUpperSection = new System.Windows.Forms.Label();
            this.lblGrandTotalScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblLowerTotal = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblYahtzeeTotal = new System.Windows.Forms.Label();
            this.lblBonus63 = new System.Windows.Forms.Label();
            this.lblUpperTotal = new System.Windows.Forms.Label();
            this.musGame = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayersDGV = new System.Windows.Forms.Label();
            this.lblNoPlayerNUD = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.nudNumPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblYahtzee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.musGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.lblCheckBoxinstruction);
            this.splitContainer1.Panel1.Controls.Add(this.lblLowerSection);
            this.splitContainer1.Panel1.Controls.Add(this.lblUpperSection);
            this.splitContainer1.Panel1.Controls.Add(this.lblGrandTotalScore);
            this.splitContainer1.Panel1.Controls.Add(this.lblPlayer);
            this.splitContainer1.Panel1.Controls.Add(this.lblMessage);
            this.splitContainer1.Panel1.Controls.Add(this.btnOK);
            this.splitContainer1.Panel1.Controls.Add(this.lblGrandTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblSubTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblLowerTotal);
            this.splitContainer1.Panel1.Controls.Add(this.btnRollDice);
            this.splitContainer1.Panel1.Controls.Add(this.lblYahtzeeTotal);
            this.splitContainer1.Panel1.Controls.Add(this.lblBonus63);
            this.splitContainer1.Panel1.Controls.Add(this.lblUpperTotal);
            this.splitContainer1.Panel1.Controls.Add(this.musGame);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.lblPlayersDGV);
            this.splitContainer1.Panel2.Controls.Add(this.lblNoPlayerNUD);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.nudNumPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.lblYahtzee);
            this.splitContainer1.Size = new System.Drawing.Size(711, 664);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblCheckBoxinstruction
            // 
            this.lblCheckBoxinstruction.AutoSize = true;
            this.lblCheckBoxinstruction.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckBoxinstruction.Location = new System.Drawing.Point(339, 116);
            this.lblCheckBoxinstruction.Name = "lblCheckBoxinstruction";
            this.lblCheckBoxinstruction.Size = new System.Drawing.Size(132, 14);
            this.lblCheckBoxinstruction.TabIndex = 13;
            this.lblCheckBoxinstruction.Text = "Check box to hold value";
            // 
            // lblLowerSection
            // 
            this.lblLowerSection.AutoSize = true;
            this.lblLowerSection.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerSection.Location = new System.Drawing.Point(251, 215);
            this.lblLowerSection.Name = "lblLowerSection";
            this.lblLowerSection.Size = new System.Drawing.Size(181, 33);
            this.lblLowerSection.TabIndex = 12;
            this.lblLowerSection.Text = "Lower Section";
            // 
            // lblUpperSection
            // 
            this.lblUpperSection.AutoSize = true;
            this.lblUpperSection.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperSection.Location = new System.Drawing.Point(12, 215);
            this.lblUpperSection.Name = "lblUpperSection";
            this.lblUpperSection.Size = new System.Drawing.Size(180, 33);
            this.lblUpperSection.TabIndex = 11;
            this.lblUpperSection.Text = "Upper Section";
            // 
            // lblGrandTotalScore
            // 
            this.lblGrandTotalScore.AutoSize = true;
            this.lblGrandTotalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalScore.Location = new System.Drawing.Point(260, 616);
            this.lblGrandTotalScore.Name = "lblGrandTotalScore";
            this.lblGrandTotalScore.Size = new System.Drawing.Size(71, 39);
            this.lblGrandTotalScore.TabIndex = 10;
            this.lblGrandTotalScore.Text = "      ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Candara", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(165, 169);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(106, 40);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Player";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 148);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(54, 24);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Roll 1";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(6, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(38, 616);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(196, 39);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(37, 354);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "label1";
            // 
            // lblLowerTotal
            // 
            this.lblLowerTotal.AutoSize = true;
            this.lblLowerTotal.Location = new System.Drawing.Point(37, 448);
            this.lblLowerTotal.Name = "lblLowerTotal";
            this.lblLowerTotal.Size = new System.Drawing.Size(35, 13);
            this.lblLowerTotal.TabIndex = 5;
            this.lblLowerTotal.Text = "label1";
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(375, 60);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 37);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll the Dice!";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.RollDice);
            // 
            // lblYahtzeeTotal
            // 
            this.lblYahtzeeTotal.AutoSize = true;
            this.lblYahtzeeTotal.Location = new System.Drawing.Point(37, 424);
            this.lblYahtzeeTotal.Name = "lblYahtzeeTotal";
            this.lblYahtzeeTotal.Size = new System.Drawing.Size(35, 13);
            this.lblYahtzeeTotal.TabIndex = 4;
            this.lblYahtzeeTotal.Text = "label1";
            // 
            // lblBonus63
            // 
            this.lblBonus63.AutoSize = true;
            this.lblBonus63.Location = new System.Drawing.Point(37, 377);
            this.lblBonus63.Name = "lblBonus63";
            this.lblBonus63.Size = new System.Drawing.Size(35, 13);
            this.lblBonus63.TabIndex = 2;
            this.lblBonus63.Text = "label1";
            // 
            // lblUpperTotal
            // 
            this.lblUpperTotal.AutoSize = true;
            this.lblUpperTotal.Location = new System.Drawing.Point(37, 401);
            this.lblUpperTotal.Name = "lblUpperTotal";
            this.lblUpperTotal.Size = new System.Drawing.Size(35, 13);
            this.lblUpperTotal.TabIndex = 3;
            this.lblUpperTotal.Text = "label1";
            // 
            // musGame
            // 
            this.musGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.musGame.Location = new System.Drawing.Point(0, 0);
            this.musGame.Name = "musGame";
            this.musGame.Size = new System.Drawing.Size(474, 24);
            this.musGame.TabIndex = 14;
            this.musGame.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // lblPlayersDGV
            // 
            this.lblPlayersDGV.AutoSize = true;
            this.lblPlayersDGV.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersDGV.Location = new System.Drawing.Point(61, 176);
            this.lblPlayersDGV.Name = "lblPlayersDGV";
            this.lblPlayersDGV.Size = new System.Drawing.Size(87, 29);
            this.lblPlayersDGV.TabIndex = 4;
            this.lblPlayersDGV.Text = "Players";
            // 
            // lblNoPlayerNUD
            // 
            this.lblNoPlayerNUD.AutoSize = true;
            this.lblNoPlayerNUD.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPlayerNUD.Location = new System.Drawing.Point(23, 122);
            this.lblNoPlayerNUD.Name = "lblNoPlayerNUD";
            this.lblNoPlayerNUD.Size = new System.Drawing.Size(86, 19);
            this.lblNoPlayerNUD.TabIndex = 3;
            this.lblNoPlayerNUD.Text = "# of Players";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(16, 215);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(195, 118);
            this.dgvPlayers.TabIndex = 2;
            // 
            // nudNumPlayers
            // 
            this.nudNumPlayers.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumPlayers.Location = new System.Drawing.Point(115, 123);
            this.nudNumPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudNumPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumPlayers.Name = "nudNumPlayers";
            this.nudNumPlayers.Size = new System.Drawing.Size(33, 23);
            this.nudNumPlayers.TabIndex = 1;
            this.nudNumPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYahtzee
            // 
            this.lblYahtzee.AutoSize = true;
            this.lblYahtzee.Font = new System.Drawing.Font("Candara", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYahtzee.Location = new System.Drawing.Point(43, 27);
            this.lblYahtzee.Name = "lblYahtzee";
            this.lblYahtzee.Size = new System.Drawing.Size(129, 40);
            this.lblYahtzee.TabIndex = 0;
            this.lblYahtzee.Text = "Yahtzee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(711, 664);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.musGame;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yahtzee Game";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.musGame.ResumeLayout(false);
            this.musGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblLowerTotal;
        private System.Windows.Forms.Label lblYahtzeeTotal;
        private System.Windows.Forms.Label lblBonus63;
        private System.Windows.Forms.Label lblUpperTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLowerSection;
        private System.Windows.Forms.Label lblUpperSection;
        private System.Windows.Forms.Label lblCheckBoxinstruction;
        private System.Windows.Forms.Label lblGrandTotalScore;
        private System.Windows.Forms.Label lblYahtzee;
        private System.Windows.Forms.MenuStrip musGame;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudNumPlayers;
        private System.Windows.Forms.Label lblNoPlayerNUD;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Label lblPlayersDGV;
    }
}

