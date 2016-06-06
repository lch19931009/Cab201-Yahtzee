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
        private static Random random = new Random();
        private static string rollFileName = Game.defaultPath + "\\basictestrolls.txt";
        private static StreamReader rollFile = new StreamReader(rollFileName);
        private static bool DEBUG = true;

        public int FaceValue {
            get {
                return faceValue;
            }
            set {
                faceValue = value;
            }
        }

        public bool Active {
            get {
                return active;
            } set {
                active = value;
            }
        }


        public Die(Label lblDieLabel) {
            label = lblDieLabel;
            this.active = true;
        }

        public void Roll() {
            if (!DEBUG) {
                faceValue = random.Next(1, 7);
            } else {
                faceValue = int.Parse(rollFile.ReadLine());
            }

            Image value;
            switch (faceValue) {
                case 1:
                    value = new Bitmap(Properties.Resources._1);
                    break;
                case 2:
                    value = new Bitmap(Properties.Resources._2);
                    break;
                case 3:
                    value = new Bitmap(Properties.Resources._3);
                    break;
                case 4:
                    value = new Bitmap(Properties.Resources._4);
                    break;
                case 5:
                    value = new Bitmap(Properties.Resources._5);
                    break;
                case 6:
                    value = new Bitmap(Properties.Resources._6);
                    break;
                default:
                    value = null;
                    break;
            }

            label.Image = value;
            label.Tag = faceValue;
            label.Refresh();
        }

        public void Load(Label lblDieLabel) {
            this.label = lblDieLabel;
            if (faceValue == 0) {
                label.Text = string.Empty;
            } else {
                label.Text = faceValue.ToString();
            }
        }

    }
}
