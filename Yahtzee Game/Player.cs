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
            scores = new Score[Form1.NUM_SCORES_LOWER + Form1.NUM_SCORES_UPPER+Form1.NUM_TOTALS];

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
            grandTotal += scores[(int)score].Points;
            scores[(int)ScoreType.GrandTotal].Points = grandTotal;
            scores[(int)ScoreType.SubTotal].Points = 0;
            for (int i = 0; i < (int)ScoreType.SubTotal; i++) {
                scores[(int)ScoreType.SubTotal].Points+=scores[i].Points;
            }
            scores[(int)ScoreType.SubTotal].ShowScore();
            if(scores[(int)ScoreType.SubTotal].Points >= 63) {
                scores[(int)ScoreType.BonusFor63Plus].Points = 35;
            }
            scores[(int)ScoreType.SubTotal].ShowScore();
            scores[(int)ScoreType.SectionATotal].Points = scores[(int)ScoreType.BonusFor63Plus].Points+ scores[(int)ScoreType.SubTotal].Points;
            scores[(int)ScoreType.SectionATotal].ShowScore();

            for (int i = (int)ScoreType.ThreeOfAKind; i <= (int)ScoreType.YahtzeeBonus; i++) {
                scores[(int)ScoreType.SectionBTotal].Points += scores[i].Points;
            }
            scores[(int)ScoreType.SectionBTotal].ShowScore();
            scores[(int)ScoreType.GrandTotal].ShowScore();

        }

        public bool IsAvailable(ScoreType score) {
            return !scores[(int)score].Done;
        }

        public void ShowScores() {
            for (int i = 0; i <= (int)ScoreType.GrandTotal; i++) {
                scores[i].ShowScore();
            }
        }

        public bool IsFinished() {
            foreach(Score points in scores) {
                if (!points.Done) {
                    return false;
                }
            }
            return true;
        }

        public void Load(Label[] scoreTotals) {
            for (int i = 0; i < scores.Length; i++) {
                scores[i].Load(scoreTotals[i]);
            }
        }
    }
}
