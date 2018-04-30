
namespace ParkingGarage
{
	public abstract class Vehicle
	{
		public string Registration;
		public int Size;
		public string VehicleType;
		public bool IsParked;

		protected Vehicle(string reg, int size, string vehicleType)
		{
			VehicleType = vehicleType;
			Registration = reg;
			Size = size;
			IsParked = false;
		}

		public void FindSpace(Garage garage)
		{
			if (IsParked == false)
			{
				foreach (var floor in garage.Floors)
				{
					if (IsParked == false)
					{
						foreach (var space in floor.Spaces)
						{
							if (Size <= space.Size && space.Occupied == false)
							{
								space.Occupied = true;
								space.Vehicle = this;
								IsParked = true;
								break;
							}
						}
					}
					else
					{
						break;
					}
					
				}
			}
			
		}
	}
}
