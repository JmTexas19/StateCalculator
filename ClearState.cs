﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    class ClearState : State {
        //Events
        public const int zeroEvent = 0;
        public const int oneEvent = 1;
        public const int twoEvent = 2;
        public const int threeEvent = 3;
        public const int fourEvent = 4;
        public const int fiveEvent = 5;
        public const int sixEvent = 6;
        public const int sevenEvent = 7;
        public const int eightEvent = 8;
        public const int nineEvent = 9;
        public const int negativeEvent = 10;
        public const int decimalEvent = 11;
        public const int equalEvent = 12;
        public const int plusEvent = 13;
        public const int minusEvent = 14;
        public const int timesEvent = 15;
        public const int divideEvent = 16;
        public const int ceEvent = 17;
        public const int cEvent = 18;
        public const int backspaceEvent = 19;
        public const int percentEvent = 20;
        public const int rootEvent = 21;
        public const int squareEvent = 22;
        public const int reciprocolEvent = 23;

        //Process next event
        public ClearState nextState(int stateEvent) {
            //Calculator
            Form calc = Application.OpenForms[0];
            TextBox resultText = calc.Controls["resultText"] as TextBox;
            int index;

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

                case equalEvent:
                    //Trim end if . or 0 or .0
                    if (resultText.Text.Contains(".")) {
                        index = resultText.Text.IndexOf('.');
                        if (resultText.Text.Substring(index).Equals(".0") | resultText.Text.Substring(index).Equals(".")) {
                            resultText.Text = resultText.Text.TrimEnd('0', '.');
                        }
                    }

                    return new ResultState();

                case rootEvent:
                    //Trim end if . or 0 or .0
                    if (resultText.Text.Contains(".")) {
                        index = resultText.Text.IndexOf('.');
                        if (resultText.Text.Substring(index).Equals(".0") | resultText.Text.Substring(index).Equals(".")) {
                            resultText.Text = resultText.Text.TrimEnd('0', '.');
                        }
                    }

                    //Root Result
                    resultText.Text = Math.Sqrt(Double.Parse(resultText.Text)).ToString();
                    return new ResultState();

                case reciprocolEvent:
                    //Trim end if . or 0 or .0
                    if (resultText.Text.Contains(".")) {
                        index = resultText.Text.IndexOf('.');
                        if (resultText.Text.Substring(index).Equals(".0") | resultText.Text.Substring(index).Equals(".")) {
                            resultText.Text = resultText.Text.TrimEnd('0', '.');
                        }
                    }

                    //Recipricol
                    resultText.Text = (1 / Double.Parse(resultText.Text)).ToString();
                    return new ResultState();

                case squareEvent:
                    //Trim end if . or 0 or .0
                    if (resultText.Text.Contains(".")) {
                        index = resultText.Text.IndexOf('.');
                        if (resultText.Text.Substring(index).Equals(".0") | resultText.Text.Substring(index).Equals(".")) {
                            resultText.Text = resultText.Text.TrimEnd('0', '.');
                        }
                    }

                    //Square
                    resultText.Text =  Math.Pow(Double.Parse(resultText.Text), 2).ToString();
                    return new ResultState();
            }

            return new ClearState();
        }
    }
}
