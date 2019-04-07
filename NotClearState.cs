using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class NotClearState : State {
        public ClearState nextState(int stateEvent) {
            return new ClearState();
        }
    }
}
