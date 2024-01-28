using EuroMilApp.Infrastructure.Data.Gateways;
using EuroMilApp.Infrastructure.Data.Model;

namespace EuroMilApp.Domain
{
    public class BetService(CrediBankGateway bankGateway, EuroMilRegisterGateway registerGateway)
    {
        public async Task<(bool Success, string Message)> Bet(string account, string key)
        {
            DigitalCheckDataModel check;

            try
            {
                check = await bankGateway.GetCheckAsync(account, 10);
                
                if (check is null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                return (false, "Falha ao debitar valor da aposta.");
            }


            try
            {
                var bet = await registerGateway.RegisterAsync(key, check.CheckID);

                if (bet.Message.Contains("Error"))
                {
                    if (bet.Message.Contains("Key is not Valid"))
                    {
                        return (false, "Erro ao registar aposta, chave inválida");
                    }
                    
                    throw new Exception(bet.Message);
                }

                return (true, $"Aposta ({key}) a utilizar cheque ({check.CheckID}) registada com sucesso!");
            }
            catch (Exception ex)
            {
                return (false, "Falha ao registar aposta. " + ex.Message);
            }
        }
    }
}
