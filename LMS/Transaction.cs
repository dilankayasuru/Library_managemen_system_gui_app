using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


class Transaction
{
    string member;
    string memberID;

    string librarian;
    string librarianID;

    string book;
    string bookISBN;

    DateTime transactionDate;

    string transactionType;

    public Transaction(string member, string memberID, string librarian, string librarianID, string book, string bookISBN, DateTime transactionDate, string transactionType)
    {
        this.member = member;
        this.memberID = memberID;
        this.librarian = librarian;
        this.librarianID = librarianID;
        this.book = book;
        this.bookISBN = bookISBN;
        this.transactionDate = transactionDate;
        this.transactionType = transactionType;
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
    public string TransactionType
    {
        get { return transactionType; }
        set { transactionType = value; }
    }
}