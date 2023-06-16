using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Calendar
    {
        Student loggedinStudent;
        public Calendar(Student? loggedinStudent)
        {
            this.loggedinStudent = loggedinStudent;
        }
        public static int static_month, static_year;
        public void displayDays(Panel daycontainer, Label lbMonth, int month, int year)
        {

            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException("year", "Year value must be between 1 and 9999.");
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month value must be between 1 and 12.");
            }

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            static_month = month;
            static_year = year;

            // Clear the controls inside the panel
            daycontainer.Controls.Clear();

            // Add blank controls for the days before the start of the month
            for (int i = 1; i < (int)startOfMonth.DayOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // Add controls for each day of the month
            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucdays = new UserControlDays(loggedinStudent);
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            // Set the month name label
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbMonth.Text = monthName + " " + year;
        }

    }
}
