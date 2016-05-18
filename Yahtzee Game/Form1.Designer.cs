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
            this.lblresultGrandTotal = new System.Windows.Forms.Label();
            this.lblUpperSection = new System.Windows.Forms.Label();
            this.lblLowerSection = new System.Windows.Forms.Label();
            this.lblCheckBoxinstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblCheckBoxinstruction);
            this.splitContainer1.Panel1.Controls.Add(this.lblLowerSection);
            this.splitContainer1.Panel1.Controls.Add(this.lblUpperSection);
            this.splitContainer1.Panel1.Controls.Add(this.lblresultGrandTotal);
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
            this.splitContainer1.Size = new System.Drawing.Size(711, 664);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(165, 160);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(114, 39);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Player";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 148);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(60, 25);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Roll 1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
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
            this.lblSubTotal.Location = new System.Drawing.Point(3, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "label1";
            // 
            // lblLowerTotal
            // 
            this.lblLowerTotal.AutoSize = true;
            this.lblLowerTotal.Location = new System.Drawing.Point(3, 94);
            this.lblLowerTotal.Name = "lblLowerTotal";
            this.lblLowerTotal.Size = new System.Drawing.Size(35, 13);
            this.lblLowerTotal.TabIndex = 5;
            this.lblLowerTotal.Text = "label1";
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(385, 70);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 37);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll the Dice!";
            this.btnRollDice.UseVisualStyleBackColor = true;
            // 
            // lblYahtzeeTotal
            // 
            this.lblYahtzeeTotal.AutoSize = true;
            this.lblYahtzeeTotal.Location = new System.Drawing.Point(3, 70);
            this.lblYahtzeeTotal.Name = "lblYahtzeeTotal";
            this.lblYahtzeeTotal.Size = new System.Drawing.Size(35, 13);
            this.lblYahtzeeTotal.TabIndex = 4;
            this.lblYahtzeeTotal.Text = "label1";
            // 
            // lblBonus63
            // 
            this.lblBonus63.AutoSize = true;
            this.lblBonus63.Location = new System.Drawing.Point(3, 23);
            this.lblBonus63.Name = "lblBonus63";
            this.lblBonus63.Size = new System.Drawing.Size(35, 13);
            this.lblBonus63.TabIndex = 2;
            this.lblBonus63.Text = "label1";
            // 
            // lblUpperTotal
            // 
            this.lblUpperTotal.AutoSize = true;
            this.lblUpperTotal.Location = new System.Drawing.Point(3, 47);
            this.lblUpperTotal.Name = "lblUpperTotal";
            this.lblUpperTotal.Size = new System.Drawing.Size(35, 13);
            this.lblUpperTotal.TabIndex = 3;
            this.lblUpperTotal.Text = "label1";
            // 
            // lblresultGrandTotal
            // 
            this.lblresultGrandTotal.AutoSize = true;
            this.lblresultGrandTotal.BackColor = System.Drawing.Color.White;
            this.lblresultGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultGrandTotal.Location = new System.Drawing.Point(260, 616);
            this.lblresultGrandTotal.Name = "lblresultGrandTotal";
            this.lblresultGrandTotal.Size = new System.Drawing.Size(71, 39);
            this.lblresultGrandTotal.TabIndex = 10;
            this.lblresultGrandTotal.Text = "      ";
            // 
            // lblUpperSection
            // 
            this.lblUpperSection.AutoSize = true;
            this.lblUpperSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperSection.Location = new System.Drawing.Point(12, 215);
            this.lblUpperSection.Name = "lblUpperSection";
            this.lblUpperSection.Size = new System.Drawing.Size(186, 31);
            this.lblUpperSection.TabIndex = 11;
            this.lblUpperSection.Text = "Upper Section";
            // 
            // lblLowerSection
            // 
            this.lblLowerSection.AutoSize = true;
            this.lblLowerSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerSection.Location = new System.Drawing.Point(251, 215);
            this.lblLowerSection.Name = "lblLowerSection";
            this.lblLowerSection.Size = new System.Drawing.Size(186, 31);
            this.lblLowerSection.TabIndex = 12;
            this.lblLowerSection.Text = "Lower Section";
            // 
            // lblCheckBoxinstruction
            // 
            this.lblCheckBoxinstruction.AutoSize = true;
            this.lblCheckBoxinstruction.Location = new System.Drawing.Point(349, 126);
            this.lblCheckBoxinstruction.Name = "lblCheckBoxinstruction";
            this.lblCheckBoxinstruction.Size = new System.Drawing.Size(122, 13);
            this.lblCheckBoxinstruction.TabIndex = 13;
            this.lblCheckBoxinstruction.Text = "Check box to hold value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(711, 664);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblresultGrandTotal;
        private System.Windows.Forms.Label lblLowerSection;
        private System.Windows.Forms.Label lblUpperSection;
        private System.Windows.Forms.Label lblCheckBoxinstruction;
    }
}

