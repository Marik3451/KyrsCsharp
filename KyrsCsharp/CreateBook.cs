using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using static KyrcCsharp.Book;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace KyrcCsharp
{
    public partial class CreateBook : Form
    {
        private BindingList<Book> booksList;
        public CreateBook(BindingList<Book> booksList)
        {
            InitializeComponent();
            this.booksList = booksList;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Book.ValidateInput(textBoxAuthor.Text, textBoxTitle.Text, textBoxPublishing.Text, textBoxYearOfPublishing.Text, textBoxPages.Text))
            {
                try
                {
                    string dateStr = textBoxYearOfPublishing.Text;
                    DateTime date;
                    if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        if (date > DateTime.Now)
                        {
                            throw new ArgumentException("Рік видання не може бути в майбутньому!");
                        }

                        booksList.Add(new Book(textBoxAuthor.Text, textBoxTitle.Text, textBoxPublishing.Text, new Date(date.Year, date.Month, date.Day), int.Parse(textBoxPages.Text)));
                        textBoxAuthor.Clear();
                        textBoxTitle.Clear();
                        textBoxPublishing.Clear();
                        textBoxYearOfPublishing.Clear();
                        textBoxPages.Clear();
                        Close();
                    }
                    else
                    {
                        throw new ArgumentException("Неправильний формат\nПравильний формат -> dd.MM.yyyy\ndd(1-31),MM(1-12),yyyy(0-2023)");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}