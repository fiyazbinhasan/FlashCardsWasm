using FlashCardsWasm.Models;

namespace FlashCardsWasm.Store.FetchDataUseCase
{
    public class Actions
    {
        public record FetchDataAction();
        public record FetchDataSuccessAction(WeatherForecast[] Forecasts);
        public record FetchDataErrorAction(string Error);
    }
}
