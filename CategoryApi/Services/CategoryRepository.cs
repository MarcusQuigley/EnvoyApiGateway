
using CategoryApi.DbContexts;
using CategoryApi.Entities;
using Microsoft.Extensions.Logging;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryApi.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CatalogDbContext _context;
        private readonly ILogger<CategoryRepository> _logger;

        public CategoryRepository(  ILogger<CategoryRepository> logger)
        {
          //  _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await Task.Run(()=>  new List<Category>() { 
                        new Category{Name = "1980s", CategoryOrder=1980, IsMiniTruck=false},
                        new Category{Name = "1990s", CategoryOrder=1990, IsMiniTruck=false},
                        new Category{Name = "2000s", CategoryOrder=2000, IsMiniTruck=false}
                        });
            //return await _context.Categories.ToListAsync();
        }


        //public async Task AddCategory(Category category)
        //{
        //    if (category == null)
        //    {
        //        _logger.LogError("Category to add is null");
        //        throw new ArgumentNullException(nameof(category));
        //    }
        //    await _context.Categories.AddAsync(category);

        //}

      
        //public async Task<IEnumerable<Category>> GetCategoriesBySize(bool isMini = false)
        //{
        //    return await _context.Categories.Where(c => c.IsMiniTruck == isMini)
        //                                    .ToListAsync();
        //}

        //public async Task<Category> GetCategory(int categoryId)
        //{
        //    return await _context.Categories.Where(c => c.CategoryId == categoryId)
        //                                    .FirstOrDefaultAsync();
        //}

        //public async Task<bool> SaveChanges()
        //{
        //    return (await _context.SaveChangesAsync() >= 0);
        //}

        //public void UpdateCategory(Category category)
        //{
        //    if (category == null)
        //    {
        //        _logger.LogError("Category to add is null");
        //        throw new ArgumentNullException(nameof(category));
        //    }

        //}
    }
}
