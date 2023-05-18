namespace AutoBuyer.Items
{
    internal class LinkItem
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Price { get; set; }

        public LinkItem(string name, string key, string price)
        {
            Name = name;
            Key = key;
            Price = price;
        }
    }
}
