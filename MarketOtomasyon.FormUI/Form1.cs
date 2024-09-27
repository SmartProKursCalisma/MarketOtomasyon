using MarketOtomasyon.Entities;
using MarketOtomasyon.FormUI.ViewModels;
using MarketOtomasyon.Repository.Repository;
using MarketOtomasyon.Services;

namespace MarketOtomasyon.FormUI
{
    public partial class Form1 : Form
    {
        ProductService _productService;
        public Form1()
        {

            InitializeComponent();
            _productService = new ProductService(new ProductRepository());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            ProductViewModel? product = _productService.GetProductById(id);
            if (product != null)
            {
                label1.Text = product.ProductName;
                label2.Text = product.CategoryId.ToString();
            }
        }
    }
}
