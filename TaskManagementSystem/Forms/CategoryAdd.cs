using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Forms
{

    public partial class CategoryAdd : Form
    {
        CategoryService _categoryService;

        public CategoryAdd(CategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private async void parrotSuperButton1_ClickAsync(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Name = textBox2.Text
            };
            await _categoryService.AddAsync(category);
            this.Close();

        }

        private void parrotSuperButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
