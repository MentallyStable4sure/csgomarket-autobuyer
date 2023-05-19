namespace AutoBuyer.Data.Model
{

    [Serializable]
    public class DataModelOrder : IDataModel
    {
        public string Name;
        public string Phase;
        public string Currency;
        public int Price;
        public int Count;
        public string Date;
        public string Partner;
        public string Token;
    }
}
