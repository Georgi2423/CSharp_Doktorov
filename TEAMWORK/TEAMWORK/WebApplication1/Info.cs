using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Info
    {
        public DateTime Date { get; set; }

        public string Expense { get; set; }

        public double Price { get; set; }

        public Info(DateTime date, string expense, double price)
        {
            this.Date = date;
            this.Expense = expense;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Date, this.Expense, this.Price);
        }

    }
}