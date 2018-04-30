using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingGarage
{
	class Program
	{ 
		static void Main(string[] args)
		{
			
			var myGarage = SetUpGarage();
			var myBikes = GenerateBike();
			var myCars = GenerateCar();
			var myVans = GenerateVans();

			ParkAllTheVehicles(myBikes, myCars, myVans, myGarage);

			Console.Write("\nThe Car Park is now full");
			Console.ReadLine();
		}

		public static Garage SetUpGarage()
		{
			var mygarage = new Garage();

			var myFirstFloor = new Floor();
			myFirstFloor.Spaces.Add(new Space(300));
			myFirstFloor.Spaces.Add(new Space (300));
			myFirstFloor.Spaces.Add(new Space (300));

			var mySecondFloor = new Floor();
			mySecondFloor.Spaces.Add(new Space(200));
			mySecondFloor.Spaces.Add(new Space(400));
			mySecondFloor.Spaces.Add(new Space(200));

			var myThirdFloor = new Floor();
			myThirdFloor.Spaces.Add(new Space(800));
			myThirdFloor.Spaces.Add(new Space(800));
			myThirdFloor.Spaces.Add(new Space(500));

			mygarage.Floors.Add(myFirstFloor);
			mygarage.Floors.Add(mySecondFloor);
			mygarage.Floors.Add(myThirdFloor);

			return mygarage;
		}

		public static List<Vehicle> GenerateCar()
		{
			var cars = new List<Vehicle>
			{
				new Car("H3LLoWoRld", 200, "Ferrari"),
				new Car("nidoo54", 300, "Range Rover"),
				new Car("or406", 200, "Nissan Micra")
			};

			return cars;
		}

		public static List<Vehicle> GenerateBike()
		{
			var bikes = new List<Vehicle>
			{
				new Bike("hdo40f", 100, "Yamaha"),
				new Bike("ogfgf40f", 150, "Suzuki")
			};

			return bikes;
		}

		public static List<Vehicle> GenerateVans()
		{
			var vans = new List<Vehicle>
			{
				new Van("454890f", 500, "Generic White Van"),
				new Van("fffff", 800, "Angry Man In Van Who you cut up in traffic"),
				new Van("gg", 800, "Dont Know any other types of Van?!")
			};

			return vans;
		}

		public static void ParkAllTheVehicles(List<Vehicle> bike, List<Vehicle> car, List<Vehicle> van, Garage myGarage)
		{
			var vehicleList = new List<Vehicle>();
			var collatedVehicles = vehicleList.Concat(bike).Concat(car).Concat(van);

			foreach (var vehicle in collatedVehicles)
			{
				vehicle.FindSpace(myGarage);
				if (vehicle.IsParked)
				{
					Console.WriteLine("The {0} with the registration {1} has found a space", vehicle.VehicleType, vehicle.Registration);
				}
				else
				{
					Console.WriteLine("Unfortunately {0} with the registration {1} could not find a space", vehicle.VehicleType, vehicle.Registration);
				}
			}
		}
	}
}
