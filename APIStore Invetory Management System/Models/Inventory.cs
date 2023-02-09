namespace APIStore_Invetory_Management_System.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int StoreId { get; set; }

        public int Quantity { get; set; }

        public string? Aisle { get; set; }

    }
}
