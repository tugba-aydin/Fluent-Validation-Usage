namespace FluentValidationExample.Data
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        void SaveAll();
    }
}
