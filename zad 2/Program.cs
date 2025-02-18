namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Silent Harbor", "F. Scott Fitzgerald"),
                new Book("Whispers of Maycomb", "Harper Lee"),
                new Book("Empire's End", "George Orwell"),
                new Book("A Dance of Hearts", "Jane Austen"),
                new Book("Beyond the Pines", "J.D. Salinger"),
                new Book("Legends of Eldenwood", "J.R.R. Tolkien"),
                new Book("The Dragon's Path", "J.R.R. Tolkien")
            };
            SelectionSort(books);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        static void SelectionSort(Book[] books)
        {
            int n = books.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (books[j].Title[0] < books[minIndex].Title[0])
                    {
                        minIndex = j;
                    }
                    if(books[j].Title[0] == books[minIndex].Title[0])
                    {
                        if (books[j].Title[1] < books[minIndex].Title[0])
                        {
                            minIndex = j;
                        }
                    }
                }
                (books[i], books[minIndex]) = (books[minIndex], books[i]);
            }
        }
    }
}
