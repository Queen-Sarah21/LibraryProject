# Library Management System
# Overview
This is a C# library management system that allows users to manage employees, clients, and books. It provides functionalities to add, return, update, and search for employees, clients, and books. In this library, there is just one unique employee with an id and password created by default. 10 books are also created by default. 
# Main Menu
Employee Menu, Client Menu and Exit. You can access each of the menus as well as exit them.
- DEFAULT TEST: This is the first function in the main menu to ensure that the employee id and password is created by default as well as 10 books. Then the program now moves to the main menu.

# EMPLOYEE MENU
As shown in the program, there are 10 available functionalities/menus of the employeee's menu
- Before the user can access the employee's menu, he/she needs to sign in with the unique id and password created by default. A condition is created in the employee menu to access all its options as far as the employee is signed in.

- CREATE CLIENT: A client ought to be created and the length of the client's id and password must be respected.

- DISPLAY CLIENT SORTED BY ID: If two or more clients are created, the program sorts the clients by their id before diplaying them in ascending order. Nevertheless if just one client is created the program still displays the one client created. But if no client is created, the program does not display anything.

- CREATE BOOK: There is room for more books to be created as far as not upto 100 books are created. And the program does not allow the user to enter id of existing books which were already created by default.

- DISPLAY CLIENT SORTED BY ID: If ten books were created and more books were created, the program sorts the books by their id before diplaying them in ascending order. But if no additional book is created, the program displays only the ten books created.

- RENT A BOOK BY ID: To rent a book, the client has to be identified with an existing id if not end the program and creates a client. In the case where a client is actually created and the user enters a wrong id, the program ask the user to re-enter the right id. The user can now move on to entering the id of the book he/ she wants to rent. If the book does not exist, the user has a chance to try again ensuring the book exists. And if the book is already rented, the program goes back to employee menu. The program now allows the user to enter the book which can be rented and tells the user the rental fee then stores the rented book.

- RETURN A BOOK: To return a book, the user enters the client id and now move to the id of the book to be returned. If the book was not rented, the program ask the user to enter the correct id of the book rented. Then the program ask the user to enter the number of days the client rented the book and now calculates the final rental fee of the book by multiplying the rental fee by the number of days the books was rented.

- SELL A BOOK: To sell a book, the client has to be identified with an existing id if not end the program and creates a client. In the case where a client is actually created and the user enters a wrong id, the program ask the user to re-enter the right id. The user can now move on to entering the id of the book he/ she wants to buy. If the book does not exist, the user has a chance to try again ensuring the book exists. And if the book cannot be sold, the program goes back to employee menu. The program now allows the user to enter the book which can be sold and ask the user the quantity of books the client wants to purchase. If the books are less than or more than the quantity of books available for that particular book, the program tells the user the available quantity and allows the user to try again. The program now tells the user the unit price for sale then stores the sold book.

- DISPLAY BOOKS RENTED: Inorder to display rented books, the program calls forth the books rented and stored in the array of rented books of the struct Book then displays each of their information according to the properties of the books rented.

- DISPLAY BOOKS SOLD: Inorder to display sold books, the program calls forth the books sold and stored in the array of sold books of the struct Book then displays each of their information according to the properties of the books rented.

- SIGN OUT: Here, the condition of the employee signed in is false so the program directly signs out and the program moves to the main menu.

# CLIENT MENU
As shown in the program, there are 3 available functionalities/menus of the client's menu. But there is an exceptional 1menu making it 4.
- Before the user can access the client menu, he/she needs to first enter the id of an existing client which was created in the employee menu. If no client was created there is room for the user to go back to the main menu and access the employee menu to create a client. A condition is created in the client menu to access all its options as far as the client is signed in.

- DISPLAY BOOKS CLIENT RENTED: Inorder to display rented books, the program calls forth the books rented and stored in the array of rented books of the struct Book then displays each of their information according to the properties of the books rented.

- DISPLAY BOOKS CLIENT SOLD: Inorder to display sold books, the program calls forth the books sold and stored in the array of sold books of the struct Book then displays each of their information according to the properties of the books rented.

- SIGN OUT: Here, the condition of the client signed in is false so the program directly signs out and the program moves to the main menu.

# EXIT
- Here the program asks the user to be sure of exiting and if the user says yes, the program closes telling the user "bye".

# OTHER FUNCTIONS

Here we find validations for integers, doubles, and strings. These validations are the backbone of the program to identify any invalid value inputed.

# BONUS
- RENT A BOOK BY NAME OR AUTHOR: To rent a book, the client has to be identified with an id if not end the program and creates a client. In the case where a client is actually created and the user enters a wrong id, the program ask the user to re-enter the right id. The user can now move on to entering the name or author of the book he/ she wants to rent. If the book does not exist, the user has a chance to try again ensuring the book exists. And if the book is already rented, the program goes tells the user the books is rented and allows the user to try another name or author. The program now allows the user to enter the book which can be rented and tells the user the rental fee then stores the rented book

- Display the name of the employee and the name of the client after signing in.

- TIME AND DATE: Displaying the exact time and date of the day.

- Display the total of sales and the total earned by rent books. This causes the client menu to have 4 menus. The program does not actually calculates the total sales. It returns "$0" 

The functionalities of the program was done evenly by Ingride and Anumu as indicated in the program. For the other functionalities and variables created without no indication, we created them together.
# Documented by ANUMU and INGRIDE.
 