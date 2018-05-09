using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Program
    {
        static void Main()
        {
            Title title = new Title();
            title.Content = "Библия C#";

            Author author = new Author();
            author.Content = "Михаил Флёнов";

            Subject subject = new Subject();
            subject.Content = "Программирование для .NET на C#...";

            Book book = new Book(title, author, subject);
            book.Show();

            Console.ReadKey();

        }
    }
}
