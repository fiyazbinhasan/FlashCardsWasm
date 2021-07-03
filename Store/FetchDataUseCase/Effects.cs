using Fluxor;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static FlashCardsWasm.Store.FetchDataUseCase.Actions;
using FlashCardsWasm.Models;

namespace FlashCardsWasm.Store.FetchDataUseCase
{
    public class Effects
    {
        private readonly HttpClient _httpClient;

        public Effects(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [EffectMethod]
        public async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
                dispatcher.Dispatch(new FetchDataSuccessAction(forecasts));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }
    }
}
