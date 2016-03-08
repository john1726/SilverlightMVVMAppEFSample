namespace WcfEntitiesSample.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int? InventoryCount { get; set; }
        public string Description { get; set; }

        public Product()
        {
        }

        public Product(string name, string description, int inventory)
        {
            Name = name;
            Description = description;
            InventoryCount = inventory;
        }
    }
}
