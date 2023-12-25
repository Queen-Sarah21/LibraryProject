namespace Library_Anumu_Ingride
{
    public class MyLibrary
    {
        #region VARIABLES
        public static int option = 0;
        static bool isSignedInAsEmployee = false;
        static bool isSignedInAsClient = false;
        static bool isClientIdToRent = false;
        public static int mainOption = 0;
        public static int employeeOption = 0;
        public static int indexClients = 0;
        public static int indexBooks = 0;
        public static int indexBooksRent = 0;
        public static int indexBooksSell = 0;
        public static int indexTotalSales = 0;
        public static Employee login = new Employee(111111, "tester", "Anumu Ingride");
        public static Client[] clients = new Client[NUM_CLIENTS];  
        public static Book[] books = new Book[100];
        public static Book[] booksRented = new Book[books.Length];
        public static Book[] booksReturned = new Book[books.Length];
        public static Book[] booksSold = new Book[books.Length];
        public static double [] clientsTotalSales = new double [20];
        #endregion
        #region CONSTANTS
        public const int NUM_CLIENTS = 20;
        #endregion

        #region STRUCTS
        public struct Employee
        {
            public int Id;
            public string Password;
            public string Name;

            public Employee(int id, string password, string name)
            {
                Id = id;
                Password = password;
                Name = name;
            }
        }
        public struct Client
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string Password;
            public Client(int id, string firstName, string lastName, string password)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Password = password;
            }
        }
        public struct Book
        {
            public int Id;
            public string Name;
            public string Author;
            public int YearOfPublication;
            public double RentalFee;
            public bool IsRented;
            public bool CanBeSold;
            public double UnitPriceForSale;
            public int Quantity;

            public Book(int id, string name, string author, int yearOfPublication, double rentalFee,
                bool isRented, bool canBeSold, double unitPriceForSale, int quantity)
            {
                Id = id;
                Name = name;
                Author = author;
                YearOfPublication = yearOfPublication;
                RentalFee = rentalFee;
                IsRented = isRented;
                CanBeSold = canBeSold;
                UnitPriceForSale = unitPriceForSale;
                Quantity = quantity;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            bool booksCreated = DefaultTest();
            //To check if the employee's Id and password were created by default as well as 10 books
            //Done by Anumu
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("----------------------------");
                //Displaying the various menus of this program
                //Done by Ingride
                switch (option)
                {
                    case 1:
                        SignInAsEmployee(); 
                        //Before you can access the employee's menu, you must sign in
                        //Done by Anumu
                        while (isSignedInAsEmployee) //boolean to confirm that the employee is signed in
                        {
                            DisplayEmployeeMenu();
                            switch (option)
                            {
                                case 1:
                                    CreateClient();
                                    //Done by Ingride
                                    break;

                                case 2:
                                    SortClientById();
                                    //Done by Anumu
                                    break;

                                case 3:
                                    CreateBook();
                                    //Done by Ingride
                                    break;

                                case 4:
                                    SortBoookById();
                                    //Done by Anumu
                                    break;

                                case 5:
                                    RentBook();
                                    //Done by Anumu
                                    break;

                                case 6:
                                    ReturnBook();
                                    //Done by Anumu
                                    break;

                                case 7:
                                    SellBook();
                                    //Done by Ingride
                                    break;

                                case 8:
                                    DisplayBooksRented();
                                    //Done by Anumu
                                    break;

                                case 9:
                                    DisplayBooksSold();
                                    //Done by Ingride
                                    break;

                                case 10:
                                    isSignedInAsEmployee = false; //The program goes back to main menu when isSignedInAsEmployee = false
                                    //Done by Ingride
                                    break;
                               
                                default:
                                    Console.WriteLine("Wrong option. Please try again");
                                    //Done by Ingride
                                    break;
                            }
                        }
                        break;

                    case 2:
                       EnterClientIdToRent();
                        //Before you can access the client's menu, you must sign in with the existing client's Id
                        //Done by Anumu
                        while (isSignedInAsClient) //boolean to confirm that the client is signed in
                       {
                            DisplayClientMenu();
                            //Done by Ingride
                            switch (option)
                            {
                                case 1:
                                    DisplayBooksClientRented();
                                    //Done by Anumu
                                    break;

                                case 2:
                                    DisplayBooksClientPurchased();
                                    //Done by Anumu
                                    break;

                                case 3:
                                    isSignedInAsClient = false; //The program goes back to main menu when isSignedInAsClient = false
                                    //Done by Ingride
                                    break;
                                case 4:
                                    Console.WriteLine("Display Total Sale"); //BONUS
                                    DisplayTotalSales();
                                    //Done by Anumu
                                    break;
                                default:
                                    Console.WriteLine("Wrong option. Please try again");
                                    //Done by Ingride
                                    break;
                            }
                       }
                        break;

                    case 3:
                        Exit();
                        //Done by Anumu
                        break;
                }
            }
        }

       
    public static bool DefaultTest()
        {
            Console.WriteLine("Check if the employee and 10 books created as default.");
            // Test if the default employee was created correctly
            if (login.Id != 111111 && login.Password != "tester")
            {
                Console.WriteLine("Error creating default employee.");
            }
            books[0] = new Book(100001, "Man's search for meaning", "Victor Frankl", 1946, 10.0, true, false, 25.0, 1);
            books[1] = new Book(100002, "Maus II", "Art Spiegelman", 1970, 9.0, false, true, 22.95, 10);
            books[2] = new Book(100003, "Charlie and the chocolate factory", "Roald Dahl", 1964, 30.0, false, false, 32.0, 1);
            books[3] = new Book(100004, "The Lottery", "Shirley Jackson", 1996, 12.0, true, true, 21.0, 5);
            books[4] = new Book(100005, "Cat Person", "Kristen Roupenian", 2017, 11.0, false, true, 22.0, 1);
            books[5] = new Book(100006, "A Good Man Is Hard To Find", "Flannery O'Connor", 1953, 13.0, false, false, 24.0, 1);
            books[6] = new Book(100007, "Everything's Eventual", "Stephen King", 1986, 14.0, false, true, 26.0, 6);
            books[7] = new Book(100008, "Drifting House", "Krys Lee", 2012, 15.0, true, true, 27.0, 1);
            books[8] = new Book(100009, "Fragile Things", "Neil Gaiman", 2006, 19.0, false, true, 32.0, 2);
            books[9] = new Book(100010, "Black Panther 2", "Ryan Coogler", 2022, 20.0, true, true, 40.0, 1);
            // Test if the default books were created correctly
            // Define a variable to count the number of books created
            bool booksCreated = false;
            // Loop through the array of books to check if any book has been created
            for (int i = 0; i < 100; i++)
            {
                // If the book has been created, increase the booksCreated counter
                if (books[i].Id != 0)
                {
                    booksCreated = true;
                    break;
                }
            }
            // Validate if 10 books were created
            if (booksCreated != true)
            {
                Console.WriteLine("An error occurred. Please check the default book creation process.");
            }
            Console.WriteLine("You can now move to the main menu");
            return booksCreated;
        }
        static int DisplayMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("MY LIBRARY");
            Console.WriteLine("1) EMPLOYEE MENU: Executing Employee's Functionalities.");
            Console.WriteLine("2) CLIENT MENU: Executing Client's functionalities");
            Console.WriteLine("3) EXIT");
            Console.WriteLine("Please choose the menu you want to use: ");          
            option = ReadInteger(1, 3);
            return option;
        }
        private static void DisplayEmployeeMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("EMPLOYEE MENU");
            CurrentDateAndTime();
            Console.WriteLine("1) Create a client");
            Console.WriteLine("2) Display all the clients sorted by ID");
            Console.WriteLine("3) Create a book");
            Console.WriteLine("4) Display all the books sorted by ID");
            Console.WriteLine("5) Rent a book");
            Console.WriteLine("6) Return a book");
            Console.WriteLine("7) Sell a book");
            Console.WriteLine("8) Display all the books rented");
            Console.WriteLine("9) Display all the books sold");
            Console.WriteLine("10) Sign Out: to return to the main menu");
            Console.Write("Please choose the employee's menu you want to use: ");
            option = ReadInteger(1, 10);
            Console.WriteLine("----------------------------");
        }
        private static void DisplayClientMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("CLIENT MENU");
            CurrentDateAndTime();
            Console.WriteLine("1) Display the books I have rented");
            Console.WriteLine("2) Display the books I have purchased");
            Console.WriteLine("3) Sign Out: to return to the main menu");
            Console.WriteLine("4) Display Total Sale");
            Console.Write("Please choose the client menu you want to use: ");
            option = ReadInteger(1, 4);
            Console.WriteLine("----------------------------");
        }
        private static void SignInAsEmployee()
        {
            Console.WriteLine("SIGN IN");
            Console.WriteLine("Please enter employee Id: ");
            int employeeID = ReadInteger();
            while (employeeID != login.Id)
            {
                Console.WriteLine("Enter the employee's Id created by default: ");
                employeeID = ReadInteger();
            }
            Console.WriteLine("Please enter employee password: ");
            string employeePass = ReadString();
            while (employeePass != login.Password)
            {
                Console.WriteLine("Enter the employee's password created by default:");
                employeePass = ReadString();
            }
            // Display the name of the employee and the name of the client after signing in (5 points)
            Console.WriteLine($"Welcome {login.Name} you have signed in successfully.");
            isSignedInAsEmployee = true;
        }
        private static void CreateClient()
        {
            Console.WriteLine("Create a client");
            Console.WriteLine("ENTER ONE CLIENT");

            if (indexClients <= clients.Length)
            {
                Console.Write("Enter Client ID: ");
                int clientId = ReadInteger(100000, 999999);

                Console.Write("Enter Client First Name: ");
                string firstName = ReadString();
                Console.Write("Enter Client Last Name: ");
                string lastName = ReadString();
                Console.Write("Enter Client Password: ");
                string password = ReadString(6, 10);
                Client client = new Client(clientId, firstName, lastName, password);
                clients[indexClients] = client;
                //client created is saved in the array
                indexClients++;
                Console.WriteLine("Client created successfully");
                isSignedInAsClient = true;
            }
            else
            {
                Console.WriteLine("You have reached the maximum of clients");
            }
        }
        private static void SortClientById()
        {
            Console.WriteLine("Display all the clients sorted by ID");
            // Sort clients by their id
            var sortedClients = clients.OrderBy(c => c.Id);
            // Display the sorted clients
            for (int i = 0; i < sortedClients.Count(); i++)
            {
                if (sortedClients.ElementAt(i).Id != 0) // Only display the clients that were inputted
                {
                    Console.WriteLine($"ID: {sortedClients.ElementAt(i).Id}, First Name: {sortedClients.ElementAt(i).FirstName}, Last Name: {sortedClients.ElementAt(i).LastName}, Password: {sortedClients.ElementAt(i).Password}");
                }
                else if(sortedClients.ElementAt(i).Id < 0)
                {
                    Console.WriteLine("No clients are created, please create some to sort. ");
                    break;
                }
            }
        }
        private static void CreateBook()
        {
            Console.WriteLine("Create a book");
            Console.WriteLine("ENTER ONE BOOK");
            if (indexBooks > 9 || indexBooks <= books.Length)
            {
                Console.Write("Enter Book ID: ");
                int id = ReadInteger(100010, 999999);
                Console.Write("Enter Book Name: ");
                string name = ReadString();
                Console.Write("Enter Book Author: ");
                string author = ReadString();
                Console.Write("Enter Book Year of Publication: ");
                int year = ReadInteger();
                Console.Write("Enter Book Rental Fee: ");
                double rentalFee = ReadInteger();
                Console.Write("Is the book rented already?: ");
                bool IsRented = ReadBoolean();
                Console.Write("Can the book be sold?: ");
                bool CanBeSold = ReadBoolean();
                Console.Write("Enter Unit Price for Sale: ");
                double UnitPriceForSale = ReadDouble();
                Console.Write("Enter quantity of books available: ");
                int quantity = ReadInteger();
                Book book = new Book(id, name, author, year, rentalFee, IsRented, CanBeSold, UnitPriceForSale, quantity);
                books[indexBooks] = book;
                //book created is saved in the array
                indexBooks++;
                Console.WriteLine("Book created successfully");
            }
            else
            {
                Console.WriteLine("You have reached the maximum of books");
            }
        }
        private static void SortBoookById()
        {
            Console.WriteLine("Display all the books sorted by ID");
            // Sort books by their id
            var sortedBooks = books.OrderBy(b => b.Id);
            // Display the sorted clients
            for (int i = 0; i < sortedBooks.Count(); i++)
            {
                if (sortedBooks.ElementAt(i).Id != 0) // Only display the clients that were inputted
                {
                    Console.WriteLine($"ID: {sortedBooks.ElementAt(i).Id}, Name: {sortedBooks.ElementAt(i).Name}, Author: {sortedBooks.ElementAt(i).Author}," +
                    $" Year: {sortedBooks.ElementAt(i).YearOfPublication}, Is Rented?: {sortedBooks.ElementAt(i).IsRented}, Rental Fee: {sortedBooks.ElementAt(i).RentalFee}," +
                    $" Can Be Sold?: {sortedBooks.ElementAt(i).CanBeSold}, + Unit Price: {sortedBooks.ElementAt(i).UnitPriceForSale}, Quantity: {sortedBooks.ElementAt(i).Quantity}");
                }
            }
        }
        private static void EnterClientIdToRent()
        {
            Console.Write("Enter Client ID: ");
            int clientIdToRent = ReadInteger(100000, 999999);
            bool clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
            while (clientExists == false)
            {
                Console.WriteLine("Client doesn't exist try again(1) or create client if not created(2): ");
                int clientIdOption = ReadInteger();
                if (clientIdOption == 1)
                {
                    clientIdToRent = ReadInteger(100000, 999999);
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
                }
    
                else if (clientIdOption == 2)
                {
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
                    DisplayMenu();
                }
                    break;
            }
                    isClientIdToRent = true;
        }
        private static void RentBook()
        {
            Console.WriteLine("Rent a book");
            Console.WriteLine("Please press 1 to login first:");
            int rentLogin = ReadInteger();
            if (rentLogin == 1)
            {
                EnterClientIdToRent();
                Console.WriteLine("Do you want to rent the book by check the ID(1), NAME(2) or AUTHOR(3)?"); //The employee can find a book by Id, name or author to rent it(15 bonus pts) 
                int rentType = ReadInteger();
                if (rentType == 1)
                {
                    Console.WriteLine("Enter the id of the book you want to rent: ");
                    int bookIdToRent = ReadInteger(100000, 999999);
                    bool bookExist = Array.Exists(books, (book) => book.Id == bookIdToRent);
                    while (bookExist == false)
                    {
                        Console.WriteLine("Enter an existing book id");
                        bookIdToRent = ReadInteger(100000, 999999);
                        bookExist = Array.Exists(books, (book) => book.Id == bookIdToRent);
                    }
                    Book bookRent = Array.Find(books, (book) => book.Id == bookIdToRent);
                    if (bookRent.IsRented == true)
                    {
                        Console.WriteLine("Sorry, you cannot rent the book. Display all books available in employee menu see which of them can be rented then try again");
                    }
                        //to automatically indicate the book can not more be rented
                    else if (bookRent.IsRented == false)
                    {
                        Console.WriteLine($"You can rent the book and the rental fee is ${bookRent.RentalFee}.");
                        //Book[] booksRented = new Book[books.Length];
                        Book booksRent = new Book(bookRent.Id, bookRent.Name, bookRent.Author, bookRent.YearOfPublication, bookRent.RentalFee,
                        bookRent.IsRented, bookRent.CanBeSold, bookRent.UnitPriceForSale, bookRent.Quantity);
                        bookRent.IsRented = true;
                        booksRented[indexBooksRent] = booksRent;
                        //book rented created is saved in the array
                        indexBooksRent++;   
                    }
                }
                else if (rentType == 2) //BONUS
                {
                    Console.WriteLine("Enter the name of the book you want to rent: ");
                    string bookNameToRent = ReadString();
                    bool bookExist = Array.Exists(books, (book) => book.Name == bookNameToRent);
                    while (bookExist == false)
                    {
                        Console.WriteLine("Enter an existing book name:");
                        bookNameToRent = ReadString();
                        bookExist = Array.Exists(books, (book) => book.Name == bookNameToRent);
                    }
                    Book bookRent = Array.Find(books, (book) => book.Name == bookNameToRent);
                    while (bookNameToRent == bookRent.Name && bookRent.IsRented == true)
                    {
                        Console.WriteLine("Sorry this book can't be rented, try another:");
                        bookNameToRent = ReadString();
                        bookRent = Array.Find(books, (book) => book.Name == bookNameToRent);
                    }
                    Console.WriteLine($"You can rent the book ant the rental fee is ${bookRent.RentalFee}.");

                    Book booksRent = new Book(bookRent.Id, bookRent.Name, bookRent.Author, bookRent.YearOfPublication, bookRent.RentalFee,
                    bookRent.IsRented, bookRent.CanBeSold, bookRent.UnitPriceForSale, bookRent.Quantity);
                    bookRent.IsRented = true;
                    booksRented[indexBooksRent] = booksRent;
                    indexBooksRent++;
                }
                else if (rentType == 3) //BONUS
                {
                    Console.WriteLine("Enter the author of the book you want to rent: ");
                    string bookAuthorToRent = ReadString();
                    bool bookExist = Array.Exists(books, (book) => book.Author == bookAuthorToRent);
                    while (bookExist == false)
                    {
                        Console.WriteLine("Enter an existing author of the book ");
                        bookAuthorToRent = ReadString();
                        bookExist = Array.Exists(books, (book) => book.Author == bookAuthorToRent);
                    }
                    Book bookRent = Array.Find(books, (book) => book.Author == bookAuthorToRent);
                    while (bookAuthorToRent == bookRent.Author && bookRent.IsRented == true)
                    {
                        Console.WriteLine("Sorry this book can't be rented, try another:");
                        bookAuthorToRent = ReadString();
                        bookRent = Array.Find(books, (book) => book.Name == bookAuthorToRent);
                    }
                    Console.WriteLine($"You can rent the book and the rental fee is ${bookRent.RentalFee}.");

                    Book booksRent = new Book(bookRent.Id, bookRent.Name, bookRent.Author, bookRent.YearOfPublication, bookRent.RentalFee,
                    bookRent.IsRented, bookRent.CanBeSold, bookRent.UnitPriceForSale, bookRent.Quantity);
                    bookRent.IsRented = true;
                    booksRented[indexBooksRent] = booksRent;
                    indexBooksRent++;
                }
            }
        }
        private static void EnterClientIdToReturn()
        {
            Console.Write("Enter Client ID: ");
            int clientIdToReturn = ReadInteger(100000, 999999);
            bool clientExists = Array.Exists(clients, client => client.Id == clientIdToReturn);
            while (clientExists == false || isClientIdToRent == false)
            {
                Console.WriteLine("Client doesn't exist or client has not rented a book try again(1) or create client if not created(2): ");
                int clientIdOption = ReadInteger();
                if (clientIdOption == 1)
                {
                    clientIdToReturn = ReadInteger(100000, 999999);
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToReturn);
                }

                else if (clientIdOption == 2)
                {
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToReturn);
                    DisplayMenu();
                }
                break;
            }
        }
        private static void ReturnBook()
        {
            Console.WriteLine("Return a book");
            Console.WriteLine("Please press 1 to login first:");
            int returnLogin = ReadInteger();
            if (returnLogin == 1)
            {
                EnterClientIdToReturn();
                Console.WriteLine("Please enter the id of the book you want to return");
                int bookIdToReturn = ReadInteger(100000, 999999);
                bool bookExistToReturn = Array.Exists(booksRented, (bookRent) => bookRent.Id == bookIdToReturn);
                while (bookExistToReturn == false)
                {
                    Console.WriteLine("Enter the correct id of the rented book you want to return");
                    bookIdToReturn = ReadInteger(100000, 999999);
                    bookExistToReturn = Array.Exists(booksRented, (bookRent) => bookRent.Id == bookIdToReturn);

                }
                Book bookReturn = Array.Find(booksRented, (bookRent) => bookRent.Id == bookIdToReturn);
                if (bookReturn.IsRented == true)
                {
                    Console.WriteLine("Sorry, you can't return this book.");
                }
                else if (bookReturn.IsRented == false)
                {
                    Console.Write($"How many days was the book rented?: ");
                    int numDaysRented = ReadInteger();
                    Console.WriteLine($"Your total rental fee is ${numDaysRented * bookReturn.RentalFee}");
                    Console.WriteLine("You can return the book");
                }
                Book booksReturn = new Book(bookReturn.Id, bookReturn.Name, bookReturn.Author, bookReturn.YearOfPublication, bookReturn.RentalFee,
                bookReturn.IsRented, bookReturn.CanBeSold, bookReturn.UnitPriceForSale, bookReturn.Quantity);
                bookReturn.IsRented = false;
                booksReturned[indexBooksRent] = booksReturn;
                //book returned created is saved in the array
                indexBooksRent++;
            }
        }
        private static void EnterClientIdToSell()
        {
            Console.Write("Enter Client ID: ");
            int clientIdToRent = ReadInteger(100000, 999999);
            bool clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
            while (clientExists == false)
            {
                Console.WriteLine("Client doesn't exist try again(1) or create client if not created(2): ");
                int clientIdOption = ReadInteger();
                if (clientIdOption == 1)
                {
                    clientIdToRent = ReadInteger(100000, 999999);
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
                }

                else if (clientIdOption == 2)
                {
                    clientExists = Array.Exists(clients, client => client.Id == clientIdToRent);
                    DisplayMenu();
                }
                break;
            }
            isClientIdToRent = true;
        }
        private static void SellBook()
        {
            Console.WriteLine("Sell a book");
            Console.WriteLine("Please press 1 to login first:");
            int sellLogin = ReadInteger();
            if (sellLogin == 1)
            {
                EnterClientIdToSell();
                Console.WriteLine("Enter the id of the book you want to sell: ");
                int bookIdToSell = ReadInteger(100000, 999999);
                bool bookExist = Array.Exists(books, (book) => book.Id == bookIdToSell);
                while (bookExist == false)
                {
                    Console.WriteLine("Enter the correct book id");
                    bookIdToSell = ReadInteger(100000, 999999);
                    bookExist = Array.Exists(books, (book) => book.Id == bookIdToSell);
                }
                Book bookSell = Array.Find(books, (book) => book.Id == bookIdToSell);
                if (bookSell.CanBeSold == false)
                {
                    Console.WriteLine("Sorry, you cannot sell the book. Display all books available in employee menu see which of them can be sold then try again");
                }
                else if (bookSell.CanBeSold == true)
                {

                Console.Write("Enter the quantity of books you want to sell: ");
                int quantityBooks = ReadInteger();
                while (quantityBooks > bookSell.Quantity) 
                {
                    Console.WriteLine($"Sorry there are just {bookSell.Quantity} available");
                    quantityBooks = ReadInteger();              
                }
                double finalSale = bookSell.UnitPriceForSale * quantityBooks;
                Console.WriteLine($"You can purchase the book and the unit price for sale is ${bookSell.UnitPriceForSale} and your bill is ${finalSale}");
                    
                Book booksSell = new Book(bookSell.Id, bookSell.Name, bookSell.Author, bookSell.YearOfPublication, bookSell.RentalFee,
                bookSell.IsRented, bookSell.CanBeSold, bookSell.UnitPriceForSale, bookSell.Quantity);
                if (bookSell.Quantity < 1)
                {
                    bookSell.CanBeSold = false;
                }
                booksSold[indexBooksSell] = booksSell;
                indexBooksSell++;                  
                    //book sold created is saved in the array
                clientsTotalSales[indexTotalSales] = finalSale;
                indexTotalSales++;
                }
            }
        }
        public static void DisplayTotalSales() //Tried BONUS
        {
            //EnterClientIdToSell();
            double totalSales = 0;
            if (indexBooksSell > 0)
            {
               foreach (double id in clientsTotalSales)
               {
                    totalSales += clientsTotalSales[indexTotalSales];
               }
            Console.WriteLine("Total sales for client ID " + ": $" + totalSales);
            }  
        }
    private static void DisplayBooksRented()
        {
            Console.WriteLine("Display all the books rented");
            if (indexBooksRent > 0)
            {
                for (int i = 0; i < indexBooksRent; i++)
                {
                    Book booksRent = booksRented[i];
                    Console.WriteLine($"Id: {booksRent.Id}\t");
                    Console.WriteLine($"Name: {booksRent.Name}\t");
                    Console.WriteLine($"Author: {booksRent.Author}\t");
                    Console.WriteLine($"Year Of Publication: {booksRent.YearOfPublication}\t");
                    Console.WriteLine($"Rental Fee: {booksRent.RentalFee}\t");
                    Console.WriteLine($"Is book Rented?: {booksRent.IsRented}\t");
                    Console.WriteLine($"Can Book Be Sold?: {booksRent.CanBeSold}\t");
                    Console.WriteLine($"Unit Price For Sale $:{booksRent.UnitPriceForSale}\t");
                    Console.WriteLine($"Quantity: {booksRent.Quantity}\t");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There are no existing books to display!");
            }
        }
        private static void DisplayBooksSold()
        {
            Console.WriteLine("Display all the books sold");
            if (indexBooksSell > 0)
            {
                for (int i = 0; i < indexBooksSell; i++)
                {
                    Book booksSell = booksSold[i];
                    Console.WriteLine($"Id: {booksSell.Id}\t");
                    Console.WriteLine($"Name: {booksSell.Name}\t");
                    Console.WriteLine($"Author: {booksSell.Author}\t");
                    Console.WriteLine($"Year Of Publication: {booksSell.YearOfPublication}\t");
                    Console.WriteLine($"Rental Fee: {booksSell.RentalFee}\t");
                    Console.WriteLine($"Is book Rented?: {booksSell.IsRented}\t");
                    Console.WriteLine($"Can Book Be Sold?: {booksSell.CanBeSold}\t");
                    Console.WriteLine($"Unit Price For Sale $:{booksSell.UnitPriceForSale}\t");
                    Console.WriteLine($"Quantity: {booksSell.Quantity}\t");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("There are no existing books to display!");
            }
        }
        private static void DisplayBooksClientRented()
        {
            Console.WriteLine("Display the books I have rented");
            if (indexBooksRent > 0)
            {
                for (int i = 0; i < indexBooksRent; i++)
                {
                    Book booksClientRent = booksRented[i];
                    Console.WriteLine($"ID: {booksClientRent.Id}, Name: {booksClientRent.Name}, Author: {booksClientRent.Author}," +
                         $" Year: {booksClientRent.YearOfPublication}, Is Rented?: {booksClientRent.IsRented}, rentalFee: {booksClientRent.RentalFee}," +
                         $" Can Be Sold?: {booksClientRent.CanBeSold}, Unit Price: {booksClientRent.UnitPriceForSale}," +
                         $"Unit Price: {booksClientRent.UnitPriceForSale}, Quantity: {booksClientRent.Quantity},");
                }
            }
            else
            {
                Console.WriteLine("No books were rented by this client!");
            }
        }
        private static void DisplayBooksClientPurchased()
        {
            Console.WriteLine("Display the books I have purchased");
            if (indexBooksSell > 0)
            {
                for (int i = 0; i < indexBooksSell; i++)
                {
                    Book booksClientBought = booksSold[i];
                    Console.WriteLine($"ID: {booksClientBought.Id}, Name: {booksClientBought.Name}, Author: {booksClientBought.Author}," +
                         $" Year: {booksClientBought.YearOfPublication}, Is Rented?: {booksClientBought.IsRented}, rentalFee: {booksClientBought.RentalFee}," +
                         $" Can Be Sold?: {booksClientBought.CanBeSold}, Unit Price: {booksClientBought.UnitPriceForSale}," +
                         $"Unit Price: {booksClientBought.UnitPriceForSale}, Quantity: {booksClientBought.Quantity},");
                }
            }
            else
            {
                Console.WriteLine("No books were bought by this client!");
            }
        }
        private static void Exit()
        {
            Console.WriteLine("EXIT APPLICATION");
            Console.WriteLine("Are you sure to exit the application? ");
            if (ReadBoolean())
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
        }
        private static void CurrentDateAndTime() //BONUS
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Display the current date and time
            Console.WriteLine("Current Date and Time: " + currentDateTime.ToString());
        }

        #region OTHER FUNCTIONS
        static string ReadString()
        {
            string toReturn = null;
            while (String.IsNullOrEmpty(toReturn))
            {
                toReturn = Console.ReadLine();
            }

            return toReturn;
        }
        static int ReadInteger()
        {
            int toReturn = 0;
            while (!Int32.TryParse(Console.ReadLine(), out toReturn))
            {
                Console.Write("Invalid integer value, please try again: ");
            }

            return toReturn;
        }
        static int ReadInteger(int min, int max)
        {
            int toReturn = ReadInteger();
            while (!IsWithinRange(toReturn, min, max))
            {
                Console.Write($"The value must be between {min} and {max}. Please try again: ");
                toReturn = ReadInteger();
            }

            return toReturn;
        }
        public static int ReadInteger(int min)
        {
            int toReturn = ReadInteger();
            while (toReturn < min)
            {
                Console.Write($"The value must be greater than or equal to {min}. Please try again: ");
                toReturn = ReadInteger();
            }

            return toReturn;
        }
        static bool IsWithinRange(int num, int min, int max)
        {
            return num >= min && num <= max;
        }
        static double ReadDouble()
        {
            double toReturn = 0;
            while (!Double.TryParse(Console.ReadLine(), out toReturn))
            {
                Console.Write("Invalid real value, please try again: ");
            }

            return toReturn;
        }
        static double ReadDouble(double min, double max)
        {
            double toReturn = ReadDouble();
            while (!IsWithinRange(toReturn, min, max))
            {
                Console.Write($"The value must be between {min} and {max}. Please try again: ");
                toReturn = ReadDouble();
            }

            return toReturn;
        }
        static bool IsWithinRange(double num, double min, double max)
        {
            return num >= min && num <= max;
        }
        static bool ReadBoolean()
        {
            Console.Write("Enter 1 for yes, or 2 for no: ");
            return ReadInteger(1,2) == 1;
        }
        static string ReadString(int min, int max)
        {
            string toReturn = ReadString();
            while (toReturn.Length < min || toReturn.Length > max)
            {
                Console.Write($"The password must be between {min} and {max}. Please try again:");
                toReturn = Console.ReadLine();
            }
            return toReturn;
        }
        #endregion
    }
}