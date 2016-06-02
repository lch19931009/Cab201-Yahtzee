using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    class CountingCombination : Combination {

        private int dieValue;

        public CountingCombination(Label combinationLabel) : base(combinationLabel) {
            dieValue = (int)(ScoreType)combinationLabel.Tag;
        }
        
        public override void CalculateScore(int[] values) {
            foreach(int value in values) {
                if(value == dieValue) {
                    Points+=value;
                }
            }
        }
    }
}
