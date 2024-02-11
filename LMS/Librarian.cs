using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[BsonIgnoreExtraElements]
public class Librarian : User
{
    public Librarian(string id, string userName, string password, string firstName, string lastName) : base(id, userName, password, firstName, lastName)
    {
        this.IsAdmin = true;
    }

    // Add new book to the library database
    public List<Member> getAllMembers()
    {
        List<Member> members = new List<Member>();
        var users = LibraryDatabase.getRecords<User>("Users").FindAll(u => u is Member);
        foreach (var user in users)
        {
            members.Add(user as Member);
        }

        return members;
    }
    // Add new book to the library database 
    public void addNewMember(string id, string username, string password, string firstName, string lastname)
    {
        Member member = new Member(id, username, password, firstName, lastname);
        LibraryDatabase.insertRecord<User>("Users", member);
        MessageBox.Show("Member added successfully", "Member Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    // Edit member details
    public void editMemberDetail(string id, string firstName, string lastName)
    {
        Member member = LibraryDatabase.getRecordBy<User>("Users", id) as Member;

        member.FirstName = firstName;
        member.LastName = lastName;

        LibraryDatabase.updateRecord<User>("Users", id, member);
    }
    // Delete member from the database
    public void deleteMemberDetail(string id)
    {
        // get member by id
        Member member = LibraryDatabase.getRecordBy<Member>("Users", id);

        if (member.BorrowedBooksISBN.Count > 0)
        {
            MessageBox.Show($"Member can not delete since {member.BorrowedBooksISBN.Count} books are being borrow this member!", "Delete Prohibited!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (member != null)
        {
            LibraryDatabase.deleteRecord<User>("Users", id);
            MessageBox.Show("Member Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Member not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public override void borrowBook(string isbn, string memberId)
    {
        try
        {
            // get member by id
            var targetMember = LibraryDatabase.getRecordBy<User>("Users", memberId);
            Book book = LibraryDatabase.getRecordBy<Book>("ISBN", isbn, "Books");

            if (targetMember == null || book == null || targetMember is Librarian)
            {
                MessageBox.Show("Book or Member not found in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // check if the member has already borrowed the book or the number of borrowed books limit exceeded
                Member member = targetMember as Member;
                if (member.BorrowedBooksISBN.Contains(book.ISBN) || member.BorrowedBooksISBN.Count >= 2)
                {
                    MessageBox.Show("Number of Borrowed Books Limit exceeded or Member has already borrowed this book", "Borrow Book Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool isBookBorrowed = book.borrowBook(member);
                    if (isBookBorrowed)
                    {
                        this.transactionRecord(book.ISBN, Transaction_Type.Borrow_Book, member);
                        MessageBox.Show("Book Issued Successfully!", "Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //member.BorrowedBooksISBN.Add(book.ISBN);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message} \n Help : {ex.HelpLink}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public override void returnBook(string isbn, string memberId)
    {
        try
        {
            // get member by id
            var targetMember = LibraryDatabase.getRecordBy<User>("Users", memberId);
            Book book = LibraryDatabase.getRecordBy<Book>("ISBN", isbn, "Books");
            if (targetMember is Member)
            {
                Member member = targetMember as Member;
                bool isBookReturned = book.returnBook(member);
                if (isBookReturned)
                {
                    this.transactionRecord(book.ISBN, Transaction_Type.Return_Book, member);
                    MessageBox.Show("Book Returned Successfully!", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch
        {
            MessageBox.Show("Book or Member not found in the Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public List<Transaction> readAllTTransactions()
    {
        return LibraryDatabase.getRecords<Transaction>("Transaction");
    }
}