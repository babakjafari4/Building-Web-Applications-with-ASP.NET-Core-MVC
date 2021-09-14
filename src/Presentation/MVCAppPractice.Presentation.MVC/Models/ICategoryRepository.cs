using System.Collections.Generic;

namespace MVCAppPractice.Presentation.MVC.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}