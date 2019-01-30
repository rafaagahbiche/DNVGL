namespace cubes.Services
{
	using cubes.Data;

	public class CubesOperationsManager : ICubesOperationsManager
	{
		public ICubesSpace Cubes { get; set; }

		public CubesOperationsManager(ICubesSpace cubesInSpace)
		{
			Cubes = cubesInSpace;
		}

		public int CalculateIntersection()
		{
			int res = 0;
			return res;
		}

		public bool AreIntersected()
		{
			bool intersected = false;
			return intersected;
		}
	}
}
