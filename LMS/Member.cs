using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Member : User
{
    List<String> borrowedBooksISBN;

    public List<String> BorrowedBooksISBN
    {
        get { return borrowedBooksISBN; }
        set { borrowedBooksISBN = value; }
    }

    public Member(string id, string userName, string password, string firstName, string lastName) : base(id, userName, password, firstName, lastName)
    {
        this.IsAdmin = false;
        this.BorrowedBooksISBN = new List<String>();
    }

    public override void borrowBook(string isbn, string memberId = "")
    {
        try
        {
            if (this.borrowedBooksISBN.Contains(isbn))
            {
                MessageBox.Show("This book has been already borrowed by the user!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.borrowedBooksISBN.Count >= 2)
            {
                MessageBox.Show("Number of Borrowed Books Limit exceeded", "Borrow Book Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Book book = LibraryDatabase.getRecordBy<Book>("ISBN", isbn, "Books");
                book.borrowBook(this);
                this.BorrowedBooksISBN.Add(book.ISBN);
                LibraryDatabase.updateRecord<Book>("Books", book.Id, book);
                LibraryDatabase.updateRecord<User>("Users", this.Id, this);
                MessageBox.Show("Book Issued Successfully!", "Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Could not Borrow the Book!\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    public override void returnBook(string isbn, string memberId = "")
    {
        try
        {
            if (this.borrowedBooksISBN.Contains(isbn))
            {
                Book book = LibraryDatabase.getRecordBy<Book>("ISBN", isbn, "Books");
                book.returnBook(this);
                this.BorrowedBooksISBN.Remove(book.ISBN);
                LibraryDatabase.updateRecord<Book>("Books", book.Id, book);
                LibraryDatabase.updateRecord<User>("Users", this.Id, this);

                MessageBox.Show("Book Returned Successfully!", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Member has not borrowed this Book!", "Book not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception e)
        {
            MessageBox.Show($"Could not return the Book!\n\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public List<Book> showBorrowedBooks()
    {
        try
        {
            List<Book> books = new List<Book>();

            foreach (var isbn in borrowedBooksISBN)
            {
                books.Add(LibraryDatabase.getRecordBy<Book>("ISBN", isbn, "Books"));
            }

            return books;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred!\n{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}