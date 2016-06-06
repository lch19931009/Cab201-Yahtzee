using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    [Serializable]
    abstract class Combination: Score {

        protected bool isYahtzee;// Would br depreciated by protected set in the property
        protected int yahtzeeNumber;//          "

        public bool IsYahtzee { get {return isYahtzee; } }
        public int YahtzeeNumber { get {return yahtzeeNumber; } }

        public Combination(Label combinationLabel): base(combinationLabel) {

        }

        public abstract void CalculateScore(int[] values);

        public void Sort(int[] values) {
            Array.Sort(values);
        }

        public void CheckForYahtzee(int[] values) {

        }

    }
}
