using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECTunes.Util {
    class Indicator {
        public enum IndicatorSide {
            LEFT,
            RIGHT,
            OFF
        };
        public static IndicatorSide blinking = IndicatorSide.OFF;
        public void Blink(Button b, Color c1, Color c2, int timeInMs, IndicatorSide ind) {
            blinking = ind;
            while (blinking == ind) {
                b.BackColor = c1;
                Thread.Sleep(timeInMs);
                b.BackColor = c2;
                Thread.Sleep(timeInMs);
            }
        }
    }
}
