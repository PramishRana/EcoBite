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
        [MaxLength(20,ErrorMessage = "Name must be between 1-20")]
        [DisplayName("Food Item Name")]
    
        
        public string FoodItemName { get; set; } 

        [Required]
        [DisplayName("Quantity")]
        [Range(1,1000, ErrorMessage ="Quanity must be between 1-1000")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("Category")]
        [MaxLength(10,ErrorMessage ="Category must be less then 10")]
        public string Category { get; set; }


        [Required]
        [DisplayName("Manufactured date")]
        [DataType(DataType.Date)]
        public DateOnly MFDate { get; set; }


        [Required]
        [DisplayName("Expiration Date")]
        [DataType(DataType.Date)]
        public DateOnly ExpirationDate { get; set; }

       

        public ICollection<InventoryModel> Inventories { get; set; }
    }
}

