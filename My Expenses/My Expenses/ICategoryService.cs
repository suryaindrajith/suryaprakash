using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My_Expenses
{
    internal interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task AddCategory(Category category);
        Task DeleteCategory(int id);
    }
}