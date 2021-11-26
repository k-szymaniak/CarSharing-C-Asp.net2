using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSharing.Models;

namespace CarSharing.Repositories
{
    public interface ICarRepository
    {
        CarModel Get(int carId);
        IQueryable<CarModel> GetAllActive();

        

        void Add(CarModel car);
        void Update(int carId, CarModel car);

        void Delete(int carId);
    }
}
