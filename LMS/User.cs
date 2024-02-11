using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(Member), typeof(Librarian))]
public abstract class User
{
    string id;
    string userName;
    string password;
    string firstName;
    string lastName;
    bool isAdmin;

    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public string Id
    {
        get { return id; }
        set { id = value; }

    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public bool IsAdmin
    {
        get { return isAdmin; }
        set { isAdmin = value; }
    }

    protected User(string id, string userName, string password, string firstName, string lastName)
    {
        Id = id;
        UserName = userName;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }

    // User login
    internal bool userLogin(string username, string password)
    {
        if (this.UserName == username && this.password == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Borrow the book
    public abstract void borrowBook(string isbn, string memberID);

    // Return the book
    public abstract void returnBook(string isbn, string memberID);
    
    // Record the transaction
    public void transactionRecord(string ISBN, Transaction_Type transactionType)
    {
        Book book = LibraryDatabase.getRecordBy<Book>("ISBN", ISBN, "Books");
        Transaction transaction = new Transaction(book, this as Member, transactionType);
        LibraryDatabase.insertRecord<Transaction>("Transaction", transaction);
    }    
    // overload transactionRecord method for Librarian
    public void transactionRecord(string ISBN, Transaction_Type transactionType, Member member)
    {
        Book book = LibraryDatabase.getRecordBy<Book>("ISBN", ISBN, "Books");
        Transaction transaction = new Transaction(book, member, transactionType, this as Librarian);
        LibraryDatabase.insertRecord<Transaction>("Transaction", transaction);
    }
}