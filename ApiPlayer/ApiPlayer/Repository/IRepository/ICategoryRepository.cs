using ApiPlayer.Models;

namespace ApiPlayer.Repository.IRepository
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int IdCategory);
        bool ExistsCategory(string CategoryName);
        bool ExistsIdCategory(int IdCategory);
        bool CreateCategory(Category CategoryEnt);
        bool UpdateCategory(Category CategoryEnt);
        bool DeleteCategory(Category CategoryEnt);
        bool SaveCategory();
    }
}
