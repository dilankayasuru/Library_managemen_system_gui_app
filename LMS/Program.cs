using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LMS.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
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
            Library library = new Library();
            int option = 0;
            bool isClosing = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Library Management System");
                    Console.WriteLine();
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
                                searchBooks();
                                break;

                            case 2:
                                issueBook(activeMember);
                                break;

                            case 3:
                                returnBook(activeMember);
                                break;

                            case 4:
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
                        invalidInputMessage();
                        continue;
                    }
                }
                while (isRunning);
            }

            // Console for librarian's operations
            void librarianConsoleInterface(Librarian librarian)
            {
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

                        switch (option)
                        {
                            case 1:
                                viewTransactions();
                                break;

                            case 2:
                                searchBooks();
                                break;

                            case 3:
                                manageBooks();
                                break;

                            case 4:
                                ManageMembers();
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
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        invalidInputMessage();
                        continue;
                    }
                }
                while (isRunning);
            }

            // View transaction interface
            void viewTransactions()
            {

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
                                invalidInputMessage();
                                break;
                        }
                    }
                    catch
                    {
                        invalidInputMessage();
                    }

                } while (option != 4);
            }

            // Admin's manage books interface
            void manageBooks()
            {

            }

            // Admin's manage members interface
            void ManageMembers()
            {

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
                    member.borrowBook(bookISBN);
                }
                else
                {
                    Console.WriteLine();
                    invalidInputMessage();
                    continueMessage();
                }
            }

            void issueBookByLibrarian(Librarian librarian)
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
                    continueMessage();
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
                    continueMessage();
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