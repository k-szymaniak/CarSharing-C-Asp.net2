using CarSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarSharing.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarSharingContext _context;
        public CarRepository(CarSharingContext context)
        {
            _context = context;
        }

        public void Add(CarModel car)
        {
            _context.cars.Add(car);
            _context.SaveChanges();
        }

        public void Delete(int carId)
        {
            var result = _context.cars.SingleOrDefault(x => x.CarId == carId);
            if(result != null)
            {
                _context.cars.Remove(result);
                _context.SaveChanges();
            }
        }

        public CarModel Get(int carId)
                => _context.cars.SingleOrDefault(x => x.CarId == carId);

       

        public void Update(int carId, CarModel car)
        {
            var result = _context.cars.SingleOrDefault(x => x.CarId == carId);
            if (result != null)
            {
                result.CarMark = car.CarMark;
                result.Model = car.Model;
                result.Power = car.Power;
                result.FuelType = car.FuelType;
                result.Price = car.Price;
                result.Availability = car.Availability;

                _context.SaveChanges();

            }
        }
    }
}
