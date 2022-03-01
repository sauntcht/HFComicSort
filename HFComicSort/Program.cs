using System;
using System.Linq;
using System.Collections.Generic;

namespace HFComicSort
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            IEnumerable<Comic> mostExpensive =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby -Comic.Prices[comic.Issue]
                select comic;


            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
            }
            */
            var mostExpensiveComicDescriptions =

                    from comic in Comic.Catalog
                    where Comic.Prices[comic.Issue] > 500
                    orderby Comic.Prices[comic.Issue] descending
                    select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";

            foreach (var comic in mostExpensiveComicDescriptions)
            {
                Console.WriteLine($"{comic}");  
            };
        }

    }
}
