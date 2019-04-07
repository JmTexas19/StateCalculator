using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class Clear : State {
        int zeroEvent = 0;
        int oneEvent = 1;
        int twoEvent = 2;
        int threeEvent = 3;
        int fourEvent = 4;
        int fiveEvent = 5;
        int sixEvent = 6;
        int sevenEvent = 7;
        int eightEvent = 8;
        int nineEvent = 9;
        int negativeEvent = 10;
        int decimalEvent = 11;
        int equalEvent = 12;
        int plusEvent = 13;
        int minusEvent = 14;
        int timesEvent = 15;
        int divideEvent = 16;
        int CEEvent = 17;
        int CEvent = 18;
        int backspaceEvent = 19;
        int percentEvent = 20;
        int rootEvent = 21;
        int squareEvent = 22;
        int recipricolEvent = 23;

        //Process next event
        public void nextState(int stateEvent) {

        }
    }
}
