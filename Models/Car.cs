using System;

namespace EzeCarVentures.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ShortName { get; set; }
        public string ImageUrl { get; set; }

        // Foreign Key for Brand
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public Brand Brand { get; set; }  // Navigation Property

        public DateTime Accessed { get; set; } = DateTime.UtcNow;
    }
}
