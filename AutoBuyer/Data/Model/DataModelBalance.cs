namespace AutoBuyer.Data.Model
{

    [Serializable]
    public class DataModelBalance : IDataModel
    {
        public int Balance;
        public string Currency;
        public bool OperationState;
    }
}
