using System;
using System.Collections.Generic;
using System.Text;
using WoodsiesPCShop.Core.Models;
using WoodsiesPCShop.Data.Infrastructure.Contracts;

namespace WoodsiesPCShop.Data.Infrastructure.Repositories
{
    public class InMemoryCategoryRepo : ICategoryData
    {
        private readonly List<Category> _categoryDb;

        public InMemoryCategoryRepo()
        {
            _categoryDb = new List<Category>
            {
                new Category { CategoryName = "Graphics cards", CategoryId = 1},
                new Category { CategoryName = "CPUs", CategoryId = 2},
                new Category { CategoryName = "Memory", CategoryId = 3},
                new Category { CategoryName = "Cases", CategoryId = 4}
            };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryDb;
        }
    }
}
