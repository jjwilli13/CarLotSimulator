using System;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car --DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable --DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() --DONE
            //The methods should take one string parameter: the respective noise property -- DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var lot = new CarLot();
            

            //Instanciation 1
            var firstCar = new Car();
            firstCar.Year = 2012;
            firstCar.Make = "Toyota";
            firstCar.Model = "Sequoia";
            firstCar.EngineNoise = "vrmm vrmmm";
            firstCar.HonkNoise = "BEEP";
            firstCar.IsDriveable = true;

            lot.Cars.Add(firstCar);
    
            //Instanciation 2
            var secondCar = new Car()
            {
                Year = 2005,
                Make = "Chevrolet",
                Model = "Cavalier",
                EngineNoise = "vrrrm",
                HonkNoise = "TOOT",
                IsDriveable = true,

            };

            lot.Cars.Add(secondCar);
            

            //Instanciation 3
            var thirdCar = new Car(1999, "Ford", "Ranger", "putputput", "beeep", false);

            lot.Cars.Add(thirdCar);

            //Call EngineNoise Method
            //firstCar.MakeEngineNoise(firstCar.EngineNoise);
            //secondCar.MakeEngineNoise(secondCar.EngineNoise);
            //thirdCar.MakeEngineNoise(secondCar.EngineNoise);

            //Call HonkNoise Method
            //firstCar.MakeHonkNoise(firstCar.HonkNoise);
            //secondCar.MakeHonkNoise(secondCar.HonkNoise);
            //thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            Console.WriteLine($"Number of cars in inventory is: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


        }

           


    }
}
