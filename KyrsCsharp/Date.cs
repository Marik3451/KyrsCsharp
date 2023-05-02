using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyrcCsharp
{
    public class Date
    {
        private int year;
        private int month;
        private int day;
        public Date(int year, int month, int day)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
        }

        public Date()
        {
        }
        ~Date()
        {

        }

        public int GetYear()
        {
            return this.year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Введіть місяць від 1 до 12!");
            }
            this.month = month;
        }

        public int GetDay()
        {
            return this.day;
        }

        public void SetDay(int day)
        {
            DateTime.DaysInMonth(this.year, this.month);

            if (day < 1 || day > 31)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[this.month - 1];
                throw new ArgumentException(String.Format("Місяць {0} містить від 1 до 31 дня!", monthName));
            }

            switch (this.month)
            {
                case 2:
                    if (day > 29)
                    {
                        throw new ArgumentException(String.Format("Лютий може мати лише 29 днів"));
                    }
                    else if (day == 29 && !DateTime.IsLeapYear(this.year))
                    {
                        throw new ArgumentException(String.Format("Рік {0} не є високосним, тому лютий може мати лише 28 днів", this.year));
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        string monthName = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[this.month - 1];
                        throw new ArgumentException(String.Format("Mісяць {0} може мати лише 30 днів!", monthName));
                    }
                    break;

                default:
                    break;
            }

            this.day = day;
        }
        public override string ToString()
        {
            string[] monthNames = new string[] {
        "Січня", "Лютого", "Березня", "Квітня", "Травня", "Червня",
        "Липня", "Серпня", "Вересня", "Жовтня", "Листопада", "Грудня"
        };
            return String.Format("{0} {1} {2}", this.day, monthNames[this.month - 1], this.year + " р.");
        }
        public string ToCompareString()
        {
            return String.Format("{0}.{1}.{2}", this.day, this.month, this.year);
        }


    }
}
