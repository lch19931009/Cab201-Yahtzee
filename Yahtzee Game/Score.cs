using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    abstract class Score {
        /*
         *  -points : int
            -label : Label
            #done : bool
         */

        private int points;
        private Label label;
        protected bool done;

        public int Points { get; private set; }
        public bool Done { get; private set; }

        /*
         * +Score(Label)
         * +Points : int {property}
         * +Done : bool {property}
         * +ShowScore()
         * +Load(Label)
         */

        public Score(Label lblScoreLabel) {

        }

        public void ShowScore() {
            /*
             * ShowScore will display the number of points on the associated label on the GUI, but only
             * if this Score has been attempted, otherwise no points are displayed (note:  display nothing,
             * do not display zero).
             */
            label.Text = (done) ? points.ToString() : "";

        }

        public void Load(Label lblScoreLabel) {

        }


    }
}
