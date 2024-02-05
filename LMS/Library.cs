using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Library
{
    List<Book> bookCollection;
    List<Member> members;

    public Library()
    {
        this.bookCollection = getAllBooks();
        this.members = getAllMembers();
    }

    public List<Book> BookCollection
    {
        get { return bookCollection; }
        private set { bookCollection = value; }
    }

    public List<Member> Members
    {
        get { return members; }
        private set { members = value; }
    }

    public List<Book> getAllBooks()
    {
        this.bookCollection = LibraryDatabase.getRecords<Book>("Books");

        return this.bookCollection;
    }

    public void addNewBook(string id, string title, string iSBN, string author, int publishhedYear, int copies)
    {
        try
        {
            Book book = new Book(id, title, iSBN, author, publishhedYear, copies);
            LibraryDatabase.insertRecord<Book>("Books", book);

        }
        catch
        {
            MessageBox.Show("Book already exists!", "Duplicate ID!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private List<Member> getAllMembers()
    {
        List<Member> members = new List<Member>();
        var users = LibraryDatabase.getRecords<User>("Users").FindAll(u => u is Member).ToList();
        foreach (var user in users)
        {
            members.Add(user as Member);
        }
        return members;
    }

    public void removeBook(string id)
    {
        Book book = LibraryDatabase.getRecordBy<Book>("Books", id);

        if (book.BorrowedMemberByID.Count > 0)
        {
            MessageBox.Show($"Book can not delete since {book.BorrowedMemberByID.Count} members are being borrow this book!", "Delete Prohibited!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (book != null)
        {
            LibraryDatabase.deleteRecord<Book>("Books", id);
            MessageBox.Show("Book Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Book not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void editBookDetails(string id, string title, string isbn, string author, int publishedYear, int copies)
    {
        try
        {
            Book book = LibraryDatabase.getRecordBy<Book>("Books", id);

            if (book.BorrowedMemberByID.Count <= copies)
            {
                book.Title = title;
                book.Author = author;
                book.ISBN = isbn;
                book.PublishhedYear = publishedYear;
                book.Copies = copies;
                LibraryDatabase.updateRecord<Book>("Books", id, book);
                MessageBox.Show("Book saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Number of copies can not be less than the number of members the book is borrowed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (MongoDuplicateKeyException)
        {
            MessageBox.Show("Please enter unique ISBN number and Book ID", "Duplicate ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

