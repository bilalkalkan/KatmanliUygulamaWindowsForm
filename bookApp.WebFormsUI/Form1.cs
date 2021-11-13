using BookApp.Business.Abstract;
using BookApp.Business.Concrete;
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

namespace bookApp.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
            _categoryService = new CategoryManager(new EfCategoryDal());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
        }

        private void LoadCategories()
        {
            //bu kodlar belirtilen comboboxlarda yer alıcaktır.
            //DisplayMember ile ComboBox içerisinde gözükecek olan alan bilgisini belirtiyoruz.
            //ValueMember ilede seçilen satırın arka planda hangi değeri tutacağı belirtilmektedir.
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryIdAdd.DataSource = _categoryService.GetAll();
            cbxCategoryIdAdd.DisplayMember = "CategoryName";
            cbxCategoryIdAdd.ValueMember = "CategoryId";

            cbxBookCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxBookCategoryUpdate.DisplayMember = "CategoryName";
            cbxBookCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookService.GetAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //burada ComboBoxta seçilen kategoriye göre data grid viewde o kategoriye ait veriler gelir.
            try
            {
                dgwBooks.DataSource = _bookService.GetBooksByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {


            }
        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
            //girilen kitap ismi data grid viewde görüntülenir.
            //String IsNullOrEmpty yöntemi ile belirtilen string değerinin boş ve null olup olmadığını kontrol eder.
            if (!String.IsNullOrEmpty(tbxBookName.Text))
            {
                dgwBooks.DataSource = _bookService.GetBooksByBookName(tbxBookName.Text);
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
                    CategoryId = Convert.ToInt32(cbxCategoryIdAdd.SelectedValue),
                    BookName = tbxBookName2.Text,
                    AuthorName = tbxAuthorName.Text,
                    NumberofPages = Convert.ToInt32(tbxNumberofPages.Text),
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    Publisher = tbxPublisher.Text
                });
                MessageBox.Show("Kitap eklendi!");
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
                // "dgwBooks.CurrentRow.Cells[0].Value" kodu ile data grid viewden satırı seçiyoruz .
                //CurrentRow sayesinde seçili satırı belirledik
                //Cells[0] ilede hangi hücreyi alacağımızı belirledik.
                // böylece update kısmında veriler yerinde görmüş oluyoruz.


                Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                BookName = tbxBookNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxBookCategoryUpdate.SelectedValue),
                AuthorName = tbxAuthorNameUpdate.Text,
                NumberofPages = Convert.ToInt32(tbxNumberofPagesUpdate.Text),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                Publisher = tbxPublisherUpdate.Text
            });
            MessageBox.Show("Kitap güncellendi!");
            LoadBooks();
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CurrentRow: seçili satırı belirleme
            var row = dgwBooks.CurrentRow;
            tbxBookNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxAuthorNameUpdate.Text = row.Cells[2].Value.ToString();
            tbxNumberofPagesUpdate.Text = row.Cells[3].Value.ToString();
            cbxBookCategoryUpdate.SelectedValue = row.Cells[4].Value;
            tbxPriceUpdate.Text = row.Cells[5].Value.ToString();
            tbxPublisherUpdate.Text = row.Cells[6].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwBooks.CurrentRow != null)
            {
                try
                {
                    _bookService.Delete(new Book
                    {
                        Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value)
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            MessageBox.Show("Kitap silindi!");
            LoadBooks();

        }

        private void dgwBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
