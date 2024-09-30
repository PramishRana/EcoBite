namespace Ecobite.Models
{
    public class InventoryModel
    {
        public int InventoryId { get; set; }

        public int FoodItemId { get; set; }

        public int QuantityInStock { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
