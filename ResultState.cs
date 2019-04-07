using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    class ResultState : ClearState, State {
        public new ClearState nextState(int stateEvent) {
            //Calculator
            Form calc = Application.OpenForms[0];
            TextBox resultText = calc.Controls["resultText"] as TextBox;

            switch (stateEvent) {
                //Cases 0-9
                case zeroEvent:
                case oneEvent:
                case twoEvent:
                case threeEvent:
                case fourEvent:
                case fiveEvent:
                case sixEvent:
                case sevenEvent:
                case eightEvent:
                case nineEvent:
                    //Replace Text Value
                    resultText.Text = stateEvent.ToString();
                    return new ClearState();
            }

            return new ResultState();
        }
    }
}
