using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecobite.Models
{
    public class InventoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }

        [Required]
        [ForeignKey("FoodItemId")]
        public int FoodItemId { get; set; }

        [Required]
        [DisplayName("Quantity in Stock")]
        public int Quantity{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded{ get; set; }

        public FoodItem? FoodItem { get; set; }
    }
}
