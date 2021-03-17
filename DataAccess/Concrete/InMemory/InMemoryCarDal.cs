using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
            new Car{BrandID=1,ID=1,ColorID=4,DailyPrice="4500",Description="sahibinden yeni",ModelYear="2015"},
            new Car{BrandID=2,ID=2,ColorID=2,DailyPrice="7800",Description=" yeni",ModelYear="2011"},
            new Car{BrandID=1,ID=3,ColorID=1,DailyPrice="25000",Description="sahibinden ",ModelYear="2018"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car car1 = _cars.SingleOrDefault(p => p.ID == car.ID);
            _cars.Remove(car1);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car UpdateProduct = _cars.SingleOrDefault(c => c.ID == car.ID);
            UpdateProduct.ID = car.ID;
            UpdateProduct.BrandID = car.BrandID;
            UpdateProduct.ColorID = car.ID;
            UpdateProduct.DailyPrice = car.DailyPrice;
        }
    }
}
