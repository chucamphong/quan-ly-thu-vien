using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public sealed class CategoryService : Service<Category>, ICategoryService
    {
        protected override BaseData<Category> CreateInstance()
        {
            return new CategoryData();
        }
    }
}
