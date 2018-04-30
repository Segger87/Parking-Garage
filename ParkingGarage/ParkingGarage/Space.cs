
namespace ParkingGarage
{
	public class Space
	{
		public int Size;
		public Vehicle Vehicle;
		public bool Occupied = false;

		public Space(int size)
		{
			Size = size;
		}

		public Space()
		{

		}
	}
}
