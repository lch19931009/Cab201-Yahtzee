using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {

    public enum ScoreType {
        Ones, Twos, Threes, Fours, Fives, Sixes,
        SubTotal, BonusFor63Plus, SectionATotal,
        ThreeOfAKind, FourOfAKind, FullHouse,
        SmallStraight, LargeStraight, Chance, Yahtzee,
        YahtzeeBonus, SectionBTotal, GrandTotal
    }

    class Game {
        private Player[] players;
        private int currentPlayerIndex;
        private Player currentPlayer;
        private Die[] Dice;
        private int playersFinished;
        private int numRolls;
        private Form1 form;
        private Label[] dieLabels;

        public Game(Form1 form) {
            //Player[] players = new Player[];
        }

        public void NextTurn() {
            //currentPlayer[currentPlayerIndex];
        }

        public void RollDice() {
            numRolls++;
        }

        public void HoldDie(int dieIndex) {
            form.GetDice()[dieIndex].Tag = "";
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
