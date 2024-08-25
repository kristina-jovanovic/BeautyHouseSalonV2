using Common.Domain;

namespace DataAccessLayer
{
	public interface IRepository<T> where T : IEntity
	{
		Task<IEnumerable<IEntity?>> GetAllAsync(T entity);
		Task<IEnumerable<IEntity?>> GetAllWithFilterAsync(T entity, string filter);
		Task<IEnumerable<IEntity?>> GetAllWithStatusAsync(T entity, StatusZahteva status);
		Task<IEntity?> GetByIdAsync(T entity);
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task OpenConnectionAsync();
		Task CloseConnectionAsync();
		Task BeginTransactionAsync();
		Task CommitAsync();
		Task RollbackAsync();


	}
}
