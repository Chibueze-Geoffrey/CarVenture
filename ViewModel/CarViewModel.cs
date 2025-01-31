using System.Collections.Generic;
using EzeCarVentures.Models;

namespace EzeCarVentures.ViewModel
{
    public class CarViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentBrand { get; set; }
    }
}
