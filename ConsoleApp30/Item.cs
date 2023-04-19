namespace ConsoleApp30
{
    public abstract class Item
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string? Name { get; set; }

        public Item(string? name, int cost)
        {
            Cost = cost;
            Name = name;
        }
    }
}