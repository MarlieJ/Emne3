using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    public class CarDealer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public CarDealer(string name, string address)
        {
            Name = name;
            Address = address;
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        private Car? FindCar(string registreringsNr)
        {
            foreach (var item in Cars)

            {
                if (item.Regnr == registreringsNr)
                {
                    return item;
                }
            }
            return null;
        }

        public void RemoveCar(string regnum)
        {
            var carToRemove = FindCar(regnum);
            if (carToRemove != null)
            {
                Cars.Remove(carToRemove);
            }
            else Console.WriteLine("car not found");
        }

        public List<Car> AllCarsOlderThan(int yearOld)
        {
            var carList = new List<Car>();
            foreach (var item in Cars)
            {
                if (item.Aarsmod < yearOld)
                {
                    carList.Add(item);
                }
            }
            return carList;
        }
        
        public List<Car> AllCarsKmMoreThan(int kmStandParam)
        {
            var kmMoreThanCars = new List<Car>();
            foreach (var item in Cars)
            {
                if (item.Kmstand > kmStandParam)
                {
                    kmMoreThanCars.Add(item); 
                    //break; = stopper en loop 
                    //continue; = stopper loopen du er i, men fortsetter å loope i de andre conditions
                    //hvis jeg putter return her så leser ikke programmet videre
                    //hvis den først har funnet ett item
                }
            }
            return kmMoreThanCars;
        }
        //Lag så unittester som tester at klassene fungerer som de skal
    }

}
