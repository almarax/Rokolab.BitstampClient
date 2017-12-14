namespace Rokolab.BitstampClient.Models
{
    public class BalanceResponse
    {
        //balance
        public string usd_balance { get; set; }
        public string eur_balance { get; set; }
        public string btc_balance { get; set; }
        public string eth_balance { get; set; }
        public string ltc_balance { get; set; }
        public string xrp_balance { get; set; }
        public string bch_balance { get; set; }        
        //reserved
        public string usd_reserved { get; set; }
        public string eur_reserved { get; set; }
        public string btc_reserved { get; set; }
        public string eth_reserved { get; set; }
        public string ltc_reserved { get; set; }
        public string xrp_reserved { get; set; }
        public string bch_reserved { get; set; }
        //avalable
        public string usd_available { get; set; }
        public string eur_available { get; set; }
        public string btc_available { get; set; }
        public string eth_available { get; set; }
        public string ltc_available { get; set; }
        public string xrp_available { get; set; }
        public string bch_available { get; set; }
        
        public string fee { get; set; }
    }
}