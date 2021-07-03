using Fluxor;

namespace FlashCardsWasm.Store.CounterUseCase
{
    public record CounterState(int Count);
    public class Feature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new(0);
    }
}
