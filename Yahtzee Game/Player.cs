using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    [Serializable]
    public class Player {
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

            bool isYahtzee = (scores[(int)score] as Combination).IsYahtzee;
            int numYahtzee = 0;
            for(int i=0; i<scores.Length;i++) {
                try {
                    int yahtzeeValue = 0;
                    switch (i) {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            yahtzeeValue = (scores[i] as CountingCombination).YahtzeeNumber;
                            break;
                        case 9:
                        case 10:
                        case 14:
                            yahtzeeValue = (scores[i] as TotalofDice).YahtzeeNumber;
                            break;
                        case 11:
                        case 12:
                        case 13:
                        case 15:
                            yahtzeeValue = (scores[i] as FixedScore).YahtzeeNumber;
                            break;
                    }
                    numYahtzee += yahtzeeValue;
                } catch (InvalidCastException e) {
                    continue;
                }
            }
            int j = 0;
            int[] count = new int[6];
            foreach(int value in dice) {
                count[value - 1]++;
            }
            
            if (isYahtzee) {
                //Bonus
                if (numYahtzee>1) {
                    scores[(int)ScoreType.YahtzeeBonus].Points += 100;
                    scores[(int)ScoreType.YahtzeeBonus].ShowScore();
                }

                //Joker
                foreach (int value in count) {
                    if (value == 5) {
                        break;
                    }
                    j++;
                }
                scores[(int)score].Points = (score == ScoreType.Yahtzee) ? 50:(scores[j].Done)?
                    (score==ScoreType.ThreeOfAKind|| score == ScoreType.FourOfAKind||score == ScoreType.Chance)?dice.Sum():
                    (score == ScoreType.LargeStraight)?40:(score == ScoreType.SmallStraight)?30:(score == ScoreType.FullHouse)?25:0:0;
            }

            scores[(int)score].Done = true;
            scores[(int)score].ShowScore();
            grandTotal += scores[(int)score].Points;
            DisplayTotals();

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

        private void DisplayTotals() {

            scores[(int)ScoreType.GrandTotal].Points = grandTotal;
            scores[(int)ScoreType.SubTotal].Points = 0;
            for (int i = 0; i < (int)ScoreType.SubTotal; i++) {
                scores[(int)ScoreType.SubTotal].Points += scores[i].Points;
            }
            scores[(int)ScoreType.SubTotal].ShowScore();
            if (scores[(int)ScoreType.SubTotal].Points >= 63) {
                scores[(int)ScoreType.BonusFor63Plus].Points = 35;
            }
            scores[(int)ScoreType.SubTotal].ShowScore();
            scores[(int)ScoreType.SectionATotal].Points = scores[(int)ScoreType.BonusFor63Plus].Points + scores[(int)ScoreType.SubTotal].Points;
            scores[(int)ScoreType.SectionATotal].ShowScore();

            scores[(int)ScoreType.SectionBTotal].Points = 0;
            for (int i = (int)ScoreType.ThreeOfAKind; i <= (int)ScoreType.YahtzeeBonus; i++) {
                scores[(int)ScoreType.SectionBTotal].Points += scores[i].Points;
            }
            scores[(int)ScoreType.SectionBTotal].ShowScore();
            scores[(int)ScoreType.GrandTotal].ShowScore();
        }
    }
}
