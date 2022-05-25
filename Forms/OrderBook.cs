using LibraryApp.Helpers;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class OrderBook : BaseForm
    {
        private User _user;
        private List<Book> _books;
        private BindingSource _bindingSource = new BindingSource();

        public OrderBook(User user) : base(user)
        {
            InitializeComponent();
            _user = user;
            RefreshData();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                if (dgv.SelectedRows[0].DataBoundItem is Book book)
                {
                    btn_order.Text = book.BookedUser == 0 ? "Отменить заказ" : "Заказать";
                }
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                Book selectedBook = dgv.SelectedRows[0].DataBoundItem as Book;
                if (selectedBook.BookedUser == 0)
                {
                    selectedBook.BookedUser = _user.Id;
                    btn_order.Text = selectedBook.BookedUser == 0 ? "Отменить заказ" : "Заказать";
                    Logger.CreateRecord($"Заказана книга Id: {selectedBook.Id}");
                }
                else
                {
                    selectedBook.BookedUser = 0;
                    btn_order.Text = selectedBook.BookedUser == 0 ? "Отменить заказ" : "Заказать";
                    Logger.CreateRecord($"Отменен заказ на книгу Id: {selectedBook.Id}");
                }

                DBContext.EditBook(selectedBook);
               
                FormatCells();
            }
        }

        private void RefreshData()
        {
            _books = DBContext.GetAllBooks().Where(x => x.OwnerUser == 0 || x.BookedUser == _user.Id).ToList();
            _bindingSource.DataSource = _books;
            dgv.DataSource = _bindingSource;

            FormatCells();
        }

        private void FormatCells()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.DataBoundItem is Book book)
                {
                    row.Cells["IsBooked"].Value = book.BookedUser != 0 ? $"Заказана" : $"Свободна";
                    row.Cells["Author"].Value = _books[row.Index].Author.Name;
                    row.Cells["Genre"].Value = _books[row.Index].Genre.Name;
                }
            }
        }

        private void OrderBook_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                try
                {
                    _bindingSource.DataSource = _books.Where(x => x.Author.Name.Contains(textbox.Text) || x.Title.Contains(textbox.Text));
                    dgv.DataSource = _bindingSource;
                    FormatCells();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
