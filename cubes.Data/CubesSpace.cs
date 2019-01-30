using System;
using System.Collections.Generic;

namespace cubes.Data
{
	public class CubesSpace : ICubesSpace
	{
		public int Id { get; set; }

		public List<Cube> Cubes { get; set; }

		public CubesSpace()
		{
			Id = 22;
			var idGenerator = new Random();
			Cubes = new List<Cube>();
		}

		public void AddCube(Cube cubeToAdd)
		{
			Cubes.Add(cubeToAdd);
		}
	}
}
