using AutoBuyer.Data;
using AutoBuyer.Requests;

namespace AutoBuyer.Items
{
    internal class LinkItem
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Price { get; set; }

        public RequestType RequestType { get; set; }

        public LinkItem(string name, string key, string price)
        {
            Name = name;
            Key = key;
            Price = price;
        }

        public string GetRequestTypeAsApi()
        {
            string requestUrl = string.Empty;

            switch (RequestType)
            {
                case RequestType.Buy:
                    requestUrl = Database.BuyRequest;
                    break;
                case RequestType.Order:
                    requestUrl = Database.OrderRequest;
                    break;
                case RequestType.Balance:
                    requestUrl = Database.BalanceRequest;
                    break;
            }

            return requestUrl;
        }
    }
}
