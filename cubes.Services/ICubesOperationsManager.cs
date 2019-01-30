
namespace cubes.Services
{
	using cubes.Data;

	public interface ICubesOperationsManager
	{
		int CalculateIntersection();

		bool AreIntersected();
		ICubesSpace Cubes { get; set; }
	}
}