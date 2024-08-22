namespace DataAccessLayer
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T t);
		Task UpdateAsync(T t);
		Task DeleteAsync(T t);

	} 
}
