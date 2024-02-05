using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms.SearchUI
{
    public partial class result : UserControl
    {
        Book book;
        public result(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void result_Load(object sender, EventArgs e)
        {
            this.titleTxt.Text = book.Title;
            this.isbnTxt.Text = book.ISBN;
            this.authorTxt.Text = book.Author;
            this.publishedYearTxt.Text = book.PublishhedYear.ToString();
            if (this.book.Availability) { this.availabilityTxt.Text = "Book is Available to Borrow"; }
            else this.availabilityTxt.Text = "Book is Currently Unavailable";
        }
    }
}
