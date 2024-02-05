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
    public partial class ManageBooks : UserControl
    {
        Library library;
        DataTable bookDataTable;
        List<Book> bookList;
        public ManageBooks(Library library)
        {
            this.library = library;
            InitializeComponent();
            initializeTable();
            this.filterComboBox.SelectedIndex = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearTexts();
        }

        void initializeTable()
        {
            bookList = new List<Book>();
            bookList = library.getAllBooks();

            bookDataTable = new DataTable();
           
            bookDataTable.Columns.Add("Book ID", typeof(string));
            bookDataTable.Columns.Add("Title", typeof(string));
            bookDataTable.Columns.Add("ISBN", typeof(string));
            bookDataTable.Columns.Add("Author", typeof(string));
            bookDataTable.Columns.Add("PublishedYear", typeof(int));
            bookDataTable.Columns.Add("Copies", typeof(int));
            bookDataTable.Columns.Add("Availability", typeof(string));
            bookDataTable.Columns.Add("Borrowed User(ID)", typeof(string));

            string borrowedUser;
            foreach (Book book in bookList)
            {
                borrowedUser = "";
                book.BorrowedMemberByID.ForEach(m => borrowedUser += m.ToString() + " | ");
                bookDataTable.Rows.Add(book.Id, book.Title, book.ISBN, book.Author, book.PublishhedYear, book.Copies, book.Availability ? "Available" : "Unavailable", borrowedUser);
            }

            this.booksDataGridView.DataSource = bookDataTable;
        }

        private void addNewBookBtn_Click(object sender, EventArgs e)
        {
            AddNewBook window = new AddNewBook(library);
            window.ShowDialog();
            initializeTable();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchInTable();
        }

        public void clearTexts()
        {
            this.bookTitleTxt.Clear();
            this.authorTxt.Clear();
            this.ISBNTxt.Clear();
            this.publishedYearTxt.Clear();
            this.copiesTxt.Clear();
            this.bookIdTxt.Clear();
            this.searchTxt.Clear();
        }

        private void searchInTable()
        {
            switch (filterComboBox.SelectedIndex)
            {
                case 0:
                    filterTable("Title", this.searchTxt.Text);
                    break;

                case 1:
                    filterTable("ISBN", this.searchTxt.Text);
                    break;

                case 2:
                    filterTable("BookID", this.searchTxt.Text);
                    break;
            }
        }

        private void filterTable(string attribute, string keyword)
        {
            DataView dataview = bookDataTable.DefaultView;
            dataview.RowFilter = $"{attribute} LIKE '" + keyword + "%'";
            this.booksDataGridView.DataSource = dataview;
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchInTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.bookTitleTxt.Text != "")
            {
                if (MessageBox.Show($"Are you sure you want to delete this {this.bookTitleTxt.Text} Book!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        library.removeBook(this.bookIdTxt.Text);
                        clearTexts();
                        initializeTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearTexts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTexts();
            }
        }

        private void booksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bookIdTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
            this.bookTitleTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
            this.ISBNTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
            this.authorTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
            this.publishedYearTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
            this.copiesTxt.Text = bookDataTable.Rows[booksDataGridView.CurrentCell.RowIndex].ItemArray[5].ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (this.bookIdTxt.Text == "" || this.bookTitleTxt.Text == "" || this.ISBNTxt.Text == "" || this.authorTxt.Text == "" || this.publishedYearTxt.Text == "" || this.copiesTxt.Text =="")
            {
                MessageBox.Show("Please enter valid information!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int publishedYear = int.Parse(this.publishedYearTxt.Text);
                    int copies = int.Parse(this.copiesTxt.Text);

                    library.editBookDetails(this.bookIdTxt.Text, this.bookTitleTxt.Text, this.ISBNTxt.Text, this.authorTxt.Text, publishedYear, copies);
                    initializeTable();
                    clearTexts();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Publication Year and Number of Copies!", "Invalid Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.publishedYearTxt.Clear();
                    this.copiesTxt.Clear();
                    this.publishedYearTxt.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTexts();
                }
            }
        }
    }
}
