using System.Runtime.InteropServices;

namespace Bilforhandleren
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine($"");
            CarDealer audibutikken = new CarDealer("AudiButikken", "Audiveien 3");

            Car audi = new Car("Audi", "EB13245", 2020, 10000);
            Car tesla = new Car("tesla", "EB93467", 2023, 100);
            Car nissan = new Car("nissan", "NK30008", 1996, 158000);
            Car mercedes = new Car("mercedes", "AB74984", 2018, 53498);
            Car peugeot = new Car("peugeot", "RK35222", 1999, 130300);
            Car mustang = new Car("mustang", "AC3405", 1950, 99900);

            audibutikken.AddCar(audi);
            audibutikken.AddCar(tesla);
            audibutikken.AddCar(nissan);
            audibutikken.AddCar(mercedes);
            audibutikken.AddCar(peugeot);
            audibutikken.AddCar(mustang);

            void showCarBrands(List<Car> cars)
                {
                    foreach (var CarMenKallDenHvaDuVil in cars)
                    {
                        Console.WriteLine(CarMenKallDenHvaDuVil.Merke);
                    }
                }
            showCarBrands(audibutikken.Cars);


            audibutikken.RemoveCar("EB13245");
            showCarBrands(audibutikken.Cars);


            Console.WriteLine($"Vis meg alle biler eldre enn:");
            var input = Console.ReadLine();
            int bilår = int.Parse(input);//#1 /2- dette er parse metoden
            var oldCars = audibutikken.AllCarsOlderThan(bilår);
            showCarBrands(oldCars);


            Console.WriteLine("Vis meg alle biler som har gått mer enn x kilometer");
            var merEnnKm = Console.ReadLine();
            int inputKm = Convert.ToInt32(merEnnKm);//#1 /2- dette er convert metoden
            var bilerNavn = audibutikken.AllCarsKmMoreThan(inputKm);
            showCarBrands(bilerNavn);
            
        }

    }
}