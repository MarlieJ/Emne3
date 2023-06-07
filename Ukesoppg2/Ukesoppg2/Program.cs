namespace Ukesoppg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A class is a template for what a book (datatype) is. 
            //I've created a class, and defines what the class is (here a book), i defined the class "datatype".
            //Then I'll make an object. An object is an instance of a class. Where I'm creating an actual specific book in my program.
            //string lsldkjlsd = ksdfj;
            //So instead of making a standard variable as over, I'm gonna declare my book-datatype. 
            Book book1 = new Book();//So now we have the actual book, while the class is the specification of what it will look like/contain. It's just the template, not the product.
            //book1 = a variable thats storing a book object.
            //Now we need to assign the book variable it's attributes, fill in the blannks from the template.
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.author);

            //both of these objects is books. They have the same attributes, but I created the different values.
            //If a library has 10 K books, I could make'm all out of the book template.

        }
    }
}