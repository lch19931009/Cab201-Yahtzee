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
        public const int NUM_BUTTONS = 13;

        //Control arrays
        private Label[] dice = new Label[NUM_DICE];
        private Button[] scoreButtons = new Button[NUM_SCORES_UPPER + NUM_SCORES_LOWER];
        private CheckBox[] checkBoxes = new CheckBox[NUM_DICE];
        private Label[] totalLabels = new Label[NUM_TOTALS];
        private Label[] scoreTotals = new Label[NUM_SCORES_LOWER + NUM_SCORES_UPPER + NUM_TOTALS];

        //private helper variables
        private int numRolls = 0;

        //The Game instance
        private Game game;

        //Misc
        Font font = new Font("Candara", 20, FontStyle.Bold);

        #endregion

        public Form1() {
            InitializeComponent();
            InitializeLabelsAndButtons();
            DisableAndClearCheckBoxes();
            DisableRollButton();
            foreach (Button scoreButton in scoreButtons) {
                scoreButton.Enabled = false;
            }
            nudNumPlayers.Enabled = false;
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
            scoreTotals[18] = lblGrandTotalScore;
            lblGrandTotalScore.Tag = 18;
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
                checkBoxes[i] = new CheckBox();
                dice[i].Width = 50;
                dice[i].Height = 50;
                dice[i].Location = new Point(((dice[i].Width + 10) * i) + startingX, startingY);
                checkBoxes[i].Location = new Point(((dice[i].Width + 10) * i) - 7 + startingX + dice[i].Width / 2, startingY + dice[i].Height + 10);
                checkBoxes[i].CheckedChanged += new EventHandler(CheckBox_Click);
                checkBoxes[i].Tag = i;
                dice[i].Image = new Bitmap(Properties.Resources._0);
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
                scoreButtons[i].Tag = (i<NUM_SCORES_UPPER)?i:i+3;
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
            int spacing = scoreButtons[1].Location.Y - scoreButtons[0].Location.Y;

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
            int startingX = 2*scoreButtons[0].Width;
            int startingY = scoreButtons[0].Location.Y+5;
            int y = 0;
            int j = -3;
            for (int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER + NUM_TOTALS - 1; i++) {
                scoreTotals[i] = new Label();
                scoreTotals[i].Width = 25;
                scoreTotals[i].Height = 15;
                scoreTotals[i].AutoSize = false;
                scoreTotals[i].BackColor = Color.Transparent;
                scoreTotals[i].ForeColor = Color.Black;
                scoreTotals[i].TextAlign = ContentAlignment.MiddleCenter;
                scoreTotals[i].Tag = i;
                startingX += (i==9)?scoreButtons[NUM_SCORES_UPPER].Location.X:0;
                if (i==0||i==9) {
                    scoreTotals[i].Location = new Point(startingX, startingY);
                } else {
                    LabelLocation(scoreTotals[i], scoreTotals[i - 1].Location, scoreButtons[1].Location.Y - scoreButtons[0].Location.Y);
                }
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
                if ((int)scoreButtons[i].Tag == (int)combo) {
                    scoreButtons[i].Enabled = true;
                }
            }
        }

        public void DisableScoreButton(ScoreType combo) {
            for (int i = 0; i < NUM_SCORES_LOWER + NUM_SCORES_UPPER; i++) {
                if ((int)scoreButtons[i].Tag == (int)combo) {
                    scoreButtons[i].Enabled = false;
                }
            }
        }

        public void CheckCheckBox(int index) {
            if (checkBoxes[index].Checked) {
                game.HoldDie(index);
            } else {
                game.ReleaseDie(index);
            }
        }

        public void ShowMessage(string message) {
            lblMessage.Text = message;
        }

        public void ShowOKButton() {
            //TODO Wait until Part C
        }

        public void StartNewGame() {
            game = new Game(this);
            playerBindingSource.DataSource = game.Players;
        }
        
        private void UpdatePlayersDataGridView() {
            game.Players.ResetBindings();
        }

        #endregion

        #region EventHandlers

        void ScoreButtonPress(object sender, EventArgs e) {
            game.ScoreCombination((ScoreType)((Button)sender).Tag);
            ((Button)sender).Enabled = false;
            DisableRollButton();
            btnOK.Enabled = true;
            btnOK.Visible = true;
            UpdatePlayersDataGridView();
            for (int i = 0; i < NUM_BUTTONS + NUM_TOTALS; i++) {
                DisableScoreButton((ScoreType)i);
            }
        }

        void RollDice(object sender, EventArgs e) {
            numRolls++;
            btnOK.Enabled = false;
            btnOK.Visible = false;
            if (numRolls == 3) {
                btnRollDice.Enabled = false;
                btnOK.Visible = true;
                ShowMessage("Choose a Score");
            }
            nudNumPlayers.Enabled = false;
            dgvPlayers.AllowUserToAddRows = false;
            dgvPlayers.AllowUserToDeleteRows = false;
            dgvPlayers.ReadOnly = true;
            game.RollDice();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            nudNumPlayers.Value = 1;
            nudNumPlayers.Enabled = true;
            dgvPlayers.AllowUserToAddRows = true;
            dgvPlayers.AllowUserToDeleteRows = true;
            dgvPlayers.ReadOnly = false;
            loadToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = true;
            StartNewGame();
        }

        private void CheckBox_Click(object sender, EventArgs e) {
            CheckCheckBox((int)((CheckBox)sender).Tag);
        }


        private void nudNumPlayers_ValueChanged(object sender, EventArgs e) {
            if (nudNumPlayers.Value > game.Players.Count) {
                game.Players.Add(new Player("player"+(nudNumPlayers.Value).ToString(),GetScoresTotals()));
            } else {
                game.Players.Remove(game.Players[game.Players.Count-1]);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            game.NextTurn();
            numRolls = 0;
            btnOK.Visible = false;
            btnOK.Enabled = false;
            btnRollDice.Enabled = true;
            btnRollDice.PerformClick();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO need to be disable when NEW has been clicked
            game = Game.Load(this);
            playerBindingSource.DataSource = game.Players;
            UpdatePlayersDataGridView();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            game.Save();
        }
        //need a save method here
    }
    #endregion
}

