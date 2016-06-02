using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Yahtzee_Game {

    public enum ScoreType {
        Ones, Twos, Threes, Fours, Fives, Sixes,
        SubTotal, BonusFor63Plus, SectionATotal,
        ThreeOfAKind, FourOfAKind, FullHouse,
        SmallStraight, LargeStraight, Chance, Yahtzee,
        YahtzeeBonus, SectionBTotal, GrandTotal
    }

    class Game {
        private BindingList<Player> players;
        private int currentPlayerIndex;
        private Player currentPlayer;
        private Die[] dice = new Die[5];
        private int playersFinished;
        private int numRolls;
        private Form1 form;
        private Label[] dieLabels;
        private int NUM_PLAYERS = 2;

        public BindingList<Player> Players {
            get {
                return players;
            }
            set {
                players = value;
            }
        }

        public Game(Form1 form1) {
            form = form1;
            players = new BindingList<Player>();
            currentPlayerIndex = 0;
            for (int i = 0; i < NUM_PLAYERS; i++) {
                players.Add(new Player("player" + (i + 1), form.GetScoresTotals()));
            }
            dieLabels = form.GetDice();

            for (int i = 0; i < 5; i++) {
                dice[i] = new Die(dieLabels[i]);
            }
            currentPlayer = players[currentPlayerIndex];
            playersFinished = 0;
            numRolls = 0;
            //dieLabels
        }

        public void NextTurn() {

        }

        public void RollDice() {
            numRolls++;
            foreach (Die die in dice) {
                if (die.Active) {
                    die.Roll();
                }
            }
        }

        public void HoldDie(int dieIndex) {
            dice[dieIndex].Active = false;
        }

        public void ReleaseDie(int dieIndex) {
            form.GetDice()[dieIndex].Tag = "";
        }

        public ScoreType ScoreCombination() {
            return 0;
        }

        public static Game Load(Form1 form) {
            return null;
        }

        public void Save() {

        }
    }
}
