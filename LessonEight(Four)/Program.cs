// Applying LINQ Queries to Collection Objects
using LessonEight_Four_;
using System.Collections;

List<Car> myCars = new()
{
    new Car { PetName = "Mikhail", Color = "White", Speed = 120, Make = "BMW" },
    new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
    new Car { PetName = "Mary", Color = " Black", Speed = 55, Make = "VW" },
    new Car { PetName = "Clunker ", Color = "Rust ", Speed = 5, Make = "Yugo" },
    new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
};

GetFastCars(myCars);
/*
Mikhail - BMW
Daisy - BMW
Mary - VW
*/

ArrayList myCarsAL = new()
{
    new Car { PetName = "Mikhail", Color = "White", Speed = 120, Make = "BMW" },
    new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
    new Car { PetName = "Mary", Color = " Black", Speed = 55, Make = "VW" },
    new Car { PetName = "Clunker ", Color = "Rust ", Speed = 5, Make = "Yugo" },
    new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
};

GetFastCarsAL(myCarsAL);
/*
Melvin - Ford
*/

static void GetFastCars(List<Car> cars)
{
    var fastCars = from car in cars where car.Speed >= 55 select car;

    Console.WriteLine("Fast Cars:");
    foreach (var fastCar in fastCars) { Console.WriteLine($"{fastCar.PetName} - {fastCar.Make}"); }
}

static void GetFastCarsAL(ArrayList cars)
{
    // Convert Array List to IEnumerable<T> compatible type
    // Трансформировать ArrayList в тип, совместимый c IEnumerable<T>
    IEnumerable<Car> myCars = cars.OfType<Car>();
    var fastCars = from car in myCars where car.Speed < 55 && car.Make == "Ford" select car;

    Console.WriteLine("Slow Fords:");
    foreach (var fastCar in fastCars) { Console.WriteLine($"{fastCar.PetName} - {fastCar.Make}"); }
}