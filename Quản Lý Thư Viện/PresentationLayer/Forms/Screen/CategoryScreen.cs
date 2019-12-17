using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Forms.Screen
{
    public class CategoryScreen : LayoutScreen<Category, CategoryService>
    {
        public CategoryScreen()
            : base("Quản Lý Thể Loại")
        {
        }
    }
}
