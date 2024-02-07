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
    public partial class AddNewBook : Form
    {
        Library library;
        public AddNewBook(Library library)
        {
            this.library = library;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        void clearFields()
        {
            this.bookIdTxt.Clear();
            this.authorTxt.Clear();
            this.titleTxt.Clear();
            this.isbnTxt.Clear();
            this.publishedYearTxt.Clear();
            this.copiesTxt.Clear();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            string bookId;
            string title;
            string isbn;
            string author;
            int publishedYear;
            int numofcopies;
            if (isValidatedInputs())
            {
                try
                {
                    bookId = this.bookIdTxt.Text.Trim();
                    title = this.titleTxt.Text.Trim();
                    isbn = this.isbnTxt.Text.Trim();
                    author = this.authorTxt.Text.Trim();
                    publishedYear = Convert.ToInt32(this.publishedYearTxt.Text);
                    numofcopies = Convert.ToInt32(this.copiesTxt.Text);
                    if (numofcopies < 0)
                    {
                        MessageBox.Show("Please enter valid inputs!\nNumber of copies can not be less than zero!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.copiesTxt.Clear();
                        this.copiesTxt.Focus();
                    }
                    else if (publishedYear < 500)
                    {
                        MessageBox.Show("Please enter valid inputs!\nPublished year can't be less than 500", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.publishedYearTxt.Clear();
                        this.publishedYearTxt.Focus();
                    }
                    else if (DateTime.Now.Year < publishedYear)
                    {
                        MessageBox.Show("Please enter valid inputs!\nPublished year can't be in future", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.publishedYearTxt.Clear();
                        this.publishedYearTxt.Focus();
                    }
                    else
                    {
                        library.addNewBook(this.bookIdTxt.Text, this.titleTxt.Text, this.isbnTxt.Text, this.authorTxt.Text, publishedYear, numofcopies);
                        MessageBox.Show("Book Added successfully!", "New Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter an Integer number for Published Year and Number of Copies!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.publishedYearTxt.Clear();
                    this.copiesTxt.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid inputs!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearFields();
            }

        }

        private bool isValidatedInputs()
        {
            return
                this.bookIdTxt.Text.Trim() != ""
                && this.titleTxt.Text.Trim() != ""
                && this.isbnTxt.Text.Trim() != ""
                && this.authorTxt.Text.Trim() != ""
                && this.publishedYearTxt.Text.Trim() != ""
                && this.copiesTxt.Text != "";
        }

    }
}
