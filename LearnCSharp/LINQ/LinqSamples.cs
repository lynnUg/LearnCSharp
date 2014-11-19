using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearnCSharp
{
    class LinqSamples
    {
        public void FirstSample()
        {
            XElement books = XElement.Parse(
             @"<books>
            <book>
            <title>Pro LINQ: Language Integrated Query in C#2010</title>
            <author>Joe Rattz</author>
            </book>
            <book>
            <title>Pro .NET 4.0 Parallel Programming in C#</title>
            <author>Adam Freeman</author>
            </book>
            <book>
            <title>Pro VB 2010 and the .NET 4.0 Platform</title>
            <author>Andrew Troelsen</author>
            </book>
            </books>");

           
            var titles =
            from book in books.Elements("book")
            where (string)book.Element("author") == "Joe Rattz"
            select book.Element("title");
           
            foreach (var title in titles)
            {
                Console.WriteLine(title.Value);
            }
            Console.ReadKey();
                
        }
        public void SecondSample()
        {
            string[] strings = { "one", "two", null, "three" };
            
            IEnumerable<string> ieStrings = strings.Where(s => s!=null? s.Length == 3: false);
            
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }
            Console.ReadKey();
        }
        public void thirdSample()
        {
            List<string> strings = new List<string>();
            strings.Add("one");
            strings.Add("two");
            strings.Add("three");

            IEnumerable<string> ieStrings = strings.Where(s => s.Length == 3);
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }

            Console.ReadKey();
            strings.Add("six");
            Console.WriteLine("source enumerable changed but query is not invoked again");
            //query is not invoked explicitly, ieStrings is not changes 
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }
          
            Console.ReadKey();
        }
    }
}
