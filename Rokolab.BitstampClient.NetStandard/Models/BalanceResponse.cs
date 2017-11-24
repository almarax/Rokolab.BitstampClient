namespace Rokolab.BitstampClient.Models
{
    public class BalanceResponse
    {
        public string fee { get; set; }

        //balance
        public string usd_balance { get; set; }
        public string eur_balance { get; set; }
        public string btc_balance { get; set; }

        //reserved
        public string usd_reserved { get; set; }
        public string btc_reserved { get; set; }
        public string eur_reserved { get; set; }

        //available
        public string usd_available { get; set; }
        public string btc_available { get; set; }
        public string eur_available { get; set; }
    }
}