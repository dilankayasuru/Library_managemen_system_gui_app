using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Book
{
    // Book class properties
    string id;
    string title;
    string isbn;
    string author;
    bool availability;
    int publishedYear;
    int copies;
    List<String> borrowedMemberByID;

    // Getters and Setters
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public bool Availability
    {
        get { return availability; }
        private set { availability = value; }
    }

    public int PublishhedYear
    {
        get { return publishedYear; }
        set { publishedYear = value; }
    }

    public int Copies
    {
        get 
        { return copies; }
        set 
        { 
            // Automatically set availability by copies
            copies = value; 
            checkAvailability();
            if (copies <= 0) this.Availability = false;
            else this.Availability = true;
        }
    }

    public List<String> BorrowedMemberByID
    {
        get { return borrowedMemberByID; }
        set { borrowedMemberByID = value; }
    }

    public Book(string id, string title, string iSBN, string author, int publishhedYear, int copies)
    {
        Id = id;
        Title = title;
        ISBN = iSBN;
        Author = author;
        PublishhedYear = publishhedYear;
        Copies = copies;
        BorrowedMemberByID = new List<String>();
    }
    // Check availability by the number of copies
    public bool checkAvailability()
    {
        if (this.copies <= 0)
        {
            this.availability = false;
            return this.availability;
        }
        else
        {
            this.availability = true;
            return this.availability;
        }
    }

    // Borrow book and add the member to the borrowedMemberByID list
    public bool borrowBook(Member member)
    {
        Member borrowingMember = member;
        if (availability)
        {
          
            this.Copies--;
            // Add the member to the borrowedMemberByID list
            borrowedMemberByID.Add(member.Id);
            borrowingMember.BorrowedBooksISBN.Add(this.ISBN);
            LibraryDatabase.updateRecord<Book>("Books", this.id, this);
            LibraryDatabase.updateRecord<User>("Users", borrowingMember.Id, borrowingMember);
            return true;
        }
        else
        {
            // Show a message box
            MessageBox.Show($"Requested book is not available!", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Return book
    public bool returnBook(Member member)
    {
        Member returningMember = member;
        if (this.borrowedMemberByID.Contains(member.Id))
        {
            // Increase the number of copies
            this.Copies++;
            // Remove the member from the borrowedMemberByID list
            borrowedMemberByID.Remove(member.Id);
            returningMember.BorrowedBooksISBN.Remove(this.ISBN);
            LibraryDatabase.updateRecord<Book>("Books", this.id, this);
            LibraryDatabase.updateRecord<User>("Users", returningMember.Id, returningMember);
            return true;
        }
        else
        {
            // Show a message box
            MessageBox.Show($"Book is not borrowed by Member!", "Not borrowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}