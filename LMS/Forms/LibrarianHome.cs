using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class LibrarianHome : UserControl
    {
        Library library;
        List<Book> books = new List<Book>();
        Librarian librarian;
        List<Transaction> transactions;
        public LibrarianHome(Library library, Librarian librarian)
        {
            InitializeComponent();
            this.library = library;
            this.librarian = librarian;
        }

        private void LibrarianHome_Load(object sender, EventArgs e)
        {
            refreshSummary();
        }

        private void loadSummary()
        {
            books = library.getAllBooks();

            int totalCopies = 0;
            int availableCopies = 0;

            foreach (Book book in books)
            {
                totalCopies += book.Copies + book.BorrowedMemberByID.Count;

                if (book.Availability)
                {
                    availableCopies += book.Copies;
                }
            }


            totalBookCount.Text = totalCopies.ToString();

            availableCount.Text = availableCopies.ToString();

            issuedBookCount.Text = books.FindAll(b => (b.BorrowedMemberByID.Count > 0)).Count.ToString();

            totalMemberCount.Text = library.getAllMembers().Count.ToString();

            MemberHome.centerLable(this.totalBookPanel, this.totalBookCount, 10);
            MemberHome.centerLable(this.availableBookPanel, this.availableCount, 10);
            MemberHome.centerLable(this.issuedBooksPanel, this.issuedBookCount, 10);
            MemberHome.centerLable(this.totalMembersPanel, this.totalMemberCount, 10);

            this.filterComboBox.SelectedIndex = 0;
        }

        private void refreshSummary()
        {
            transactions = librarian.readAllTTransactions();
            this.transactionPanel.Controls.Clear();

            foreach (Transaction transaction in transactions)
            {
                this.transactionPanel.Controls.Add(new transactionCard(transaction, transactions.IndexOf(transaction)));
            }

            this.filterComboBox.SelectedIndex = 0;

            loadSummary();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filterComboBox.SelectedIndex == 0 && transactionPanel.Controls.Count > 0)
            {
                this.transactionPanel.FlowDirection = FlowDirection.BottomUp;
                this.transactionPanel.Controls[transactionPanel.Controls.Count - 1].Focus();
            }
            else if (this.filterComboBox.SelectedIndex == 1 && transactionPanel.Controls.Count > 0)
            {
                this.transactionPanel.FlowDirection = FlowDirection.TopDown;
                this.transactionPanel.Controls[0].Focus();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refreshSummary();
        }
    }
}
