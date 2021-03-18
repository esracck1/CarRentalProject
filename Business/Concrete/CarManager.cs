using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   public class CarManager:ICarService
    {
        ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                carDal.Add(car);
            }
            else
            {

                Console.WriteLine("Car name should contain more than two characters.\n" +
                                  "Car daily price should be more than '0'");
            }
           
        }

        public void Delete(Car car)
        {
            carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return carDal.GetAll(c => c.BrandID == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return carDal.GetAll(c => c.ColorID == id).ToList();
        }

        public void Update(Car car)
        {
            carDal.Update(car);
        }
    }
}
