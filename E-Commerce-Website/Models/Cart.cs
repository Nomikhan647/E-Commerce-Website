using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Website.Models
{
    public class Cart
    {
        [Key]
        public int Cart_Id { get; set; }
        public int Product_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Product_Quantity { get; set; }
        public int Cart_Status { get; set; }

    }
}
