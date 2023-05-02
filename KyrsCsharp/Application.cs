using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static KyrcCsharp.Book;


namespace KyrcCsharp
{
    public partial class Application : Form
    {
        private BindingList<Book> booksList;
        public Application()
        {
            this.booksList = new BindingList<Book>();
            InitializeComponent();
            MainShowBook.DataSource = booksList;
            SetupDataGrid();
        }
        private void SetupDataGrid()
        {
            booksList.Add(new Book("Шевченко", "Кобзар", "А-БА-БА-ГА-ЛА-МА-ГА", new Date(2000, 1, 1), 300));
            booksList.Add(new Book("q", "q", "q", new Date(11, 11, 11), 1));
            MainShowBook.Columns[0].HeaderText = "Автор";
            MainShowBook.Columns[1].HeaderText = "Назва книга";
            MainShowBook.Columns[2].HeaderText = "Видавництво";
            MainShowBook.Columns[3].HeaderText = "Рік видання";
            MainShowBook.Columns[4].HeaderText = "К-сть сторінок";
            MainShowBook.BackgroundColor = Color.White;
            MainShowBook.ForeColor = Color.Black;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search(booksList);
            search.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (MainShowBook.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = MainShowBook.SelectedCells[0];
                Book selectedBook = MainShowBook.Rows[selectedCell.RowIndex].DataBoundItem as Book;
                Library library = new Library();
                Library library2 = new Library2();

                library.ReadBookInfo(selectedBook);
                library2.ReadBookInfo(selectedBook);
            }

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            CreateDate data = new CreateDate();
            data.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            CreateBook book = new CreateBook(booksList);
            book.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainShowBook.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = MainShowBook.SelectedCells[0];
                Book selectedBook = MainShowBook.Rows[selectedCell.RowIndex].DataBoundItem as Book;
                booksList.Remove(selectedBook);
            }
        }
    }
}


