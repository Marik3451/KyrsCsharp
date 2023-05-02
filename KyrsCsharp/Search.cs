using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KyrcCsharp
{
    public partial class Search : Form
    {

        private BindingList<Book> booksList;
        BindingList<Book> result = new BindingList<Book>();
        
        public Search(BindingList<Book> booksList)
        {
            InitializeComponent();
            this.booksList = booksList;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBoxAuthor.Text;
            string title = textBoxTitle.Text;
            string publishing = textBoxPublishing.Text;
            string yearOfPublishing = textBoxYearOfPublishing.Text;
            result.Clear();
            IEnumerator<Book> enumerator = booksList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Book book = enumerator.Current;
                if (book.IsSimiliar(author, title, publishing, yearOfPublishing))
                {
                    result.Add(book);
                }
            }

            if (result.Any())
            {
                Result resulta = new Result(result);
                resulta.ShowDialog();
                result.Clear();
            }
            else
            {
                MessageBox.Show("No results found.");
            }
        }


    }
}
