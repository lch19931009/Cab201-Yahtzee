using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    class Player {
        private string name;
        private int combinationsToDo;
        private Score[] scores = new Score[(int)ScoreType.GrandTotal + 1];
        private int grandTotal;

        public Player(string name, Label[] labels) {
            Label[] scoreTotals = new Label[(int)ScoreType.GrandTotal + 1];
            this.name = name;
        }

        public string Name {get; protected set;}

        public void ScoreCombination(ScoreType score, int[] dice) {
        }

        public int GrandTotal { get; protected set; }

        public bool IsAvailable(ScoreType) {
            return true;
        }

        public void ShowScores() {
        }

        public bool IsFinished() {
            /*if () {
                return true;
            }
            */
            return false;
        }

        public void Load(Label[] labels) {

        }
    }
}
