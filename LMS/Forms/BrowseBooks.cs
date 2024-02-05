using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS.Forms
{
    public partial class BrowseBooks : UserControl
    {
        Library library;
        DataTable bookDataTable;
        List<Book> bookList;
        public BrowseBooks(Library library)
        {
            this.library = library;
            bookList = library.getAllBooks();

            InitializeComponent();
            initializeTable();
            this.filterComboBox.SelectedIndex = 0;
            this.availbilityFilterComboBox.SelectedIndex = 0;
        }

        public BrowseBooks()
        {
            bookList = LibraryDatabase.getRecords<Book>("Books");
            InitializeComponent();
            initializeTable();
            this.filterComboBox.SelectedIndex = 0;
            this.availbilityFilterComboBox.SelectedIndex = 0;
        }
        void initializeTable()
        {
            bookDataTable = new DataTable();

            bookDataTable.Columns.Add("Book ID", typeof(string));
            bookDataTable.Columns.Add("Title", typeof(string));
            bookDataTable.Columns.Add("ISBN", typeof(string));
            bookDataTable.Columns.Add("Author", typeof(string));
            bookDataTable.Columns.Add("Copies", typeof(int));
            bookDataTable.Columns.Add("Availability", typeof(String));

            populateBooks(bookList);
        }
        void populateBooks(List<Book> books)
        {

            foreach (Book book in books)
            {
                addDataIntoTable(book);
            }

            this.booksDataGridView.DataSource = bookDataTable;
        }

        void addDataIntoTable(Book book)
        {
            bookDataTable.Rows.Add(book.Id, book.Title, book.ISBN, book.Author, book.Copies, book.Availability ? "Available" : "Unavailable");
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            bookDataTable = new DataTable();
            initializeTable();
            this.availbilityFilterComboBox.SelectedIndex = 0;
            this.searchTxt.Clear();
            this.filterComboBox.SelectedIndex = 0;
        }

        private void filterTable(string attribute, string keyword)
        {
            DataView dataview = bookDataTable.DefaultView;
            dataview.RowFilter = $"{attribute} LIKE '" + keyword + "%'";
            this.booksDataGridView.DataSource = dataview;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if(this.filterComboBox.Text == "Title")
            {
                filterTable("Title", this.searchTxt.Text);
            }
            else
            {
                filterTable("ISBN", this.searchTxt.Text);
            }
        }

        private void availbilityFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(availbilityFilterComboBox.SelectedIndex)
            {
                case 0:
                    bookDataTable = new DataTable();
                    initializeTable();
                    break;
                case 1:
                    filterTable("Availability", "Available");
                    break;

                case 2:
                    filterTable("Availability", "Unavailable");
                    break;
            }
            this.searchTxt.Clear();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filterComboBox.Text == "Title")
            {
                filterTable("Title", this.searchTxt.Text);
            }
            else if (this.filterComboBox.Text == "ISBN")
            {
                filterTable("ISBN", this.searchTxt.Text);
            }
        }
    }
}
