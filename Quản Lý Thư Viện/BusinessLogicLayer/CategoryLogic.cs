using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CategoryLogic
    {
        public static List<Category> GetAll()
        {
            using (var categoryData = new CategoryData())
            {
                return categoryData.GetAll().ToList();
            }
        }

        public static Category Insert(Category category)
        {
            using (var categoryData = new CategoryData())
            {
                category = categoryData.Insert(category);
                categoryData.Save();
                return category;
            }
        }

        public static void Update(Category category)
        {
            using (var categoryData = new CategoryData())
            {
                categoryData.Update(category);
                categoryData.Save();
            }
        }

        public static void Delete(Category category)
        {
            using (var categoryData = new CategoryData())
            {
                categoryData.Delete(category);
                categoryData.Save();
            }
        }
    }
}
