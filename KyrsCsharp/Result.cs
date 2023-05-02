using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrcCsharp
{
    public partial class Result : Form
    {
        private IEnumerable<Book> booksList;

        public Result(IEnumerable<Book> result)
        {
            InitializeComponent();
            this.booksList = result;
            dataGridView1.DataSource = booksList;
           
        }

        private void Result_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[0].HeaderText = "Автор";
            dataGridView1.Columns[1].HeaderText = "Назва книга";
            dataGridView1.Columns[2].HeaderText = "Видавництво";
            dataGridView1.Columns[3].HeaderText = "Рік видання";
            dataGridView1.Columns[4].HeaderText = "К-сть сторінок";

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
        }
    }
}



