using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class IssueBook : Form
    {
        object activeUser;

        public IssueBook(object user)
        {
            InitializeComponent();
            activeUser = user;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (activeUser is Librarian)
            {
                clearTexts();
            }
            else
            {
                Close();
            }
        }

        private void clearTexts()
        {
            this.ISBNTxt.Clear();
            this.memberIDtxt.Clear();

            this.nameDetailTxt.Clear();
            this.memberIDtxt.Clear();
            this.titleDetailTxt.Clear();
            this.isbnDetailTxt.Clear();
            this.authorDetailTxt.Clear();
            this.publishedYearDetailTxt.Clear();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            if (activeUser is Member)
            {
                Member member = activeUser as Member;
                member.borrowBook(this.ISBNTxt.Text);
                clearTexts();
            }
            else
            {
                Librarian librarian = activeUser as Librarian;
                librarian.borrowBook(this.ISBNTxt.Text, this.memberIDtxt.Text);
                clearTexts();
            }
        }

        private void ISBNTxt_TextChanged(object sender, EventArgs e)
        {
            Book book = LibraryDatabase.getRecords<Book>("Books").Find(b => b.ISBN == this.ISBNTxt.Text);

            if (book != null)
            {
                this.isbnDetailTxt.Text = book.ISBN;
                this.titleDetailTxt.Text = book.Title;
                this.authorDetailTxt.Text = book.Author;
                this.publishedYearDetailTxt.Text = book.PublishhedYear.ToString();
            }
            else
            {
                this.isbnDetailTxt.Clear();
                this.titleDetailTxt.Clear();
                this.authorDetailTxt.Clear();
                this.publishedYearDetailTxt.Clear();
            }
        }

        private void memberIDtxt_TextChanged(object sender, EventArgs e)
        {
            Member member = LibraryDatabase.getRecords<User>("Users").Find(m => m.Id == this.memberIDtxt.Text) as Member;
            
            if (member != null)
            {
                this.idDetailTxt.Text = member.Id;
                this.nameDetailTxt.Text = $"{member.FirstName} {member.LastName}";
            }
            else
            {
                this.idDetailTxt.Clear();
                this.nameDetailTxt.Clear();
            }
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            if (activeUser is Member)
            {
                this.headerText.Text = "Borrow Books";
                this.Text = "Borrow Books";
            }
        }
    }
}
