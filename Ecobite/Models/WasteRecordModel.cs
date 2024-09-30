namespace Ecobite.Models
{
    public class WasteRecordModel
    {
        public int WasteRecordId { get; set; }
        public int FoodItemId { get; set; }
        public int QuantityWasted { get; set; }
        public DateTime DateRecorded { get; set; }

       
        
    }
}
