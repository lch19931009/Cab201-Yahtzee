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
        private Score[] scores;
        private int grandTotal = 0;

        public Player(string name, Label[] scoreTotals) {
            this.name = name;
            scores = new Score[Form1.NUM_SCORES_LOWER + Form1.NUM_SCORES_UPPER+Form1.NUM_TOTALS-1];

            for (int i = 0; i < scores.Length; i++) {
                switch ((int)scoreTotals[i].Tag) {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        scores[i] = new CountingCombination(scoreTotals[i]);
                        break;
                    case 9:
                    case 10:
                    case 14:
                        scores[i] = new TotalofDice((ScoreType)scoreTotals[i].Tag, scoreTotals[i]);
                        break;
                    case 11:
                    case 12:
                    case 13:
                    case 15:
                        scores[i] = new FixedScore(scoreTotals[i]);
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 16:
                    case 17:
                    case 18:
                        scores[i] = new BonusOrTotal(scoreTotals[i]);
                        break;
                }
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public int GrandTotal {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        public void ScoreCombination(ScoreType score, int[] dice) {
            switch ((int)score) {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    (scores[(int)score] as CountingCombination).CalculateScore(dice);
                    break;
                case 9:
                case 10:
                case 14:
                    (scores[(int)score] as TotalofDice).CalculateScore(dice);
                    break;
                case 11:
                case 12:
                case 13:
                case 15:
                    (scores[(int)score] as FixedScore).CalculateScore(dice);
                    break;
            }
            scores[(int)score].Done = true;
            scores[(int)score].ShowScore();
        }

        public bool IsAvailable(ScoreType score) {
            return true;
        }

        public void ShowScores() {

        }

        public bool IsFinished() {
            return true;
        }

        public void Load(Label[] scoreTotals) {
            for (int i = 0; i < scores.Length; i++) {
                scores[i].Load(scoreTotals[i]);
            }
        }
    }
}
