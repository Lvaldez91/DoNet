using ApiPlayer.Data;
using ApiPlayer.Models;
using ApiPlayer.Repository.IRepository;

namespace ApiPlayer.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AplicationDbContext _db;

        // contructor
        public CategoryRepository(AplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateCategory(Category CategoryEnt)
        {
            _db.CategoryDB.Add(CategoryEnt);
            return SaveCategory();
        }

        public bool DeleteCategory(Category CategoryEnt)
        {
            _db.CategoryDB.Remove(CategoryEnt);
            return SaveCategory();
        }

        public bool ExistsCategory(string CategoryName)
        {
            bool values = _db.CategoryDB.Any(ctn => ctn.NameCategory.ToLower().Trim() == CategoryName.ToLower().Trim());
            return values;
        }

        public bool ExistsIdCategory(int IdCategory)
        {
            bool values = _db.CategoryDB.Any(ctn => ctn.IdCategory == IdCategory);
            return values;
        }

        public ICollection<Category> GetCategories()
        {
            return _db.CategoryDB.OrderBy(c => c.NameCategory).ToList();
        }

        public Category GetCategory(int IdCategory)
        {
            return _db.CategoryDB.FirstOrDefault(c => c.IdCategory == IdCategory);
        }

        public bool SaveCategory()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category CategoryEnt)
        {
            _db.CategoryDB.Update(CategoryEnt);
            return SaveCategory();
        }
    }
}
