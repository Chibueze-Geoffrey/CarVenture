using System.Collections.Generic;
using System.Linq;

namespace EzeCarVentures.Models
{
    public interface IBrand
    {
        IQueryable<Brand> AllBrand { get; }
    }
}
