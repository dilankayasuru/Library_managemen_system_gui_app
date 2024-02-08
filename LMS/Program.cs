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

                // Get all books from library
                List<Book> books = library.getAllBooks();

                // Get the book by searching title
                Book book = books.Find(b => b.Title == search);

                // Display book information if book is not null (if exists)
                if (book != null)
                {
                    Console.WriteLine();

                    // Display customized book details output 
                    displayBookDetails(book);
                    Console.WriteLine();

                    continueMessage();
                }
                else
                {
                    // Display message if book not found
                    Console.WriteLine("Book not found :(");
                    Console.WriteLine();
                    continueMessage();
                }
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
                Console.WriteLine("\tUser name: ");
                username = Console.ReadLine();

                // Read password input
                Console.WriteLine("\tPassword: ");
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
                        librarianConsoleInterface();
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
                        Console.WriteLine("\t4. Logout");
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
                                Console.WriteLine();
                                break;

                            case 3:
                                Console.WriteLine();
                                break;

                            case 4:
                                // Display exiting message
                                exitingMessage($"Bye! {activeMember.FirstName}\nExiting to main menu");
                                isRunning = false;
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

            // Console for member's operations
            void librarianConsoleInterface()
            {

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
                        List<Book> availableBokos;

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
                                searchBooksBy(library, BooksBy.ISBN, keyword);
                                continueMessage();
                                break;

                            case 2:
                                // Get search keyword
                                Console.Write("Enter Keyword to search: ");
                                keyword = Console.ReadLine();
                                searchBooksBy(library, BooksBy.Title, keyword);
                                continueMessage();
                                break;

                            case 3:
                                availableBokos = library.getAllBooks();
                                foreach (Book book in availableBokos)
                                {
                                    displayBookDetails(book);
                                }
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
            void issueBook()
            {

            }

            // Return book interface
            void returnBook()
            {

            }

            // Member's borrowed books display
            void showBorrowedBooks()
            {

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
                case 1:
                    // Get book result filtering by title
                    result = books.Find(b => b.Title.Trim() == keyword.Trim());

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

                case 2:
                    // Get book result filtering by ISBN
                    result = library.getAllBooks().Find(b => b.ISBN.Trim() == keyword.Trim());

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
            Thread.Sleep(1000);
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
