namespace Task
{
    class Good
    {
        public string Name { get; }
        public int Price { get; }
        
        public int Count { get; set; }

        public Good(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
