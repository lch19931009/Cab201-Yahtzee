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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblBonus63 = new System.Windows.Forms.Label();
            this.lblUpperTotal = new System.Windows.Forms.Label();
            this.lblYahtzeeTotal = new System.Windows.Forms.Label();
            this.lblLowerTotal = new System.Windows.Forms.Label();
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
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(385, 70);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 37);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll the Dice!";
            this.btnRollDice.UseVisualStyleBackColor = true;
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
            // lblYahtzeeTotal
            // 
            this.lblYahtzeeTotal.AutoSize = true;
            this.lblYahtzeeTotal.Location = new System.Drawing.Point(3, 70);
            this.lblYahtzeeTotal.Name = "lblYahtzeeTotal";
            this.lblYahtzeeTotal.Size = new System.Drawing.Size(35, 13);
            this.lblYahtzeeTotal.TabIndex = 4;
            this.lblYahtzeeTotal.Text = "label1";
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
    }
}

