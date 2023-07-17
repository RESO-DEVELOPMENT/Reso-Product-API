namespace Pos_System.Repository.Interfaces
{
	public interface IGenericRepositoryFactory
	{
		IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
	}
}
