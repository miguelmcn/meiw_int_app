using EuroMilApp.Infrastructure.Data.Model;
using EuroMilApp.Infrastructure.Options;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace EuroMilApp.Infrastructure.Data.Gateways
{
    public class CrediBankGateway(ApplicationOptions options
        , ILogger<CrediBankGateway> logger
        )
    {
        public async Task<DigitalCheckDataModel?> GetCheckAsync(string creditAccountId, int debitValue)
        {
            using HttpClient httpClient = new HttpClient();

            string apiUrl = options.Addresses.CredBankUrl
                .Replace("{credit_account_id}", creditAccountId)
                .Replace("{value}", debitValue.ToString());

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var check = await response.Content.ReadFromJsonAsync<DigitalCheckDataModel>();

                    if (check == null)
                    {
                        throw new Exception("Cannot deselize response");
                    }

                    return check;
                }
                else
                {
                    //logger.LogError($"Error: {response.StatusCode} - {response.ReasonPhrase}");

                    return null;
                }
            }
            catch (Exception ex)
            {
                //logger.LogCritical($"Exception: {ex.Message}");

                return null;
            }
        }
    }
}
