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

    string member;
    string memberID;

    string librarian;
    string librarianID;

    string book;
    string bookISBN;

    DateTime transactionDate;

    transactionType transactionType;

    issuedBy issued;

    public Transaction(Member member, Librarian librarian, Book book, transactionType transaction)
    {
        this.member = member.FirstName;
        this.memberID = member.Id;
        this.librarian = librarian.FirstName;
        this.librarianID = librarian.Id;
        this.book = book.Title;
        this.bookISBN = book.ISBN;
        this.transactionDate = DateTime.UtcNow;
        this.transactionType = transaction;
        this.issued = issuedBy.librarianIssued;
    }    
    public Transaction(Member member, Book book, transactionType transaction)
    {
        this.member = member.FirstName;
        this.memberID = member.Id;
        this.book = book.Title;
        this.bookISBN = book.ISBN;
        this.transactionDate = DateTime.UtcNow;
        this.transactionType = transaction;
        this.issued = issuedBy.selfIssued;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public string Member
    {
        get { return member; }
        set { member = value; }
    }    
    public string MemberID
    {
        get { return memberID; }
        set { memberID = value; }
    }    
    public string Librarian
    {
        get { return librarian; }
        set { librarian = value; }
    }    
    public string LibrarianID
    {
        get { return librarianID; }
        set { librarianID = value; }
    }    
    public string Book
    {
        get { return book; }
        set { book = value; }
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

    public transactionType TransactionType
    {
        get { return transactionType; }
        set { value = transactionType; }
    }    
    public issuedBy Issued
    {
        get { return issued; }
        set { value = issued; }
    }
}

public enum transactionType
{
    borrowed, 
    returned
}

public enum issuedBy
{
    selfIssued, 
    librarianIssued 
}