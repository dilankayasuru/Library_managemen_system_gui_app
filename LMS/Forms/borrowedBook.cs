using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class borrowedBook : UserControl
    {
        Book book;
        public borrowedBook(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void borrowedBook_Load(object sender, EventArgs e)
        {
            this.titleTxt.Text = book.Title;
            this.isbnTxt.Text = book.ISBN;
            this.authorTxt.Text = book.Author;
            this.publishedYearTxt.Text = book.PublishhedYear.ToString();

        }
    }
}
