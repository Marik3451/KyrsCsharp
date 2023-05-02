using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrcCsharp
{
    public class Book : Date
    {
        private string author;
        private string title;
        private string publishing;
        private Date yearOfPublishing;
        private int pages;

        public Book(Date yearOfPublishing)
        {
            author = "";
            title = "";
            publishing = "";
            this.yearOfPublishing = yearOfPublishing;
            pages = 0;
        }


        public Book(string author, string title, string publishing, Date yearOfPublishing, int pages)
        {
            Author = author;
            Title = title;
            Publishing = publishing;
            YearOfPublishing = yearOfPublishing;
            Pages = pages;
        }

        public Book()
        {
        }
        ~Book()
        {
        }

        public string Author { get => author; set => author = value; }

        public string Title { get => title; set => title = value; }

        public string Publishing { get => publishing; set => publishing = value; }

        public Date YearOfPublishing { get => this.yearOfPublishing; set => this.yearOfPublishing = value; }

        public int Pages { get => pages; set => pages = value; }

        public override string ToString()
        {
            return "Author = " + Author + ", Title = " + Title + ", Publishing = " + Publishing + ", YearOfPublishing = " + YearOfPublishing + ", Pages = " + Pages;
        }
       
        public class Library
        {
            public virtual void ReadBookInfo(Book book)
            {
                MessageBox.Show("Year of publishing: " + book.YearOfPublishing);
            }
        }

        public class Library2 : Library
        {
            public override void ReadBookInfo(Book book)
            {
                MessageBox.Show("Book title: " + book.Title);
            }
        }
        public static bool ValidateInput(string author, string title, string publishing, string yearOfPublishing, string pages)
        {
            bool isAuthorValid = Regex.IsMatch(author, @"^[a-zA-Zа-яА-Я\s]");
            bool isTitleValid = Regex.IsMatch(title, @"^[a-zA-Zа-яА-Я0-9\W\s]");
            bool isPublishingValid = Regex.IsMatch(publishing, @"^[a-zA-Zа-яА-Я\s]+$");
            bool isYearValid = Regex.IsMatch(yearOfPublishing, @"[0-9]");
            bool isPagesValid = Regex.IsMatch(pages, @"[0-9]");

            return isAuthorValid && isTitleValid && isPublishingValid && isYearValid && isPagesValid;
        }
        public bool IsSimiliar(string author, string title, string publishing, string yearOfPublishing)
        {
            if (!string.IsNullOrEmpty(author) && !Author.Contains(author))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(title) && !Title.Contains(title))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(publishing) && !Publishing.Contains(publishing))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(yearOfPublishing) && !YearOfPublishing.ToCompareString().Contains(yearOfPublishing))
            {
                return false;
            }

            return true;
        }

    }
}



