using Fluxor;
using FlashCardsWasm.Models;

namespace FlashCardsWasm.Store.FetchDataUseCase
{
    public record FetchDataState(bool IsLoading, WeatherForecast[] Forecasts, string Error);
    public class Feature : Feature<FetchDataState>
    {
        public override string GetName() => "FetchData";
        protected override FetchDataState GetInitialState() => new(false, null, null);
    }
}
