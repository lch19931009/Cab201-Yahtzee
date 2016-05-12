using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    public partial class Form1 : Form {
        
        //Constants
        const int NUM_DICE = 5;
        const int NUM_SCORES_UPPER = 6;
        const int NUM_SCORES_LOWER = 7;
        
        //Control arrays
        Label[] dice = new Label[NUM_DICE];
        Button[] upperScoreButtons = new Button[NUM_SCORES_UPPER];
        Button[] lowerScoreButtons = new Button[NUM_SCORES_LOWER];
        CheckBox[] holdDice = new CheckBox[NUM_DICE];

        //Misc
        Font font = new Font("Candara",20,FontStyle.Bold);

        public Form1() {
            InitializeComponent();
            InitDiceBoxes();
            InitScoreButtons();


        }

        /// <summary>
        /// Generates an array of Labels for the 5 dice
        /// </summary>
        private void InitDiceBoxes() {
            int startingX = 20;
            int startingY = 60;
            for (int i = 0; i < NUM_DICE; i++) {
                dice[i] = new Label();
                holdDice[i] = new CheckBox();
                dice[i].Width = 50;
                dice[i].Height = 50;
                dice[i].Location = new Point(((dice[i].Width + 20) * i) + startingX, startingY);
                holdDice[i].Location = new Point(((dice[i].Width + 20) * i) -7+ startingX+dice[i].Width/2, startingY+dice[i].Height+10);
                dice[i].Text = "1";
                dice[i].BackColor = DefaultBackColor;
                dice[i].ForeColor = Color.Crimson;
                holdDice[i].Width = 50;
                dice[i].TextAlign = ContentAlignment.MiddleCenter;
                dice[i].Font = font;
                splitContainer1.Panel1.Controls.Add(dice[i]);
                splitContainer1.Panel1.Controls.Add(holdDice[i]);
            }
        }

        /// <summary>
        /// Generates the buttons used for scoring
        /// </summary>
        private void InitScoreButtons() {
            int startingX = 50;
            int startingY = 200;
            for(int i = 0; i < NUM_SCORES_UPPER; i++) {
                upperScoreButtons[i] = new Button();
                upperScoreButtons[i].Text = Enum.GetName(typeof(ScoreType),i);
                upperScoreButtons[i].BackColor = DefaultBackColor;
                upperScoreButtons[i].ForeColor = DefaultForeColor;
                upperScoreButtons[i].Tag = i.ToString();
                upperScoreButtons[i].Location = new Point(startingX, upperScoreButtons[i].Height+40 *i + startingY);
                splitContainer1.Panel1.Controls.Add(upperScoreButtons[i]);
            }
            startingX = 250;
            startingY = 200;
            for (int i = 0; i < NUM_SCORES_LOWER; i++) {
                lowerScoreButtons[i] = new Button();
                lowerScoreButtons[i].AutoSize = true;
                lowerScoreButtons[i].Text = Enum.GetName(typeof(ScoreType), i+NUM_SCORES_UPPER);
                lowerScoreButtons[i].BackColor = DefaultBackColor;
                lowerScoreButtons[i].ForeColor = DefaultForeColor;
                lowerScoreButtons[i].Tag = (i + NUM_SCORES_UPPER).ToString();
                lowerScoreButtons[i].Location = new Point(startingX, lowerScoreButtons[i].Height + 40 * i + startingY);
                splitContainer1.Panel1.Controls.Add(lowerScoreButtons[i]);
            }
        }
    }

}

