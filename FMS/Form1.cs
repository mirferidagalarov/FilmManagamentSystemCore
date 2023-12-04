using Business.Abstract;
using Entities.TableModels;

namespace FMS
{
    public partial class frmcategory : Form
    {
        private readonly ICategoryService _categoryService;
        public frmcategory(ICategoryService categoryService) : this()
        {
            _categoryService = categoryService;
        }
        public frmcategory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _categoryService.GetAll().Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                Name = textBox1.Text
            };


            var result = _categoryService.Add(category);
            if (result.Success)
            {
                LoadData();
            }

            MessageBox.Show(result.Message);
        }
    }
}