using System;
using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee_Game {
    /*
     * Form1 Class for CAB201 Yahtzee Game
     * 
     * Authors: Alex Barnier, n9448551; Chun Hong Lee, n8770816.
     * 
     */
    public partial class Form1 : Form {


        #region GlobalVariables

        //Constants
        public const int NUM_DICE = 5;
        public const int NUM_SCORES_UPPER = 6;
        public const int NUM_SCORES_LOWER = 7;
        public const int NUM_TOTALS = 6;

        //Control arrays
        private Label[] dice = new Label[NUM_DICE];
        private Button[] scoreButtons = new Button[NUM_SCORES_UPPER + NUM_SCORES_LOWER];
        private CheckBox[] checkBoxes = new CheckBox[NUM_DICE];
        private Label[] totalLabels = new Label[NUM_TOTALS];
        private Label[] scoreTotals = new Label[NUM_SCORES_LOWER + NUM_SCORES_UPPER + NUM_TOTALS-1];

        Die[] diceArray = new Die[NUM_DICE];

        //The Game instance
        private Game game;

        //Misc
        Font font = new Font("Candara", 20, FontStyle.Bold);

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
            InitTotalLabels();
            InitScoreBoxes();
            //TODO Add the rest of the init functions here
        }

        /// <summary>
        /// Generates an array of Labels for the 5 dice
        /// </summary>
        private void InitDiceBoxes() {
            int startingX = 10;
            int startingY = 60;
            for (int i = 0; i < NUM_DICE; i++) {
                dice[i] = new Label();
                diceArray[i] = new Die(dice[i]);
                checkBoxes[i] = new CheckBox();
                dice[i].Width = 50;
                dice[i].Height = 50;
                dice[i].Location = new Point(((dice[i].Width + 10) * i) + startingX, startingY);
                checkBoxes[i].Location = new Point(((dice[i].Width + 10) * i) - 7 + startingX + dice[i].Width / 2, startingY + dice[i].Height + 10);
                dice[i].Image = new Bitmap(Properties.Resources._1);
                dice[i].BackColor = Color.Transparent;
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
            int startingY = 230;
            int y = 0;
            for (int i = 0; i < NUM_SCORES_UPPER + NUM_SCORES_LOWER; i++) {
                scoreButtons[i] = new Button();
                scoreButtons[i].AutoSize = true;
                scoreButtons[i].Text = (i < NUM_SCORES_UPPER) ? GetEnumString(i) : GetEnumString(i + 3);
                scoreButtons[i].BackColor = Color.Transparent;
                scoreButtons[i].ForeColor = DefaultForeColor;
                scoreButtons[i].Tag = i.ToString();
                startingX = (i < NUM_SCORES_UPPER) ? 50 : 250;
                y = (i < NUM_SCORES_UPPER) ? i : i - NUM_SCORES_UPPER;
                scoreButtons[i].Location = new Point(startingX, scoreButtons[i].Height + 40 * y + startingY);
                scoreButtons[i].Click += new EventHandler(ScoreButtonPress);
                splitContainer1.Panel1.Controls.Add(scoreButtons[i]);
            }
        }

        /// <summary>
        /// Makes the Score labels in the correct positions and with the correct names
        /// </summary>
        private void InitTotalLabels() {
            int spacing = 2 * scoreButtons[0].Height;

            LabelLocation(lblSubTotal, scoreButtons[NUM_SCORES_UPPER - 1].Location, spacing);
            lblSubTotal.Text = GetEnumString(NUM_SCORES_UPPER);
            totalLabels[0] = lblSubTotal;

            LabelLocation(lblBonus63, lblSubTotal.Location, spacing);
            lblBonus63.Text = GetEnumString(NUM_SCORES_UPPER + 1);
            totalLabels[1] = lblBonus63;

            LabelLocation(lblUpperTotal, lblBonus63.Location, spacing);
            lblUpperTotal.Text = GetEnumString(NUM_SCORES_UPPER + 2);
            totalLabels[2] = lblUpperTotal;

            LabelLocation(lblYahtzeeTotal, scoreButtons[NUM_SCORES_UPPER + NUM_SCORES_LOWER - 1].Location, spacing);
            lblYahtzeeTotal.Text = GetEnumString(NUM_SCORES_UPPER + NUM_SCORES_LOWER + 3);
            totalLabels[3] = lblYahtzeeTotal;

            LabelLocation(lblLowerTotal, lblYahtzeeTotal.Location, spacing);
            lblLowerTotal.Text = GetEnumString(NUM_SCORES_UPPER + NUM_SCORES_LOWER + 4);
            totalLabels[4] = lblLowerTotal;

            totalLabels[5] = lblGrandTotalScore;
        }

        /// <summary>
        /// Generates labels to display score
        /// </summary>
        private void InitScoreBoxes() {
            int startingX;
            int startingY = 240;
            int y = 0;
            int j = -2;
            for (int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER + NUM_TOTALS - 1; i++) {
                scoreTotals[i] = new Label();
                scoreTotals[i].Width = 25;
                scoreTotals[i].Height = 15;
                scoreTotals[i].AutoSize = false;
                scoreTotals[i].BackColor = Color.Transparent;
                scoreTotals[i].ForeColor = Color.Black;
                scoreTotals[i].TextAlign = ContentAlignment.MiddleCenter;
                startingX = (i < NUM_SCORES_UPPER) ? 50 : 250;
                y = (i < NUM_SCORES_UPPER) ? i : i - NUM_SCORES_UPPER;
                j *= (i < NUM_SCORES_LOWER + NUM_SCORES_UPPER) ? 0 : 1;
                j += (i < NUM_SCORES_LOWER + NUM_SCORES_UPPER) ? 0 : 1;
                scoreTotals[i].Location = (i < scoreButtons.Length) ? new Point(startingX + scoreButtons[i].Width + 10, scoreTotals[i].Height + 40 * y + startingY)
                    : new Point(totalLabels[j - 1].Width + totalLabels[j - 1].Location.X, totalLabels[j - 1].Location.Y);
                splitContainer1.Panel1.Controls.Add(scoreTotals[i]);
            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Sets the location of the target based on the spacing and the previous point
        /// </summary>
        /// <param name="target">Label you are moving</param>
        /// <param name="previous">The location of the prevois control</param>
        /// <param name="spacing">How far away you want the target from the previous</param>
        void LabelLocation(Label target, Point previous, int spacing) {
            target.Location = new Point(previous.X, previous.Y + spacing);
        }

        /// <summary>
        /// Add spaces to the Enum values for presentation
        /// </summary>
        /// <param name="value">The value in the enum</param>
        /// <returns>The name of the enum value with spaces</returns>
        string GetEnumString(int value) {
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
            lblPlayer.Text = name;
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
            for (int i = 0; i < NUM_DICE; i++) {
                checkBoxes[i].Enabled = true;
            }
        }

        public void DisableAndClearCheckBoxes() {
            for (int i = 0; i < NUM_DICE; i++) {
                checkBoxes[i].Checked = false;
                checkBoxes[i].Enabled = false;
            }
        }

        public void EnableScoreButton(ScoreType combo) {
            for (int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER; i++) {
                if (scoreButtons[i].Tag.ToString() == combo.ToString()) {
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
            game = new Game(this);
        }

        #endregion

        #region EventHandlers
        
        void ScoreButtonPress(object sender, EventArgs e) {

        }

        void RollDice(object sender, EventArgs e) {
            foreach (Die die in diceArray) {
                die.Roll();
            }
        }

        #endregion
    }
}

