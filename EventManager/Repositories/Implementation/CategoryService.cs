using EventManager.Models.Domain;
using EventManager.Repositories.Abstract;

namespace EventManager.Repositories.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly DatabaseContext _databaseContext;

        public CategoryService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public bool Add(Category model)
        {
            try
            {
                _databaseContext.Add(model);
                _databaseContext.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
           // throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                {
                    return false;
                }
                _databaseContext.Category.Remove(data);
                _databaseContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Category GetById(int id)
        {
            return _databaseContext.Category.Find(id);

        }

        public IQueryable<Category> List()
        {
            var data= _databaseContext.Category.AsQueryable();
            return data;
        }

        public bool Update(Category model)
        {
            try
            {
                _databaseContext.Update(model);
                _databaseContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
