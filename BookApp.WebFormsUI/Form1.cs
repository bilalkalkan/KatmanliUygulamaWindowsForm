using BookApp.Business.Abstract;
using BookApp.Business.Concrete;
using BookApp.Business.DependencyResolvers.Ninject;
using BookApp.DataAcces.Concrete.EntityFramework;
using BookpApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCategories();
            LoadBooks();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooks.DataSource = _bookService.GetBooksByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBooktName.Text))
            {
                dgwBooks.DataSource = _bookService.GetBooksByBookName(tbxBooktName.Text);
            }
            else
            {
                LoadBooks();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    BookName = tbxBookNameAdd.Text,
                    AuthorName = tbxAuthorNameAdd.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                    NumberofPages = Convert.ToInt32(tbxPageofNumberAdd.Text),
                    Price = Convert.ToDecimal(tbxPriceAdd.Text),
                    Publisher = tbxPublisherAdd.Text
                });
                MessageBox.Show("Kitap eklendi");
                LoadBooks();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book
            {
                Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                BookName = tbxBookNameUpdate.Text,
                AuthorName = tbxAuthorNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                NumberofPages = Convert.ToInt32(tbxNumberOfPageUpdate.Text),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                Publisher = tbxPublisherUpdate.Text
            });
            MessageBox.Show("Kitap güncellendi");
            LoadBooks();
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwBooks.CurrentRow;
            tbxBookNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxAuthorNameUpdate.Text = row.Cells[2].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[4].Value;
            tbxNumberOfPageUpdate.Text = row.Cells[3].Value.ToString();
            tbxPriceUpdate.Text = row.Cells[5].Value.ToString();
            tbxPublisherUpdate.Text = row.Cells[6].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _bookService.Delete(new Book
            {
                Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Kitap silindi");
            LoadBooks();
        }



        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                CategoryName = tbxCategoryAdd.Text
            });
            MessageBox.Show("Kategori eklendi");
            LoadCategories();
        }
    }
}
