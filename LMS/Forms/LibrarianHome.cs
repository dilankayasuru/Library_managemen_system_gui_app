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
    public partial class LibrarianHome : UserControl
    {
        Library library;
        List<Book> books = new List<Book>();
        public LibrarianHome(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void LibrarianHome_Load(object sender, EventArgs e)
        {
            books = library.getAllBooks();

            totalBookCount.Text = books.Count.ToString();
            availableCount.Text = books.FindAll(b => b.Availability).Count.ToString();
            issuedBookCount.Text = books.FindAll(b => (b.BorrowedMemberByID.Count > 0)).Count.ToString();
            totalMemberCount.Text = library.getAllBooks().Count.ToString();

            MemberHome.centerLable(this.totalBookPanel, this.totalBookCount, 10);
            MemberHome.centerLable(this.availableBookPanel, this.availableCount, 10);
            MemberHome.centerLable(this.issuedBooksPanel, this.issuedBookCount, 10);
            MemberHome.centerLable(this.totalMembersPanel, this.totalMemberCount, 10);
        }
    }
}
