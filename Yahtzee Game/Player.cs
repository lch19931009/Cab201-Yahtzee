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
        private int grandTotal = 0;

        public Player(string name, Label[] scoreTotals) {
            //Label[] scoreTotals = new Label[(int)ScoreType.GrandTotal + 1];
            //this.name = name;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public void ScoreCombination(ScoreType score, int[] dice) {
        }

        public bool IsAvailable(ScoreType score) {
            return true;
        }

        public void ShowScores() {

        }

        public bool IsFinished() {
            return true;
        }

        public void Load(Label[] labels) {

        }
    }
}
