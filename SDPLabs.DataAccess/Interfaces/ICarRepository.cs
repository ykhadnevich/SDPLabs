namespace SDPLabs.DataAccess.Interfaces;

public interface ICarRepository
{
    Task AddAsync(Car car);
    Task<List<Car>> GetAllAsync();
    Task UpdateAsync(Car car);
    Task<Car?> FindByVinAsync(string vinCode);
    
}