using Microsoft.EntityFrameworkCore;

namespace FluentValidationExample.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly StudentContext context;
        private readonly DbSet<T> table;

        public Repository(StudentContext _context)
        {
            context = _context;
            table = context.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity != null)
            {
                table.Add(entity);
            }
        }

        public void SaveAll()
        {
            context.SaveChanges();
        }
    }
}
