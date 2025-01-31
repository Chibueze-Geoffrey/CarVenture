using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;

namespace EzeCarVentures.Models
{
    public class CarRepo : ICar
    {
        private readonly AppDbContext _context;
        public CarRepo(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Car> AllCars => _context.Cars;

        public Car GetCarById(int id) => _context.Cars.FirstOrDefault(c => c.CarId == id);
    }
}
