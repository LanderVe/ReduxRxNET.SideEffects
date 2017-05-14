using ReduxRxNET.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxRxNET.SideEffects.Tests.Reducers
{
  //reducer
  class IncrementReducer : Reducer<int>
  {
    public override int Reduce(int state = 0, object action = null)
    {
      switch (action)
      {
        case IncrementAction incrementAction:
          return ++state;
        case DecrementAction decrementAction:
          return --state;
        default:
          return state;
      }
    }

    //actions
    internal class IncrementAction { }
    internal class DecrementAction { }
    internal class NonExistingAction { }

  }
}
