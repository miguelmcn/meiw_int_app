using EuroMilApp.Infrastructure.Options;
using EuroMilAppGateway;
using Grpc.Net.Client;

namespace EuroMilApp.Infrastructure.Data.Gateways
{
    public class EuroMilRegisterGateway(ApplicationOptions applicationOptions)
    {
        public async Task<RegisterReply> RegisterAsync(string key, string? checkId)
        {
            var register = new RegisterRequest
            {
                Checkid = checkId,
                Key = key
            };

            using var channel = GrpcChannel.ForAddress(applicationOptions.Addresses.EuroMilAddresss);
            var client = new Euromil.EuromilClient(channel);

            return await client.RegisterEuroMilAsync(register);
        }
    }
}
