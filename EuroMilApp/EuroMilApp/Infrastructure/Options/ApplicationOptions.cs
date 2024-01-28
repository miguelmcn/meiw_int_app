namespace EuroMilApp.Infrastructure.Options
{
    public class ApplicationOptions
    {        
        public Addresses Addresses { get; set; }
    }

    public class Addresses
    {
        public string CredBankUrl { get; set; }
        public string EuroMilAddresss { get; set; }
    }
}
