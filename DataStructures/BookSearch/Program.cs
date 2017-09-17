using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSearch {
    class Program {
        static void Main(string[] args) {
            string bookA = System.IO.File.ReadAllText(@"~\..\..\..\BookA.txt");
            string bookB = System.IO.File.ReadAllText(@"~\..\..\..\BookB.txt");

            bookA = BookSearcher.CleanStr(bookA);
            bookB = BookSearcher.CleanStr(bookB);

            var bsr = new BookSearcher(bookA.Split(' '));
            bsr.Find(bookB.Split(' '));

            Console.ReadKey();
        }
    }
}
