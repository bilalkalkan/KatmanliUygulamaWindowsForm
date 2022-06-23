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
        Book book = new Book();
        int Id = 0;

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

        private object Get(int id)
        {
            return _bookService.Get(id);
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";


            dgwCategory.DataSource = _categoryService.GetAll();
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookService.GetAll();
        }

        private void Reset()
        {
            tbxBookNameAdd.Text = "";
            tbxAuthorNameAdd.Text = "";
            cbxCategoryIdAdd.SelectedValue = "";
            tbxPageofNumberAdd.Text = "";
            tbxPriceAdd.Text = "";
            tbxPublisherAdd.Text = "";
            Id=0;
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

            book.BookName = tbxBookNameAdd.Text.Trim();
            book.AuthorName = tbxAuthorNameAdd.Text.Trim();
            book.CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue);
            book.NumberofPages = Convert.ToInt32(tbxPageofNumberAdd.Text.Trim());
            book.Price = Convert.ToDecimal(tbxPriceAdd.Text.Trim());
            book.Publisher = tbxPublisherAdd.Text.Trim();

            if (Id > 0)
            {
                try
                {
                    _bookService.Update(book);
                    MessageBox.Show("Kitap güncellendi");
                    Reset();
                    LoadBooks();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                try
                {
                    _bookService.Add(book);
                    MessageBox.Show("Kitap eklendi");
                    Reset();
                    LoadBooks();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
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


        private void btnCategoryAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    CategoryName = tbxCategoryAdd.Text
                });
                MessageBox.Show("Kategori eklendi");
                LoadCategories();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            _categoryService.Delete(new Category
            {
                CategoryId = Convert.ToInt32(dgwCategory.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Kategori silindi");
            LoadCategories();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgwBooks_DoubleClick(object sender, EventArgs e)
        {
            if (dgwBooks.CurrentCell.RowIndex != -1)
            {
                Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells["Id"].Value);
                book = _bookService.Get(Id);
                tbxBookNameAdd.Text = book.BookName;
                tbxAuthorNameAdd.Text = book.AuthorName;
                cbxCategoryIdAdd.SelectedValue = book.CategoryId;
                tbxPageofNumberAdd.Text = book.NumberofPages.ToString();
                tbxPriceAdd.Text = book.Price.ToString();
                tbxPublisherAdd.Text = book.Publisher.ToString();
            }
        }
    }
}
