using AutoBuyer.Items;

namespace AutoBuyer.Data
{
    internal class Database
    {
        public const string BaseUrl = "https://market.csgo.com/api/v2/";
        public const string KeyUrl = "?key=";
        public const string NameUrl = "&hash_name=";
        public const string PriceUrl = "&price=";

        public const string BuyRequest = "buy";
        public const string OrderRequest = "set-order";
        public const string BalanceRequest = "get-money";

        public LinkItem Link { get; protected set; }

        public Database() => Link = new LinkItem(BaseUrl, NameUrl, PriceUrl);

    }
}
