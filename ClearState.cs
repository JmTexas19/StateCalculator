using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    class ClearState : State {
        //Events
        const int zeroEvent = 0;
        const int oneEvent = 1;
        const int twoEvent = 2;
        const int threeEvent = 3;
        const int fourEvent = 4;
        const int fiveEvent = 5;
        const int sixEvent = 6;
        const int sevenEvent = 7;
        const int eightEvent = 8;
        const int nineEvent = 9;
        const int negativeEvent = 10;
        const int decimalEvent = 11;
        const int equalEvent = 12;
        const int plusEvent = 13;
        const int minusEvent = 14;
        const int timesEvent = 15;
        const int divideEvent = 16;
        const int ceEvent = 17;
        const int cEvent = 18;
        const int backspaceEvent = 19;
        const int percentEvent = 20;
        const int rootEvent = 21;
        const int squareEvent = 22;
        const int recipricolEvent = 23;

        //Process next event
        public ClearState nextState(int stateEvent) {
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
                    //Append String to end
                    if (!resultText.Text.Equals("0")) {
                        resultText.Text = resultText.Text.Insert(resultText.Text.Length, stateEvent.ToString());
                        return new ClearState();
                    }
                    else {
                        resultText.Text = stateEvent.ToString();
                        return new ClearState();
                    }

                //Clear Cases
                case ceEvent:
                case cEvent:
                    resultText.Text = "0";
                    return new ClearState();

                //Other Cases
                case negativeEvent:
                    if (!resultText.Text.Contains("-")) {
                        resultText.Text = resultText.Text.Insert(0, "-");
                    }
                    else {
                        resultText.Text = resultText.Text.Trim('-');
                    }
                    return new ClearState();
                case decimalEvent:
                    if (!resultText.Text.Contains('.')) { 
                        resultText.Text = resultText.Text.Insert(resultText.Text.Length, ".");
                        return new ClearState();
                    }
                    else {
                        return new ClearState();
                    }
                case backspaceEvent:
                    if (!resultText.Text.Equals("0")) {
                        //Make sure text box isn't left blank
                        if (resultText.Text.Length <= 1) {
                            resultText.Text = "0";
                        }
                        else {
                            resultText.Text = resultText.Text.Remove(resultText.Text.Length - 1, 1);
                        }

                        return new ClearState();
                    }
                    else {
                        return new ClearState();
                    }
            }

            return new ClearState();
        }
    }
}
