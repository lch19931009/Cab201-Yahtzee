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
    /*
     * Form1 Class for CAB201 Yahtzee Game
     * 
     * Authors: Alex Barnier, n9448551; Hong, Student No.
     * 
     */
    public partial class Form1 : Form {


        #region GlobalVariables
        
        //Constants
        const int NUM_DICE = 5;
        const int NUM_SCORES_UPPER = 6;
        const int NUM_SCORES_LOWER = 7;
        const int NUM_TOTALS = 6;
        
        //Control arrays
        private Label[] dice = new Label[NUM_DICE];
        private Button[] scoreButtons = new Button[NUM_SCORES_UPPER+NUM_SCORES_LOWER];
        private CheckBox[] checkBoxes = new CheckBox[NUM_DICE];
        private Label[] scoreTotals = new Label[NUM_SCORES_LOWER+NUM_SCORES_UPPER+NUM_TOTALS];

        //The Game instance
        private Game game;

        //Misc
        Font font = new Font("Candara",20,FontStyle.Bold);

        #endregion

        public Form1() {
            InitializeComponent();
            InitializeLabelsAndButtons();
        }

        #region Init
        /// <summary>
        /// Setup the form
        /// </summary>
        private void InitializeLabelsAndButtons() {
            InitDiceBoxes();
            InitScoreButtons();
            InitScoreBoxes();
            InitTotalLabels();
            //TODO Add the rest of the init functions here
        }

        /// <summary>
        /// Generates an array of Labels for the 5 dice
        /// </summary>
        private void InitDiceBoxes() {
            int startingX = 20;
            int startingY = 60;
            for (int i = 0; i < NUM_DICE; i++) {
                dice[i] = new Label();
                checkBoxes[i] = new CheckBox();
                dice[i].Width = 50;
                dice[i].Height = 50;
                dice[i].Location = new Point(((dice[i].Width + 20) * i) + startingX, startingY);
                checkBoxes[i].Location = new Point(((dice[i].Width + 20) * i) -7+ startingX+dice[i].Width/2, startingY+dice[i].Height+10);
                dice[i].Text = "1";
                dice[i].BackColor = DefaultBackColor;
                dice[i].ForeColor = Color.Crimson;
                checkBoxes[i].Width = 50;
                dice[i].TextAlign = ContentAlignment.MiddleCenter;
                dice[i].Font = font;
                splitContainer1.Panel1.Controls.Add(dice[i]);
                splitContainer1.Panel1.Controls.Add(checkBoxes[i]);
            }
        }

        /// <summary>
        /// Generates the buttons used for scoring
        /// </summary>
        private void InitScoreButtons() {
            int startingX = 50;
            int startingY = 200;
            int y = 0;
            for(int i = 0; i < NUM_SCORES_UPPER+NUM_SCORES_LOWER; i++) {
                scoreButtons[i] = new Button();
                scoreButtons[i].AutoSize = true;
                scoreButtons[i].Text = (i < NUM_SCORES_UPPER)? GetEnumString(i): GetEnumString(i+3);
                scoreButtons[i].BackColor = DefaultBackColor;
                scoreButtons[i].ForeColor = DefaultForeColor;
                scoreButtons[i].Tag = i.ToString();
                startingX = (i<NUM_SCORES_UPPER)?50:250;
                y = (i < NUM_SCORES_UPPER) ? i : i-NUM_SCORES_UPPER;
                scoreButtons[i].Location = new Point(startingX, scoreButtons[i].Height + 40 * y + startingY);
                scoreButtons[i].Click += new EventHandler(ScoreButtonPress);
                splitContainer1.Panel1.Controls.Add(scoreButtons[i]);
            }
        }

        /// <summary>
        /// Makes the Score labels in the correct positions and with the correct names
        /// </summary>
        private void InitTotalLabels() {
            int spacing = 2*scoreButtons[0].Height;

            LabelLocation(lblSubTotal, scoreButtons[NUM_SCORES_UPPER - 1].Location, spacing);
            lblSubTotal.Text = GetEnumString(NUM_SCORES_UPPER);

            LabelLocation(lblBonus63, lblSubTotal.Location, spacing);
            lblBonus63.Text = GetEnumString(NUM_SCORES_UPPER + 1);

            LabelLocation(lblUpperTotal, lblBonus63.Location, spacing);
            lblUpperTotal.Text = GetEnumString(NUM_SCORES_UPPER + 2);

            LabelLocation(lblYahtzeeTotal, scoreButtons[NUM_SCORES_UPPER+NUM_SCORES_LOWER - 1].Location, spacing);
            lblYahtzeeTotal.Text = GetEnumString(NUM_SCORES_UPPER + NUM_SCORES_LOWER + 3);

            LabelLocation(lblLowerTotal, lblYahtzeeTotal.Location, spacing);
            lblLowerTotal.Text = GetEnumString(NUM_SCORES_UPPER + NUM_SCORES_LOWER + 4);
        }

        /// <summary>
        /// Write what it does
        /// </summary>
        private void InitScoreBoxes() {
            //TODO Do the boxes beside the buttons in the same way as the above functions
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Add spaces to the Enum values for presentation
        /// </summary>
        /// <param name="value">The value in the enum</param>
        /// <returns>The name of the enum value with spaces</returns>
        private string GetEnumString(int value) {
            string enumString = Enum.GetName(typeof(ScoreType), value);
            switch (enumString) {
                case "SubTotal":
                    return "Sub Total";
                case "BonusFor63Plus":
                    return "Bonus For 63 +";
                case "SectionATotal":
                    return "Upper Total";
                case "ThreeOfAKind":
                    return "Three Of A Kind";
                case "FourOfAKind":
                    return "Four Of A Kind";
                case "FullHouse":
                    return "Full House";
                case "SmallStraigh":
                    return "Small Straigh";
                case "LargeStraight":
                    return "Large Straight";
                case "YahtzeeBonus":
                    return "Yahtzee Bonus";
                case "SectionBTotal":
                    return "Lower Total";
                case "GrandTotal":
                    return "GrandTotal";
                default:
                    return enumString;
            }
        }
        
        /// <summary>
        /// Sets the location of the target based on the spacing and the previous point
        /// </summary>
        /// <param name="target">Label you are moving</param>
        /// <param name="previous">The location of the prevois control</param>
        /// <param name="spacing">How far away you want the target from the previous</param>
        private void LabelLocation(Label target, Point previous, int spacing) {
            target.Location = new Point(previous.X, previous.Y + spacing);
        }

        #endregion

        #region Required Functions

        /// <summary>
        /// Returns the dice labels
        /// </summary>
        /// <returns>An array of lables</returns>
        public Label[] GetDice() {
            return dice;
        }

        public Label[] GetScoresTotals() {
            return scoreTotals;
        }

        public void ShowPlayerName(string name) {
            //TODO
            //lblPlayerName.Text = "Player Name";
        }

        public void ChangeRollButton() {
            if (btnRollDice.Enabled) {
                DisableRollButton();
            } else {
                EnableRollButton();
            }
        }

        public void EnableRollButton() {
            btnRollDice.Enabled = true;
        }

        public void DisableRollButton() {
            btnRollDice.Enabled = false;
        }

        public void EnableCheckBoxes() {
            for(int i = 0; i < NUM_DICE; i++) {
                checkBoxes[i].Enabled = true;
            }
        }

        public void DisableAndClearCheckBoxes() {
            for(int i = 0; i < NUM_DICE; i++) {
                checkBoxes[i].Checked = false;
                checkBoxes[i].Enabled = false;
            }
        }

        public void EnableScoreButton(ScoreType combo) {
            for(int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER; i++) {
                if(scoreButtons[i].Tag.ToString() == combo.ToString()) {
                    scoreButtons[i].Enabled = true;
                }
            }
        }

        public void DisableScoreButton(ScoreType combo) {
            for (int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER; i++) {
                if (scoreButtons[i].Tag.ToString() == combo.ToString()) {
                    scoreButtons[i].Enabled = false;
                }
            }
        }

        public void CheckCheckBox(int index) {
            checkBoxes[index].Checked = true;
        }

        public void ShowMessage(string message) {
            //TODO
            //lblMessage.Text = message;
        }

        public void ShowOKButton() {
            //TODO Wait until Part C
        }

        public void StartNewGame() {
            game = new Game();
        }

        #endregion

        #region EventHandlers

        void ScoreButtonPress(object sender, EventArgs e) {
            //TODO Event for the score button presses
        }

        #endregion
    }

}

