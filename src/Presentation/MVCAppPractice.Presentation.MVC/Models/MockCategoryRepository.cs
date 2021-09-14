using System.Collections.Generic;

namespace MVCAppPractice.Presentation.MVC.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Fruit Pies", Description = "All Fruit Pies"},
                new Category {CategoryId = 2, CategoryName = "Cheese Cakes", Description = "All Cheese Cakes"},
                new Category {CategoryId = 3, CategoryName = "Seasonal Pies", Description = "All Seasonal Pies"},
            };
    }
}