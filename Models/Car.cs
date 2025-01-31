using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EzeCarVentures.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public virtual Brand Brand { get; set; }
    }

}
