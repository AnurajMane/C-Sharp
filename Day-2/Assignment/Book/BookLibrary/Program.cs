using System.Xml.Linq;

namespace BookLibrary

{
    public class Entry
    {
        private BookService bookService = new BookService();

        public static void Main(String[] args)
        {
            Entry entry = new Entry();

            int choice;

            do
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Get All Books");
                Console.WriteLine("3. View Book by ID");
                Console.WriteLine("0. Exit");


                choice = Convert.ToInt32(Console.ReadLine());

                entry.actsOnChoice(choice);
            } while (choice != 0);
        }

        private void actsOnChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine(",To add Book, give some Informaiton--");
                        Console.WriteLine("Book Title : ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Book Author : ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Published Year : ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Book book = new(title, author, year);

                        

                        if (bookService.addBook(book))
                        {
                            Console.WriteLine("Book Added SuccessFully...........!!");
                        }
                        else
                        {
                            Console.WriteLine("Something Went Wrong........!!\nTry Again Later.......!!");
                        }
                        Console.WriteLine("**********************************************************************************");

                    }
                    break;



                case 2:
                    {
                        Console.WriteLine("All Books from Library ----");
                        List<Book> books = bookService.getAllBooks();

                        foreach(Book book in books)
                        {
                            Console.WriteLine(book.toString());
                            Console.WriteLine("---------------------------------------------");
                        }
                        Console.WriteLine("**********************************************************************************");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter Id to see Book : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Book book = bookService.getBookById(id);

                        if (book == null)
                        {
                            Console.WriteLine("No Book is Registered with Id " + id);
                        }
                        else
                        {
                            Console.WriteLine("Details if Book with Id " + id);
                            Console.WriteLine(book.toString());
                        }
                        Console.WriteLine("**********************************************************************************");
                    }
                    break;
                case 0:
                    {
                        Console.WriteLine("Thank you for using platform......\nSee you again.........!!!!");
                    }
                    break;

                default: Console.WriteLine("You have Entered wrong choice.......Try again and put a choice--"); break;
            }
        }
    }
}