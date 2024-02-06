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
    public partial class transactionCard : UserControl
    {
        Transaction transaction;
        int transactionIndex;
        public transactionCard(Transaction transaction, int transactionIndex)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.transactionIndex = transactionIndex;
        }

        private void transactionCard_Load(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                if (transaction.Issued == issuedBy.librarianIssued)
                {
                    this.performedByText.Text = $"Librarian: {transaction.Librarian} | ID: {transaction.LibrarianID}";
                }
                else
                {
                    this.performedByText.Text = $"Member: {transaction.Member} | ID: {transaction.MemberID}";
                }

                if (transaction.TransactionType == transactionType.borrowed)
                {
                    this.transactionNameTxt.Text = "Borrow Book";
                }
                else
                {
                    this.transactionNameTxt.Text = "Return Book";
                }

                this.transactionIDText.Text = transaction.Id.ToString();
                this.memberNameTxt.Text = transaction.Member.ToString();
                this.memberIdTxt.Text = transaction.MemberID.ToString();
                this.bookTitleTxt.Text = transaction.Book;
                this.bookISBNTxt.Text = transaction.BookISBN;
                this.transactionDate.Value = transaction.TransactionDate;

                this.count.Text = (this.transactionIndex + 1).ToString();
            }
        }
    }
}
