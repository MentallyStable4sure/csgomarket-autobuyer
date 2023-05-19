using System.Net;
using AutoBuyer.Data;
using AutoBuyer.Data.Model;
using AutoBuyer.Items;

namespace AutoBuyer.Requests
{
    internal class RequestsHandler
    {
        public const string UnexpectedError = "Unexpected error occurred while accessing URL, check site availability.";
        public const string DeserializationError = "Couldnt de-sereialize JSON response or site isnt responding";

        public const string ConnectedMessage = "Sending request...";
        public const string ParsingMessage = "Parsing JSON response...";

        public FeedbackHandler FeedbackHandler { get; protected set; }

        public RequestsHandler(FeedbackHandler customFeedbackHandler = null)
        {
            FeedbackHandler = new FeedbackHandler();
            if (customFeedbackHandler != null) FeedbackHandler = customFeedbackHandler;
        }

        /// <summary>
        /// Sends request to a given uri and return json string response
        /// </summary>
        /// <param name="client">Http Client who is sending request</param>
        /// <param name="uri">URL to knock with request</param>
        /// <returns>json response as plain text, in case of error returns a string.Empty</returns>
        public async Task<string> SendRequest(HttpClient client, Uri uri)
        {
            FeedbackHandler.UpdateFeedback(ConnectedMessage);

            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, uri));

            if (response.StatusCode != HttpStatusCode.OK)
            {
                FeedbackHandler.UpdateFeedback($"{UnexpectedError} | HttpStatusCode: {response.StatusCode.ToString()}");
                return string.Empty;
            }

            FeedbackHandler.UpdateFeedback(ParsingMessage);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task SendMarketRequest<T>(HttpClient client, Uri uri, Action<T> onComplete = null)
        {
            var result = await SendRequest(client, uri);

            var responseResult = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);

            if (responseResult == null) FeedbackHandler.UpdateFeedback(DeserializationError);

            onComplete?.Invoke(responseResult);
        }

        public static Uri UpdateLinkAccordingToRequest(LinkItem linkItem)
        {
            string itemRelatedAction = $"{Database.NameUrl}{linkItem.Name}{Database.PriceUrl}{linkItem.Price}";

            //if we wanna check our balance we dont need item name or item price variables
            if (linkItem.RequestType == RequestType.Balance) itemRelatedAction = string.Empty;

            string link = $"{Database.BaseUrl}{linkItem.GetRequestTypeAsApi()}{Database.KeyUrl}{linkItem.Key}{itemRelatedAction}";
            return new Uri(link);
        }

        public static Type GetResponseType(LinkItem linkItem)
        {
            switch (linkItem.RequestType)
            {
                case RequestType.Balance:
                    return typeof(DataModelBalance);

                case RequestType.Buy:
                    return typeof(DataModelBuy);

                case RequestType.Order:
                    return typeof(DataModelOrder);

                default:
                    return typeof(MarketResponse);
            }
        }
    }
}
