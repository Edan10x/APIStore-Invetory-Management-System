namespace APIStore_Invetory_Management_System.Request
{
    public class CreateInventoryRequest
    {

        public int Quantity { get; set; }

        public string? Aisle { get; set; }

        public int StoreId { get; set; }

        public int ProductId { get; set; }

        
    }
}
