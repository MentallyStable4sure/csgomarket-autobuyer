namespace AutoBuyer.Data
{
    internal class FeedbackHandler
    {
        public const string MessageBought = "Request made successfully! ♡";
        public const string MessageNotBought = "Request was unsuccessful check your item or balance if you were trying to buy";

        public string LatestFeedback { get; protected set; }

        public event Action<string> OnFeedbackUpdated;

        public void UpdateFeedback(string feedback)
        {
            if (feedback == null || feedback == string.Empty) return;

            LatestFeedback = feedback;
            OnFeedbackUpdated?.Invoke(LatestFeedback);
        }
    }
}
