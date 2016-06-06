using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    [Serializable]
    class FixedScore : Combination {
        /*
         * Small Straight - 30
         * Large Straight - 40
         * Yahtzee - 50
         * Full House - 25
         */

        private ScoreType scoreType;

        public FixedScore(Label combinationLabel) : base(combinationLabel) {
            scoreType = (ScoreType)combinationLabel.Tag;
        }

        public override void CalculateScore(int[] values) {
            Sort(values);
            int[] count = new int[6];
            foreach (int value in values) {
                count[value - 1]++;

            }

            if ((count[0]>=1&&count[0]<=2)&& (count[1] >= 1 && count[1] <= 2)&& (count[2] >= 1 && count[2] <= 2)&& (count[3] >= 1 && count[3] <= 2)
                || (count[1] >= 1 && count[1] <= 2) && (count[2] >= 1 && count[2] <= 2) && (count[3] >= 1 && count[3] <= 2) && (count[4] >= 1 && count[4] <= 2)
                || (count[2] >= 1 && count[2] <= 2) && (count[3] >= 1 && count[3] <= 2) && (count[4] >= 1 && count[4] <= 2) && (count[5] >= 1 && count[5] <= 2)) {
                Points = (scoreType == ScoreType.SmallStraight) ? 30 : 0;
            }

            Sort(count);
            if (count.Last() == 3) {//Full House
                if (count[count.Length - 2] == 2 && scoreType == ScoreType.FullHouse) {
                    Points = 25;
                }
            } else if (count.Last() == 5) {//Yahtzee
                Points = (scoreType == ScoreType.Yahtzee) ? 50 : 0;
            } else {//Large Straight
                if (count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1&&count[5] == 1) {
                    Points = (scoreType == ScoreType.SmallStraight) ? 30 : (scoreType == ScoreType.LargeStraight) ? 40 : 0;
                }
            }
        }

        public void PlayerYahtzeeJoker() {

        }
    }
}
