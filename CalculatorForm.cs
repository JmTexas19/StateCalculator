using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Calculator : Form {
        State state;

        public Calculator() {
            setState(new ClearState());
            InitializeComponent();
        }

        //Set state of the calculator
        private void setState(ClearState nextState) {
            state = nextState;
        }

        //Buttons
        private void CEButton_Click(object sender, EventArgs e) {
            setState(state.nextState(17));
        }

        private void CButton_Click(object sender, EventArgs e) {
            setState(state.nextState(18));
        }

        private void zeroButton_Click(object sender, EventArgs e) {
            setState(state.nextState(0));
        }

        private void oneButton_Click(object sender, EventArgs e) {
            setState(state.nextState(1));
        }

        private void twoButton_Click(object sender, EventArgs e) {
            setState(state.nextState(2));
        }

        private void threeButton_Click(object sender, EventArgs e) {
            setState(state.nextState(3));
        }

        private void fourButton_Click(object sender, EventArgs e) {
            setState(state.nextState(4));
        }

        private void fiveButton_Click(object sender, EventArgs e) {
            setState(state.nextState(5));
        }

        private void sixButton_Click(object sender, EventArgs e) {
            setState(state.nextState(6));
        }

        private void sevenButton_Click(object sender, EventArgs e) {
            setState(state.nextState(7));
        }

        private void eightButton_Click(object sender, EventArgs e) {
            setState(state.nextState(8));
        }

        private void nineButton_Click(object sender, EventArgs e) {
            setState(state.nextState(9));
        }

        private void negativeButton_Click(object sender, EventArgs e) {
            setState(state.nextState(10));
        }

        private void decimalButton_Click(object sender, EventArgs e) {
            setState(state.nextState(11));
        }

        private void backButton_Click(object sender, EventArgs e) {
            setState(state.nextState(19));
        }

        private void equalButton_Click(object sender, EventArgs e) {
            setState(state.nextState(12));
        }

        private void rootButton_Click(object sender, EventArgs e) {
            setState(state.nextState(21));
        }
    }
}
