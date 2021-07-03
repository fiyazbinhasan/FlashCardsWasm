using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashCardsWasm.Store.CounterUseCase
{
    public record IncrementCounterAction();
    public record IncrementCounterByAction(int IncrementBy);
}
