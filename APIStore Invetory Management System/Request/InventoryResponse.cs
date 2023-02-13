namespace APIStore_Invetory_Management_System.Request
{
    public class InventoryResponse
    {
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string? Aisle { get; set; }

        public string? StoreLocation { get; set; }
    }
}
