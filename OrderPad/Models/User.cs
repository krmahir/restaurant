using System.ComponentModel.DataAnnotations;

namespace OrderPad.Models
{
    public class User
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        public int UserID { get; set; }

    }

    public class Restaurant 
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }

    public class Item 
    {
        public int ItemID { get; set; }

        public int RestaurentID { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public Double Price { get; set; }

    }

    // Models/Table.cs
    // Models/Table.cs
    public class Table
    {
        public int TableID { get; set; }
        public int RestaurantID { get; set; }  // To associate with Restaurant
        public string TableNumber { get; set; }  // To identify the table
    }


}
