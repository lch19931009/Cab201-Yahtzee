using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    [Serializable]
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
            int[] count;
            CheckForYahtzee(values);
            Sort(values);
            if (numberOfOneKind != 5) {
                count = CountDice(values);
                for (int i = 0; i < count.Length; i++) {
                    if (count[i] >= numberOfOneKind) {
                        Points = values.Sum();
                        break;
                    }
                }
            } 
            else {
                Points = values.Sum();
            }
        }
    }
}
