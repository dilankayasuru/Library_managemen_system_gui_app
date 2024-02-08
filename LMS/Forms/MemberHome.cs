using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class MemberHome : UserControl
    {
        Member activeUser;
        public MemberHome(Member activeUser)
        {
            this.activeUser = activeUser;
            InitializeComponent();
        }

        void initializeWindow()
        {
            this.memberIDtxt.Text = activeUser.Id;
            this.firstNameTxt.Text = activeUser.FirstName;
            this.lastNameTxt.Text = activeUser.LastName;
            this.userNameTxt.Text = activeUser.UserName;

            if (activeUser.BorrowedBooksISBN.Count > 0)
            {
                this.borrowedBooksCount.Text = activeUser.BorrowedBooksISBN.Count.ToString();
            }
            else
            {
                this.borrowedBooksCount.Text = "0";
            }

            borrowedBooksCount.Location = new System.Drawing.Point(
                (borrowedBooksPanel.Width - borrowedBooksCount.Width) / 2,
                (borrowedBooksPanel.Height - borrowedBooksCount.Height) / 2 - 10
            );
        }

        private void MemberHome_Load(object sender, EventArgs e)
        {
            initializeWindow();

            List<Book> books = LibraryDatabase.getRecords<Book>("Books").FindAll(b => b.Availability);
            this.availableBooksCount.Text = 0.ToString();
            int bookCount = 0;
            foreach (Book book in books)
            {
                bookCount += book.Copies;
                this.availableBooksCount.Text = bookCount.ToString();
                Thread.Sleep(10);
            }

            //this.availableBooksCount.Text = LibraryDatabase.getRecords<Book>("Books").FindAll(b => b.Availability).Count.ToString();

            centerLable(this.availableBooksPanel, this.availableBooksCount, 15);
            centerLable(this.borrowedBooksPanel, this.borrowedBooksCount, 15);

            loadQuotes();
        }

        public static void centerLable(Panel panel, System.Windows.Forms.Label lbl, int align = 0)
        {
            lbl.Location = new Point((panel.Width - lbl.Width)/2, (panel.Height - lbl.Height)/2 - align);
        }

        private void loadQuotes()
        {
            List<QuoteTemplate> quotes = LibraryDatabase.getRecords<QuoteTemplate>("DailyQuotes");
            int randonIndex = new Random().Next(0, quotes.Count);
            QuoteTemplate quote = quotes[randonIndex];

            this.quoteTxt.Text = $"{quote.Quote}\n\n-{quote.Author}-";
        }
    }
}
