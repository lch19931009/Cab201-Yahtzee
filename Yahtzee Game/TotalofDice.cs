using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    class TotalofDice : Combination {

        private int numberOfOneKind;

        public TotalofDice(ScoreType type, Label combinationLabel) : base(combinationLabel) {
            switch (type) {
                case ScoreType.ThreeOfAKind:
                    numberOfOneKind = 3;
                    break;
                case ScoreType.FourOfAKind:
                    numberOfOneKind = 4;
                    break;
                case ScoreType.Chance:
                    numberOfOneKind = 5;
                    break;
                default:
                    numberOfOneKind = 5;
                    break;
            }
        }

        public override void CalculateScore(int[] values) {
            int[] count = new int[Form1.NUM_DICE];
            Sort(values);
            if (numberOfOneKind != 5) {
                foreach (int value in values) {
                    count[value - 1]++;
                }
                for (int i = 0; i < count.Length; i++) {
                    if (count[i] == numberOfOneKind) {
                        Points = i+1 * numberOfOneKind;
                        break;
                    }
                }
            } else {
                foreach(int value in values) {
                    Points += value;
                }
            }
        }
    }
}
