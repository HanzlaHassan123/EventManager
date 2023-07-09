using EventManager.Models.Domain;
using Humanizer.Localisation;

namespace EventManager.Repositories.Abstract
{
    public interface ICategoryService
    {


        bool Add(Category model);
        bool Update(Category model);
        Category GetById(int id);
        bool Delete(int id);
        IQueryable<Category> List();

    }
}
