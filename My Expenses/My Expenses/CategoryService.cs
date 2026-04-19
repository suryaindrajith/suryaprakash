using System;
using System.Collections.Generic;
using System.Text;

namespace MyExpenses
{
    public class CategoryService : ICategoryService
    {
        private List<Category> categories = new()
    {
        new Category { Id = 1, Name = "Food", Icon = "🍔" },
        new Category { Id = 2, Name = "Transport", Icon = "🚗" }
    };

        public Task<List<Category>> GetCategories() => Task.FromResult(categories);

        public Task AddCategory(Category category)
        {
            categories.Add(category);
            return Task.CompletedTask;
        }

        public Task DeleteCategory(int id)
        {
            var item = categories.FirstOrDefault(x => x.Id == id);
            if (item != null) categories.Remove(item);
            return Task.CompletedTask;
        }
    }


}
