using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
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
            if (values[2] == values[1] + 1 && values[3] == values[2] - 1) {
                Points = (((values[1]==values[0]+1)||(values[3]==values[4]-1))&&scoreType==ScoreType.SmallStraight)?30:
                    (((values[1] == values[0] + 1) && (values[3] == values[4] - 1)) && scoreType == ScoreType.LargeStraight) ? 40:0;
            }
            else if (values.Sum()/5 == values[0] && values.Sum()/5 == values[4]) { //Probability of a number occuring only 4 times, while still
                                                                                   //being 5 times that number is impossible
                Points = (scoreType == ScoreType.Yahtzee) ? 50 : 0;
            }
            else if (scoreType == ScoreType.FullHouse) {
                Points = (values[0]==values[1]&&values[1]==values[2]||values[0]==values[1])&&
                    (values[3]==values[4]||(values[2]==values[3]&&values[3]==values[4]))? 25 : 0;
            }
        }

        public void PlayerYahtzeeJoker() {

        }
    }
}
