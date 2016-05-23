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

        public Game(Form1) {
            Player[] players = new Player[2];
            currentPlayerIndex = 1;
            currentPlayer = 1;
            //Dice
        }

        public void NextTurn() {

        }

        public void RollDice() {

        }

        public int HoldDie() {

        }

        public int ReleaseDie() {

        }

        public ScoreType ScoreCombination() {

        }

        public Game static Load(Form1) {

        }

        public Save() {

        }
    }
}
