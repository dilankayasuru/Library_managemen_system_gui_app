using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


public class Transaction
{
    string id;

    string memberName;
    string memberID;

    string librarianName;
    string librarianID;

    string bookTitle;
    string bookISBN;

    DateTime transactionDate;

    Transaction_Type transactionType;

    Performed_By performedBy;

    public Transaction(Book book, Member member, Transaction_Type transactionType)
    {
        this.memberName = $"{member.FirstName} {member.LastName}";
        this.memberID = member.Id;
        this.bookTitle = book.Title;
        this.bookISBN = book.ISBN;
        this.transactionDate = DateTime.UtcNow;
        this.transactionType = transactionType;
        this.performedBy = Performed_By.Member;
    }

    public Transaction(Book book, Member member, Transaction_Type transactionType, Librarian librarian)
    {
        this.memberName = $"{member.FirstName} {member.LastName}";
        this.memberID = member.Id;
        this.librarianName = $"{librarian.FirstName} {librarian.LastName}";
        this.librarianID = librarian.Id;
        this.bookTitle = book.Title;
        this.bookISBN = book.ISBN;
        this.transactionDate = DateTime.UtcNow;
        this.transactionType = transactionType;
        this.performedBy = Performed_By.Librarian;
    } 


    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public string MemberName
    {
        get { return memberName; }
        set { memberName = value; }
    }
    public string MemberID
    {
        get { return memberID; }
        set { memberID = value; }
    }
    public string LibrarianName
    {
        get { return librarianName; }
        set { librarianName = value; }
    }
    public string LibrarianID
    {
        get { return librarianID; }
        set { librarianID = value; }
    }
    public string BookTitle
    {
        get { return bookTitle; }
        set { bookTitle = value; }
    }
    public string BookISBN
    {
        get { return bookISBN; }
        set { bookISBN = value; }
    }

    public DateTime TransactionDate
    {
        get { return transactionDate; }
        set { transactionDate = value; }
    }

    public Transaction_Type TransactionType
    {
        get { return transactionType; }
        set { transactionType = value; }
    }
    public Performed_By PerformedBy
    {
        get { return performedBy; }
        set { performedBy = value; }
    }
}

// Enumerations
public enum Transaction_Type
{
    Borrow_Book = 0,
    Return_Book = 1,
}

public enum Performed_By
{
    Librarian = 0,
    Member = 1,
}