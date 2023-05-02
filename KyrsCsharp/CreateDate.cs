using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace KyrcCsharp
{
    public partial class CreateDate : Form
    {
        public BindingList<Date> dateList;

        public CreateDate()
        {
            InitializeComponent();
            this.dateList = new BindingList<Date>();
            ShowDate.DataSource = dateList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textYear.Text, out int year) && int.TryParse(textMonth.Text, out int month) && int.TryParse(textDay.Text, out int day))
            {
                try
                {
                    Date date = new Date(year, month,day);
                    dateList.Add(date);
                    textYear.Clear();
                    textMonth.Clear();
                    textDay.Clear();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }
    }
}



