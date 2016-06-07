using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Yahtzee_Game {

    public enum ScoreType {
        Ones, Twos, Threes, Fours, Fives, Sixes,
        SubTotal, BonusFor63Plus, SectionATotal,
        ThreeOfAKind, FourOfAKind, FullHouse,
        SmallStraight, LargeStraight, Chance, Yahtzee,
        YahtzeeBonus, SectionBTotal, GrandTotal
    }

    [Serializable]
    public class Game {

        private BindingList<Player> players;
        private int currentPlayerIndex;
        private Player currentPlayer;
        private Die[] dice;
        private int playersFinished;
        private int numRolls;
        [NonSerialized]
        private Form1 form;
        [NonSerialized]
        private Label[] dieLabels;

        public static string defaultPath = Environment.CurrentDirectory;
        private static string savedGameFile = defaultPath + "\\YahtzeeGame.dat";

        public BindingList<Player> Players {
            get {
                return players;
            }
            set {
                players = value;
            }
        }

        public Game(Form1 form) {
            this.form = form;
            players = new BindingList<Player>();
            currentPlayerIndex = 0;
            dieLabels = this.form.GetDice();
            dice = new Die[Form1.NUM_DICE];
            for (int i = 0; i < 5; i++) {
                dice[i] = new Die(dieLabels[i]);
            }
            players.Add(new Player("player1", form.GetScoresTotals()));
            currentPlayer = players[currentPlayerIndex];
            playersFinished = 0;
            numRolls = 0;
            form.EnableRollButton();
            for (int i = 0; i < Form1.NUM_BUTTONS + Form1.NUM_TOTALS; i++) {
                form.DisableScoreButton((ScoreType)i);
            }
            players[currentPlayerIndex].ShowScores();
        }

        public void NextTurn() {
            if (playersFinished >= players.Count()) {
                FinishGame();
                return;
            }
            numRolls = 0;
            currentPlayerIndex+= (currentPlayerIndex+1==players.Count+1)?0:1;
            currentPlayerIndex *= (currentPlayerIndex+1 == players.Count+1)?0:1;
            form.ShowPlayerName(players[currentPlayerIndex].Name);
            form.DisableAndClearCheckBoxes();
            for (int i = 0; i < Form1.NUM_BUTTONS + Form1.NUM_TOTALS; i++) {
                form.DisableScoreButton((ScoreType)i);
            }
            players[currentPlayerIndex].ShowScores();
            form.ShowPlayerName(players[currentPlayerIndex].Name);
        }

        public void RollDice() {
            playersFinished += (players[currentPlayerIndex].IsFinished()) ? 1 : 0;
            if (playersFinished >= players.Count()) {
                NextTurn();
            }
            numRolls++;
            form.ShowPlayerName(players[currentPlayerIndex].Name);
            form.EnableCheckBoxes();
            foreach (Die die in dice) {
                if (die.Active) {
                    die.Roll();
                }
            }
            switch(numRolls){
                case 0:
                    form.ShowMessage("First Roll");
                    break;
                case 1:
                    form.ShowMessage("Roll Again or Choose a Score Bellow");
                    break;
                case 2:
                    form.ShowMessage("Final Roll, Please Choose a Score");
                    break;
            }
            for (int i = 0; i < Form1.NUM_BUTTONS + Form1.NUM_TOTALS; i++) {
                if (players[currentPlayerIndex].IsAvailable((ScoreType)i)) {
                    form.EnableScoreButton((ScoreType)i);
                } else {
                    form.DisableScoreButton((ScoreType)i);
                }
            }

        }

        public void HoldDie(int dieIndex) {
            dice[dieIndex].Active = false;
        }

        public void ReleaseDie(int dieIndex) {
            dice[dieIndex].Active = true;
        }

        public void ScoreCombination(ScoreType score) {
            int[] faces = new int[Form1.NUM_DICE];
            for (int i = 0; i < Form1.NUM_DICE; i++) {
                faces[i] = dice[i].FaceValue;
            }
            players[currentPlayerIndex].ScoreCombination(score,faces);            
        }

        private void FinishGame() {
            List<int> scores = new List<int>();
            foreach(Player player in players) {
                scores.Add(player.GrandTotal);
            }
            form.DisableAndClearCheckBoxes();
            form.DisableRollButton();
            for (int i = 0; i < Form1.NUM_BUTTONS + Form1.NUM_TOTALS; i++) {
                form.DisableScoreButton((ScoreType)i);
            }
            string builder = string.Format("The Winner is {0} with a score of {1},\nPlay Again?", currentPlayer.Name, scores.Max().ToString());
            switch(MessageBox.Show(builder, "Game Over",MessageBoxButtons.YesNo,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly, false)){
                case DialogResult.Yes:
                    form.StartNewGame();
                    break;
                case DialogResult.No:
                    form.Close();
                    break;
            }
        }

        /// <summary>
        /// Load a saved game from the default save game file
        /// </summary>
        /// <param name="form">the GUI form</param>
        /// <returns>the saved game</returns>
        public static Game Load(Form1 form) {
            Game game = null;
            if (File.Exists(savedGameFile)) {
                try {
                    Stream bStream = File.Open(savedGameFile, FileMode.Open);
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    game = (Game)bFormatter.Deserialize(bStream);
                    bStream.Close();
                    game.form = form;
                    game.ContinueGame();
                    return game;
                } catch {
                    MessageBox.Show("Error reading saved game file.\nCannot load saved game.");
                }
            } else {
                MessageBox.Show("No current saved game.");
            }
            return null;
        }

        /// <summary>
        /// Save the current game to the default save file
        /// </summary>
        public void Save() {
            try {
                Stream bStream = File.Open(savedGameFile, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(bStream, this);
                bStream.Close();
                MessageBox.Show("Game saved");
            } catch (Exception e) {

                //   MessageBox.Show(e.ToString());
                MessageBox.Show("Error saving game.\nNo game saved.");
            }
        }

        /// <summary>
        /// Continue the game after loading a saved game
        /// 
        /// Assumes game was saved at the start of a player's turn before they had rolled dice.
        /// </summary>
        private void ContinueGame() {
            LoadLabels(form);
            for (int i = 0; i < dice.Length; i++) {
                //uncomment one of the following depending how you implmented Active of Die
                // dice[i].SetActive(true);
                dice[i].Active = true;
            }

            form.ShowPlayerName(currentPlayer.Name);
            form.EnableRollButton();
            form.EnableCheckBoxes();
            // can replace string with whatever you used
            form.ShowMessage("Roll 1");
            currentPlayer.ShowScores();
        }//end ContinueGame

        /// <summary>
        /// Link the labels on the GUI form to the dice and players
        /// </summary>
        /// <param name="form"></param>
        private void LoadLabels(Form1 form) {
            Label[] diceLabels = form.GetDice();
            for (int i = 0; i < dice.Length; i++) {
                dice[i].Load(diceLabels[i]);
            }
            for (int i = 0; i < players.Count; i++) {
                players[i].Load(form.GetScoresTotals());
            }

        }
    }
}
