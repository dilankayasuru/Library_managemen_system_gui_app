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
    // Getters and Setters
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
        // Get all books from the database
        this.bookCollection = LibraryDatabase.getRecords<Book>("Books");

        return this.bookCollection;
    }

    public void addNewBook(string id, string title, string iSBN, string author, int publishhedYear, int copies)
    {
        try
        {
            // Create a new book object
            Book book = new Book(id, title, iSBN, author, publishhedYear, copies);
            // Insert the book into the database
            LibraryDatabase.insertRecord<Book>("Books", book);
            MessageBox.Show("Book Added successfully!", "New Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch
        {
            // If the book already exists, show a message box
            MessageBox.Show("Book already exists!", "Duplicate ID!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public List<Member> getAllMembers()
    {
        // Get all members from the database
        List<Member> members = new List<Member>();
        var users = LibraryDatabase.getRecords<User>("Users").FindAll(u => u is Member).ToList();
        foreach (var user in users)
        {
            // Add the user to the members list
            members.Add(user as Member);
        }
        return members;
    }

    public void removeBook(string id)
    {
        // Get the book by its ID
        Book book = LibraryDatabase.getRecordBy<Book>("Books", id);
        // If the book is being borrowed by a member, show a message box
        if (book.BorrowedMemberByID.Count > 0)
        {
            // Show a message box
            MessageBox.Show($"Book can not delete since {book.BorrowedMemberByID.Count} members are being borrow this book!", "Delete Prohibited!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (book != null)
        {
            // If the book is not being borrowed, delete the book from the database
            LibraryDatabase.deleteRecord<Book>("Books", id);
            MessageBox.Show("Book Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Book not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    // Edit book details
    public void editBookDetails(string id, string title, string isbn, string author, int publishedYear, int copies)
    {
        try
        {
            // Get the book by its ID
            Book book = LibraryDatabase.getRecordBy<Book>("Books", id);

            // If the number of copies is greater than the number of members the book is borrowed by, update the book details
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
        // If the book is not found, show a message box
        catch (NullReferenceException)
        {
            MessageBox.Show("Book not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // If the book already exists, show a message box
        catch (MongoDuplicateKeyException)
        {
            MessageBox.Show("Please enter unique ISBN number and Book ID", "Duplicate ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

