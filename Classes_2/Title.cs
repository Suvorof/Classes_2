using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Title
    {
        string content;
        public string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Название книги отсутствует.";
            }

            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
