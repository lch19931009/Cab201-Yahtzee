using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Yahtzee_Game {
    class Die {

        private int faceValue;
        private bool active;
        private Label label;
        private static Random random;
        private StreamReader rollFile;
        private static bool DEBUG;

        public int FaceValue { get; private set; }
        public bool Active { get; private set; }


        public Die(Label lblDieLabel) {
            label = lblDieLabel;
        }

        public void Roll() {
            faceValue = random.Next(1, 6);
            FaceValue = faceValue;

            Image value;
            switch (faceValue) {
                case 1:
                    value = new Bitmap("1.png");
                    break;
                case 2:
                    value = new Bitmap("2.png");
                    break;
                case 3:
                    value = new Bitmap("3.png");
                    break;
                case 4:
                    value = new Bitmap("4.png");
                    break;
                case 5:
                    value = new Bitmap("5.png");
                    break;
                case 6:
                    value = new Bitmap("6.png");
                    break;
                default:
                    value = null;
                    break;
            }

            label.Image = value;
        }

        public void Load(Label lblDieLabel) {

        }

    }
}
