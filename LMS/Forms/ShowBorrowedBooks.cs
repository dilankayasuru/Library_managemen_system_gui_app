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
    public partial class ShowBorrowedBooks : UserControl
    {
        Member member;
        public List<Book> borrowedBooksList = new List<Book>();
        public ShowBorrowedBooks(Member member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void ShowBorrowedBooks_Load(object sender, EventArgs e)
        {
            displayBorrowedBooks();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            displayBorrowedBooks();
        }

        private void displayBorrowedBooks()
        {
            this.borrowedBooksPanel.Controls.Clear();
            borrowedBooksList = member.showBorrowedBooks();
            if (borrowedBooksList != null)
            {
                foreach (Book book in borrowedBooksList)
                {
                    borrowedBooksPanel.Controls.Add(new borrowedBook(book));
                }
            }
        }
    }
}
