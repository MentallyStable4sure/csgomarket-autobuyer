namespace AutoBuyer.Data
{
    internal class FeedbackHandler
    {
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
