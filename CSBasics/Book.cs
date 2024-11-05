using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSBasics
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public int CurrentPage { get; set; } = 1;
        

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public void TurnPage()
        {
            if (CurrentPage == Pages)
            {
                Console.WriteLine("You've reached the end of the book");
            }
            else
            {
                CurrentPage++;
                Console.WriteLine($"You turned the page! Your current page is {CurrentPage}");
            };
        }
    }
}
