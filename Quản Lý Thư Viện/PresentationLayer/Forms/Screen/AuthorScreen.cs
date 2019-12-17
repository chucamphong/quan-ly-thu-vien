using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Forms.Screen
{
    public class AuthorScreen : LayoutScreen<Author, AuthorService>
    {
        public AuthorScreen()
            : base("Quản Lý Thể Loại")
        {
        }
    }
}
