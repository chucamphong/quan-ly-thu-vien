using BusinessLogicLayer;
using DataTransferObject;
using PresentationLayer.Forms.Childs;

namespace PresentationLayer.Forms.Screen
{
    public class AuthorScreen : LayoutScreen<Author, AuthorService>
    {
        public AuthorScreen()
            : base("Quản Lý Tác Giả")
        {
        }

        protected override void ShowInsertForm()
        {
            var insertForm = new InsertLayoutForm<Author, AuthorService>
            {
                Title = "Thêm Tác Giả",
                Label = "Tên tác giả",
                BtnText = "Thêm tác giả",
            };
            insertForm.ShowDialog();
        }
    }
}
