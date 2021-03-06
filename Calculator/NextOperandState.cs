﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    class NextOperandState : ClearState, State {
        //Operator
        string op, firstOperand;

        public NextOperandState(string op, string firstOperand) {
            this.op = op;
            this.firstOperand = firstOperand;
        }

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
                    //Replace Result
                    resultText.Text = stateEvent.ToString();
                    return new ClearState(op, firstOperand);

                //Operation Cases
                case addEvent:
                    return new NextOperandState("+", firstOperand);
                case subtractEvent:
                    return new NextOperandState("-", firstOperand);
                case multiplyEvent:
                    return new NextOperandState("*", firstOperand);
                case divideEvent:
                    return new NextOperandState("/", firstOperand);

                //Clear Cases
                case ceEvent:
                    resultText.Text = "0";
                    return new ClearState(op, firstOperand);
                case cEvent:
                    resultText.Text = "0";
                    return new ClearState();

                //Other Cases
                case decimalEvent:
                    resultText.Text = "0.";
                    return new ClearState(op, firstOperand);

                case negativeEvent:
                    if (!resultText.Text.Contains("-")) {
                        resultText.Text = resultText.Text.Insert(0, "-");
                    }
                    else {
                        resultText.Text = resultText.Text.Trim('-');
                    }
                    return new ClearState(op, firstOperand);

                case equalEvent:
                    resultText.Text = calculateOperation(resultText);
                    return new ResultState(op, firstOperand);

                case rootEvent:
                    resultText.Text = Math.Sqrt(Double.Parse(resultText.Text)).ToString();
                    return new ClearState(op, firstOperand);

                case reciprocolEvent:
                    resultText.Text = (1 / Double.Parse(resultText.Text)).ToString();
                    return new ClearState(op, firstOperand);

                case squareEvent:
                    resultText.Text = Math.Pow(Double.Parse(resultText.Text), 2).ToString();
                    return new ClearState(op, firstOperand);
            }

            return new NextOperandState(op, firstOperand);
        }

        //Calculate Operation
        private string calculateOperation(TextBox resultText) {
            double secondOperand = Double.Parse(firstOperand);

            if (op.Contains("+")) {
                return (Double.Parse(firstOperand) + secondOperand).ToString();
            }
            else if (op.Contains("-")) {
                return (Double.Parse(firstOperand) - secondOperand).ToString();
            }
            else if (op.Contains("x")) {
                return (Double.Parse(firstOperand) * secondOperand).ToString();
            }
            else if (op.Contains("/")) {
                return (Double.Parse(firstOperand) / secondOperand).ToString();
            }
            else {
                return resultText.Text;
            }
        }
    }
}
