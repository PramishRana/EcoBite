using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ecobite.Models
{
    public class FoodItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodItemId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Food Item Name")]
        public string FoodItemName { get; set; } 

        [Required]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("Category")]
        [StringLength(50)]
        public string Category { get; set; } 


        [Required]
        [DisplayName("Expiration Date")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        public ICollection<InventoryModel> Inventories { get; set; }
    }
}

