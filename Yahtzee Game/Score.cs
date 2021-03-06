﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Game {
    [Serializable]
    abstract class Score {

        private int points;// Would be depreciated by protected set in the properties
        [NonSerialized]
        private Label label;
        protected bool done; //         "

        public int Points {
            get { return points; }
            set { points =value; }
        }

        public bool Done {
            get { return done; }
            set { done =value; }
        }

        public Score(Label lblScoreLabel) {
            Load(lblScoreLabel);

        }

        public void ShowScore() {
            label.Text = (done) ? points.ToString() : "";
        }

        public void Load(Label lblScoreLabel) {
            this.label = lblScoreLabel;
        }


    }
}
