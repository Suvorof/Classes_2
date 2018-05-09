using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Book
    {
        Title title;
        Author author;
        Subject subject;

        public Book(Title title, Author author, Subject subject)
        {
            this.title = title;
            this.author = author;
            this.subject = subject;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.subject.Show();
        }
    }
}
