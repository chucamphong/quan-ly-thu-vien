using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer.Forms.Screen
{
    public partial class CategoryScreen : Form
    {
        public CategoryScreen()
        {
            this.InitializeComponent();
        }

        private void CategoryScreen_Load(object sender, System.EventArgs e)
        {
            this.AllCategory();
        }

        private void AllCategory()
        {
            this.categoriesBindingSource.DataSource = CategoryLogic.GetAll();
        }
    }
}
