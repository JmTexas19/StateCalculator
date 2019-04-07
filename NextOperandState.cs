using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class NextOperandState : State {
        public ClearState nextState(int stateEvent) {
            return new ClearState();
        }
    }
}
