﻿using System;
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

                if (this.transaction.PerformedBy.Equals(Performed_By.Librarian))
                {
                    this.performedByText.Text = $"Librarian: {transaction.LibrarianName} | ID: {transaction.LibrarianID}";
                }
                else
                {
                    this.performedByText.Text = $"Member: {transaction.MemberName} | ID: {transaction.MemberID}";
                }

                if (transaction.TransactionType.Equals(Transaction_Type.Return_Book))
                {
                    this.transactionNameTxt.Text = Transaction_Type.Return_Book.ToString();
                }
                else
                {
                    this.transactionNameTxt.Text = Transaction_Type.Borrow_Book.ToString();
                }

                this.transactionIDText.Text = transaction.Id.ToString();
                this.memberNameTxt.Text = transaction.MemberName;
                this.memberIdTxt.Text = transaction.MemberID;
                this.bookTitleTxt.Text = transaction.BookTitle;
                this.bookISBNTxt.Text = transaction.BookISBN;
                this.transactionDate.Value = transaction.TransactionDate;

                this.count.Text = (this.transactionIndex + 1).ToString();
            }
        }
    }
}
