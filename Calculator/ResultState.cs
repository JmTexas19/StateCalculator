using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    class ResultState : ClearState, State {
        //Operator and Operand
        string op, secondOperand;

        public ResultState(string op, string secondOperand) {
            this.op = op;
            this.secondOperand = secondOperand;
        }

        public new ClearState nextState(int stateEvent) {
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
                    //Replace Text Value
                    resultText.Text = stateEvent.ToString();
                    return new ClearState();

                //Clear Cases
                case ceEvent:
                    resultText.Text = "0";
                    return new ResultState(op, secondOperand);
                case cEvent:
                    resultText.Text = "0";
                    return new ClearState();

                //Operation Cases
                case addEvent:
                    return new NextOperandState("+", resultText.Text);
                case subtractEvent:
                    return new NextOperandState("-", resultText.Text);
                case multiplyEvent:
                    return new NextOperandState("x", resultText.Text);
                case divideEvent:
                    return new NextOperandState("/", resultText.Text);

                //Other Cases
                case negativeEvent:
                    if (!resultText.Text.Contains("-")) {
                        resultText.Text = resultText.Text.Insert(0, "-");
                    }
                    else {
                        resultText.Text = resultText.Text.Trim('-');
                    }
                    return new ResultState(op, secondOperand);

                case decimalEvent:
                    if (!resultText.Text.Contains('.')) {
                        resultText.Text = resultText.Text.Insert(resultText.Text.Length, ".");
                        return new ClearState(op, secondOperand);
                    }
                    else {
                        return new ClearState(op, secondOperand);
                    }

                case equalEvent:
                    //Trim end if . or 0 or .0
                    if (resultText.Text.Contains(".")) {
                        index = resultText.Text.IndexOf('.');
                        if (resultText.Text.Substring(index).Equals(".0") | resultText.Text.Substring(index).Equals(".")) {
                            resultText.Text = resultText.Text.TrimEnd('0', '.');
                        }
                    }
                        resultText.Text = previousOperation(resultText);

                    return new ResultState(op, secondOperand);

                case rootEvent:
                    resultText.Text = Math.Sqrt(Double.Parse(resultText.Text)).ToString();
                    return new ResultState(op, secondOperand);

                case reciprocolEvent:
                    resultText.Text = (1 / Double.Parse(resultText.Text)).ToString();
                    return new ResultState(op, secondOperand);

                case squareEvent:
                    resultText.Text = Math.Pow(Double.Parse(resultText.Text), 2).ToString();
                    return new ResultState(op, secondOperand);
            }

            return new ResultState(op, secondOperand);
        }

        //Calculate Previous Operation
        private string previousOperation(TextBox resultText) {
            double result = Double.Parse(resultText.Text);

            if (op.Contains("+")) {
                return (Double.Parse(secondOperand) + result).ToString();
            }
            else if (op.Contains("-")) {
                return (result - (Double.Parse(secondOperand))).ToString();
            }
            else if (op.Contains("x")) {
                return (Double.Parse(secondOperand) * result).ToString();
            }
            else if (op.Contains("/")) {
                return (result / (Double.Parse(secondOperand))).ToString();
            }
            else {
                return resultText.Text;
            }
        }
    }
}
