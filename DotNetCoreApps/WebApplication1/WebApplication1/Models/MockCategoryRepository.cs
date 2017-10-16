using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patl.WebApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
    }
}
