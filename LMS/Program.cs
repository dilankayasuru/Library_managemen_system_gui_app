using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LMS.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Bindings;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace LMS
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize library
            Library library = new Library();
            int option = 0;
            bool isClosing = false;
            do
            {
                try
                {
                    // Clear console
                    Console.Clear();
                    // Display welcome message
                    Console.WriteLine("Library Management System");
                    Console.WriteLine();
                    // Display main menu
                    Console.WriteLine("\t1. Run GUI Application");
                    Console.WriteLine("\t2. Run Console Application");
                    Console.WriteLine("\t3. Exit");
                    Console.WriteLine();
                    Console.Write("Please enter an option: ");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //Hide console window and run gui application
                            FreeConsole();
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new MainWindow(library));
                            isClosing = true;
                            break;
                        case 2:
                            // run console application
                            runConsoleApplication(library);
                            break;
                        case 3:
                            // Display exiting message
                            exitingMessage();
                            // Making exit criteria
                            isClosing = true;
                            break;
                        default:
                            // Display invalid input error message
                            invalidInputMessage();
                            break;
                    }
                }
                catch
                {
                    // Display invalid input error message
                    invalidInputMessage();
                }

            } while (!isClosing);
        }


        // Run console Application (main method for console application)
        static void runConsoleApplication(Library library)
        {
            Console.Clear();
            // Initializing library
            library = new Library();

            int option = 0;
            // exit console criteria
            bool isClosing = false;
            do
            {
                try
                {
                    // Clear console
                    Console.Clear();
                    // Display customized welcome message
                    welcomeMessage();
                    Console.WriteLine();
                    Console.WriteLine("\t1. Search books by title");
                    Console.WriteLine("\t2. Login");
                    Console.WriteLine("\t3. Exit");
                    Console.WriteLine();
                    Console.Write("Select an option: ");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            // Calling Search books method
                            searchBookByTitle();
                            break;

                        case 2:
                            // Calling login interface
                            login();
                            break;

                        case 3:
                            exitingMessage("Going Back to main menu");
                            // Setting exit criteria
                            isClosing = true;
                            break;

                        default:
                            invalidInputMessage();
                            // Back to continue if user enter a invalid input
                            continue;
                    }
                }
                catch
                {
                    invalidInputMessage();
                    // Back to continue if user enter a invalid input
                    continue;
                }

            } while (!isClosing);

            // Customized welcome message
            void welcomeMessage(string name = "Guest User")
            {
                Console.WriteLine($"Hi! {name}");
                Console.WriteLine("Welcome to Library Management System!");
            }

            // Search Books by title in the main interface
            void searchBookByTitle()
            {
                // Clear the console
                Console.Clear();
                Console.WriteLine("Search Books by title...");
                Console.WriteLine();
                Console.Write("Enter title: ");
                string search = Console.ReadLine();
                Console.WriteLine();
                // Calling search book method to get books by title
                searchBooksBy(library, BooksBy.Title, search);
            }

            // Login interface for console application
            void login()
            {
                // Initialize and declare username and password
                string username = "";
                string password = "";

                Console.Clear();
                Console.WriteLine("Please enter your User Name and Password!");
                Console.WriteLine();

                // Read username input
                Console.Write("\tUser name: ");
                username = Console.ReadLine();

                // Read password input
                Console.Write("\tPassword: ");
                password = Console.ReadLine();

                // Find user in the database
                var user = LibraryDatabase.getRecordBy<User>("UserName", username, "Users");

                if (user != null && user.userLogin(username, password))
                {
                    // Check if the user is Librarian
                    if (user.IsAdmin)
                    {
                        Librarian activeUser = user as Librarian;
                        // Calling librarian's interface
                        librarianConsoleInterface(activeUser);
                    }
                    // Set Member
                    else
                    {
                        Member activeUser = user as Member;
                        // Calling member's interface
                        memberConsoleInterface(activeUser);
                    }
                }
                else
                {
                    // Display error message if user is null if name is incorrect
                    Console.WriteLine();
                    Console.WriteLine("Invalid Username or Password!");
                    Console.WriteLine();
                    continueMessage();
                }

            }

            // Console for member's operations
            void memberConsoleInterface(Member member)
            {
                Member activeMember = member;

                // Keep member's interface until user exit
                bool isRunning = true;
                do
                {
                    try
                    {
                        Console.Clear();
                        // Display customized welcome message
                        welcomeMessage(activeMember.FirstName);
                        Console.WriteLine();

                        // Display member's menu
                        Console.WriteLine("\t1. Browse Books");
                        Console.WriteLine("\t2. Return Books");
                        Console.WriteLine("\t3. Borrow Books");
                        Console.WriteLine("\t4. View Borrowed Books");
                        Console.WriteLine("\t5. Logout");
                        Console.WriteLine();

                        // Get user choice
                        Console.Write("Select an option: ");
                        option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                // Calling search books method
                                searchBooks();
                                break;

                            case 2:
                                // Calling return book method
                                returnBook(activeMember);
                                break;

                            case 3:
                                // Calling issue book method
                                issueBook(activeMember);
                                break;

                            case 4:
                                // Display borrowed books
                                showBorrowedBooks(activeMember);
                                break;

                            case 5:
                                // Display exiting message
                                exitingMessage($"Bye! {activeMember.FirstName}\nExiting to main menu");
                                isRunning = false;
                                break;

                            default:
                                // Display error message
                                Console.WriteLine();
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        // Display error message
                        invalidInputMessage();
                        continue;
                    }
                }
                while (isRunning);
            }

            // Console for librarian's operations
            void librarianConsoleInterface(Librarian librarian)
            {
                // declaration of active librarian
                Librarian activeLibrarian = librarian;

                // Keep Librarian's interface until user exit
                bool isRunning = true;
                do
                {
                    try
                    {
                        Console.Clear();
                        // Display customized welcome message
                        welcomeMessage(activeLibrarian.FirstName);
                        Console.WriteLine();

                        // Display Librarian's menu
                        Console.WriteLine("\t1. View Transaction History");
                        Console.WriteLine("\t2. Browse Books");
                        Console.WriteLine("\t3. Manage Books");
                        Console.WriteLine("\t4. Manage Members");
                        Console.WriteLine("\t5. Return Books");
                        Console.WriteLine("\t6. Borrow Books");
                        Console.WriteLine("\t7. Logout");
                        Console.WriteLine();

                        // Get user choice
                        Console.Write("Select an option: ");
                        option = int.Parse(Console.ReadLine());

                        // Switch case for user choice
                        switch (option)
                        {
                            case 1:
                                // Calling view transaction method
                                viewTransactions();
                                break;

                            case 2:
                                // Calling search books method
                                searchBooks();
                                break;

                            case 3:
                                // Calling manage books method
                                manageBooks(librarian);
                                break;

                            case 4:
                                // Calling manage members method
                                ManageMembers(librarian);
                                break;

                            case 5:
                                // Calling return book method 
                                returnBookByLibrarian(activeLibrarian);
                                break;

                            case 6:
                                // Calling issue book method
                                issueBookByLibrarian(activeLibrarian);
                                break;

                            case 7:
                                // Display exiting message
                                exitingMessage($"Bye! {librarian.FirstName}\nExiting to main menu");
                                isRunning = false;
                                break;

                            default:
                                // Display error message
                                Console.WriteLine();
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        // Display error message
                        Console.WriteLine();
                        invalidInputMessage();
                        continue;
                    }
                }
                while (isRunning);
            }

            // View transaction interface
            void viewTransactions()
            {
                // Get all the transactions from the database
                List<Transaction> transactions = LibraryDatabase.getRecords<Transaction>("Transaction");

                Console.Clear();
                Console.WriteLine("Transaction History...");
                Console.WriteLine();
                Console.WriteLine();

                // Display all the transactions
                int count = 0;
                foreach (Transaction transaction in transactions)
                {
                    // Increment count
                    count++;

                    // Display transaction details
                    Console.Write($"{count})");
                    Console.WriteLine($"\tID: {transaction.Id}");
                    Console.WriteLine($"\tTransaction type: {transaction.TransactionType.ToString()}");
                    Console.WriteLine($"\tPerformed By: {transaction.PerformedBy.ToString()}");
                    Console.WriteLine($"\tDate: {transaction.TransactionDate}");
                    Console.WriteLine($"\tBook Title: {transaction.BookTitle}");
                    Console.WriteLine($"\tBook ISBN: {transaction.BookISBN}");

                    // Display performed by details
                    if (transaction.PerformedBy == Performed_By.Librarian)
                    {
                        Console.WriteLine($"\tPerformed Librarian Name: {transaction.LibrarianName}");
                        Console.WriteLine($"\tPerformed Librarian ID: {transaction.LibrarianID}");
                    }
                    else
                    {
                        Console.WriteLine($"\tPerformed Member Name: {transaction.MemberName}");
                        Console.WriteLine($"\tPerformed Member ID: {transaction.MemberID}");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }

                continueMessage();
            }

            // Search books interface
            void searchBooks()
            {
                do
                {
                    try
                    {
                        // Initialize search keyword
                        string keyword;

                        // Initialize available book list
                        List<Book> availableBooks = new List<Book>();

                        Console.Clear();
                        Console.WriteLine("Browse Library Catalog");
                        Console.WriteLine();
                        Console.WriteLine("\t1. Search By ISBN");
                        Console.WriteLine("\t2. Search By Title");
                        Console.WriteLine("\t3. Show available Books");
                        Console.WriteLine("\t4. Back to main menu");
                        Console.WriteLine();

                        // Get user choice
                        Console.Write("Select an option: ");
                        option = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        // Switch case for user choice
                        switch (option)
                        {
                            case 1:
                                // Get search keyword
                                Console.Write("Enter Keyword to search: ");
                                keyword = Console.ReadLine();
                                Console.WriteLine();
                                searchBooksBy(library, BooksBy.ISBN, keyword);
                                break;

                            case 2:
                                // Get search keyword
                                Console.Write("Enter Keyword to search: ");
                                keyword = Console.ReadLine();
                                Console.WriteLine();
                                searchBooksBy(library, BooksBy.Title, keyword);
                                break;

                            case 3:
                                // Get all available books
                                availableBooks = library.getAllBooks();
                                foreach (Book book in availableBooks)
                                {
                                    displayBookDetails(book);
                                }
                                continueMessage();
                                break;

                            case 4:
                                // Display exit message
                                exitingMessage("Returning to main menu");
                                break;

                            default:
                                // Display error message
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        // Display error message
                        invalidInputMessage();
                    }

                } while (option != 4);
            }

            // Admin's manage books interface
            void manageBooks(Librarian librarian)
            {
                // Initialize manage book option
                int manageBookOpt = 0;
                do
                {
                    Console.Clear();
                    // Display manage book menu
                    Console.WriteLine("Manage Books...");
                    Console.WriteLine();
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Remove Book");
                    Console.WriteLine("3. Edit Book Details");
                    Console.WriteLine("4. Back");
                    Console.WriteLine();
                    Console.Write("Select an option: ");
                    manageBookOpt = int.Parse(Console.ReadLine());
                    // Switch case for user choice
                    switch (manageBookOpt)
                    {
                        case 1:
                            // Calling add book method
                            addBook(librarian);
                            break;

                        case 2:
                            // Calling remove book method
                            removeBook(librarian);
                            break;

                        case 3:
                            // Calling edit book method
                            editBookDetails(librarian);
                            break;

                        case 4:
                            Console.WriteLine();
                            // Display exiting message
                            exitingMessage("Returning to main menu");
                            break;

                        default:
                            // Display error message
                            invalidInputMessage();
                            break;
                    }

                } while (manageBookOpt != 4);
            }

            // Add book interface
            void addBook(Librarian librarian)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Add Books to Library");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\tBook Id: ");
                    string id = Console.ReadLine();

                    Console.Write("\tBook Title: ");
                    string title = Console.ReadLine();

                    Console.Write("\tBook ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.Write("\tBook Author: ");
                    string author = Console.ReadLine();

                    Console.Write("\tPublished Year: ");
                    int publishedYear = int.Parse(Console.ReadLine());

                    Console.Write("Enter Number of Book Copies: ");
                    int copies = int.Parse(Console.ReadLine());

                    // calling add new book method from library object
                    library.addNewBook(id, title, isbn, author, publishedYear, copies);

                }
                catch
                {
                    // Display error message
                    invalidInputMessage();
                }
            }

            // Remove book interface
            void removeBook(Librarian librarian)
            {
                Console.Clear();
                Console.WriteLine("Remove Books from Library");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tEnter Book Id: ");
                string id = Console.ReadLine();
                Console.WriteLine();

                // calling remove book method from library object
                library.removeBook(id);
            }

            // Edit book details interface
            void editBookDetails(Librarian librarian)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Edit Book Details");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter book id to edit details...");
                    Console.WriteLine();

                    // Get book details to edit
                    Console.Write("\tBook Id: ");
                    string id = Console.ReadLine();
                    Console.Write("\tBook Title: ");
                    string title = Console.ReadLine();
                    Console.Write("\tBook ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("\tBook Author: ");
                    string author = Console.ReadLine();
                    Console.Write("\tPublished Year: ");
                    int publishedYear = int.Parse(Console.ReadLine());
                    Console.Write("\tNumber of Book Copies: ");

                    int copies = int.Parse(Console.ReadLine());

                    // Check if the inputs are validated
                    if (id.Trim() != "" && title.Trim() != "" && isbn.Trim() != "" && author.Trim() != "")
                    {
                        // calling edit book details method from library object
                        library.editBookDetails(id, title, isbn, author, publishedYear, copies);
                    }
                    else
                    {
                        // Display error message
                        invalidInputMessage();
                    }
                }
                catch
                {
                    // Display error message
                    Console.WriteLine("Please enter valid information!");
                    continueMessage();
                }
            }

            // Admin's manage members interface
            void ManageMembers(Librarian librarian)
            {
                // Initialize manage member option
                int manageMemberOpt = 0;
                do
                {
                    try
                    {
                        Console.Clear();
                        // Display manage member menu
                        Console.WriteLine("Manage Members...");
                        Console.WriteLine();
                        Console.WriteLine("1. Add Member");
                        Console.WriteLine("2. Remove Member");
                        Console.WriteLine("3. Edit Member Details");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();
                        Console.Write("Select an option: ");
                        manageMemberOpt = int.Parse(Console.ReadLine());
                        // Switch case for user choice
                        switch (manageMemberOpt)
                        {
                            case 1:
                                // Calling add member method
                                addMember(librarian);
                                break;

                            case 2:
                                // Calling remove member method
                                removeMember(librarian);
                                break;

                            case 3:
                                // Calling edit member method
                                editMemberDetails(librarian);
                                break;

                            case 4:
                                Console.WriteLine();
                                // Display exiting message
                                exitingMessage("Returning to main menu");
                                break;

                            default:
                                // Display error message
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        // Display error message
                        invalidInputMessage();
                    }

                } while (manageMemberOpt != 4);

            }

            // Add member interface
            void addMember(Librarian librarian)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Add Member to Library");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\tMember Id: ");
                    string id = Console.ReadLine();

                    Console.Write("\tUser Name: ");
                    string username = Console.ReadLine();

                    Console.Write("\tPassword: ");
                    string password = Console.ReadLine();

                    Console.Write("\tFirst Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("\tLast Name: ");
                    string lastName = Console.ReadLine();

                    // calling add new member method from library object
                    librarian.addNewMember(id, username, password, firstName, lastName);
                }
                catch
                {
                    // Display error message
                    invalidInputMessage();
                }
            }

            // Remove member interface
            void removeMember(Librarian librarian)
            {
                Console.Clear();
                Console.WriteLine("Remove Member from Library");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tEnter Member Id: ");
                string id = Console.ReadLine();
                Console.WriteLine();

                // calling remove member method from library object
                librarian.deleteMemberDetail(id);
            }

            // Edit member details interface
            void editMemberDetails(Librarian librarian)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Edit Member Details");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter member id to edit details...");
                    Console.WriteLine();

                    // Get member details to edit
                    Console.Write("\tMember Id: ");
                    string id = Console.ReadLine();
                    Console.Write("\tFirst Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("\tLast Name: ");
                    string lastName = Console.ReadLine();

                    // Check if the inputs are validated
                    if (id.Trim() != "" && firstName.Trim() != "" && lastName.Trim() != "")
                    {
                        // calling edit member details method from library object
                        librarian.editMemberDetail(id, firstName, lastName);
                    }
                    else
                    {
                        // Display error message
                        invalidInputMessage();
                    }
                }
                catch
                {
                    // Display error message
                    Console.WriteLine("Please enter valid information!");
                    continueMessage();
                }
            }

            // Borrow Book interface
            void issueBook(Member member)
            {
                Console.WriteLine();
                Console.WriteLine("Borrow Books");
                Console.WriteLine();
                Console.Write("\tEnter Book ISBN: ");

                string bookISBN = Console.ReadLine();
                if (bookISBN.Replace(" ", "").Trim() != "")
                {
                    // calling borrow book method from library object
                    member.borrowBook(bookISBN);
                }
                else
                {
                    // Display error message
                    Console.WriteLine();
                    invalidInputMessage();
                }
            }

            void issueBookByLibrarian
                (Librarian librarian)
            {
                Console.WriteLine();
                Console.WriteLine("Borrow Books");
                Console.WriteLine();
                Console.Write("\tEnter Book ISBN: ");
                string bookISBN = Console.ReadLine();
                Console.Write("\tEnter Member ID: ");
                string memberID = Console.ReadLine();

                if (bookISBN.Replace(" ", "").Trim() != "")
                {
                    librarian.borrowBook(bookISBN, memberID);
                }
                else
                {
                    Console.WriteLine();
                    invalidInputMessage();
                }
            }

            // Return book interface
            void returnBook(Member member)
            {
                Console.WriteLine();
                Console.WriteLine("Return Books");
                Console.WriteLine();
                Console.Write("\tEnter Book ISBN: ");
                string bookISBN = Console.ReadLine();
                if (bookISBN.Replace(" ", "").Trim() != "")
                {
                    member.returnBook(bookISBN);
                }
                else
                {
                    Console.WriteLine();
                    invalidInputMessage();
                    continueMessage();
                }
            }

            void returnBookByLibrarian(Librarian librarian)
            {
                Console.WriteLine();
                Console.WriteLine("Return Books");
                Console.WriteLine();
                Console.Write("\tEnter Book ISBN: ");
                string bookISBN = Console.ReadLine();
                Console.Write("\tEnter Member ID: ");
                string memberID = Console.ReadLine();

                if (bookISBN.Replace(" ", "").Trim() != "")
                {
                    librarian.returnBook(bookISBN, memberID);
                }
                else
                {
                    Console.WriteLine();
                    invalidInputMessage();
                }
            }

            // Member's borrowed books display
            void showBorrowedBooks(Member member)
            {
                List<Book> books = member.showBorrowedBooks();
                Console.WriteLine();
                Console.WriteLine("Borrowed Books");

                foreach (Book book in books)
                {
                    displayBookDetails(book);
                }
                Console.WriteLine();
                continueMessage();
            }
        }

        // Search book catalog using given criteria
        static void searchBooksBy(Library library, BooksBy searchBy, string keyword)
        {
            // Get all the books in library
            List<Book> books = library.getAllBooks();

            // Typecast enum to an int
            int searchByEnum = (int)searchBy;
            Book result;

            switch (searchByEnum)
            {
                case 0:
                    // Get book result filtering by title

                    result = books.Find(b => b.Title.Replace(" ", "").ToLower() == keyword.Replace(" ", "").ToLower());

                    // Output result if book is found
                    if (result != null)
                    {
                        displayBookDetails(result);
                        continueMessage();
                    }
                    // Output result if book is not found
                    else
                    {
                        Console.WriteLine("Book not found :(");
                        continueMessage();
                    }
                    break;

                case 1:
                    // Get book result filtering by ISBN
                    result = books.Find(b => b.ISBN.Replace(" ", "").ToLower() == keyword.Replace(" ", "").ToLower());

                    // Output result if book is found
                    if (result != null)
                    {
                        displayBookDetails(result);
                        continueMessage();
                    }

                    // Output result if book is found
                    else
                    {
                        Console.WriteLine("Book not found :(");
                        continueMessage();
                    }
                    break;
            }
        }

        // Customized exiting message
        static void exitingMessage(string message = "Exiting application", int time = 100)
        {
            Console.CursorVisible = false;
            Console.Write(message);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(time);
                Console.Write(".");
            }
            Console.Clear();
        }

        // Customized error message to display
        static void invalidInputMessage()
        {
            Console.WriteLine("Invalid Input! Please enter the option number");
            continueMessage();
            Console.Clear();
        }

        // Customized Book details output
        static void displayBookDetails(Book book)
        {
            Console.WriteLine($"Id: {book.Id}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"ISBN: {book.ISBN}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Published Year: {book.PublishhedYear}");
            Console.WriteLine($"Availability: {(book.Availability ? "Available" : "Unavailable")}");
            Console.WriteLine();
        }

        // Customized continue message
        static void continueMessage()
        {
            Console.Write("Press any key to continue....");
            Console.ReadKey();
        }
    }

    public enum BooksBy
    {
        Title,
        ISBN
    }
}