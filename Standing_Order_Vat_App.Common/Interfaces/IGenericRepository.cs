using System.Linq.Expressions;

namespace Standing_Order_Vat_App.Common.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        bool Any(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        Task<T> GetById(int Id);
        Task<T> Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task Save();
    }
}
