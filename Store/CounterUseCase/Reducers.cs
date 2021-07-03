using Fluxor;

namespace FlashCardsWasm.Store.CounterUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
               state with { Count = state.Count + 1 };

        [ReducerMethod]
        public static CounterState ReduceIncrementCounterByAction(CounterState state, IncrementCounterByAction action) =>
               state with { Count = state.Count + action.IncrementBy };
    }
}
