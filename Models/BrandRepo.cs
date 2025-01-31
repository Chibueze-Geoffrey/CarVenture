using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EzeCarVentures.Models
{
    public class BrandRepo : IBrand
    {
        private readonly AppDbContext _context;
        public BrandRepo(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Brand> AllBrand => _context.Brands;
    }
}
