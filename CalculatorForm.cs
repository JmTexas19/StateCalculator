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

        private void setState(ClearState nextState) {
            state = nextState;
        }

        private void zeroButton_Click(object sender, EventArgs e) {
            state.nextState(0);
        }

        private void oneButton_Click(object sender, EventArgs e) {
            state.nextState(1);
        }
    }
}
