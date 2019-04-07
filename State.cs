using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    interface State {
        ClearState nextState(int stateEvent);
    }
}
