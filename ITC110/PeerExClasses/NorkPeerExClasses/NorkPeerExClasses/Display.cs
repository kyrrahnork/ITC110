using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkPeerExClasses
{
    class Display
    {
        public Display()
        {
            dictionary = new TDictionary();
            GetTerms();
            SearchDictionary();
        }


        TDictionary dictionary;



        private void GetTerms()
        {
            string done = "yes";
            while (done == "yes")
            {
                Term t = new Term();
                Console.WriteLine("Add a word.");
                t.Word = Console.ReadLine();
                Console.WriteLine("Add a definition.");
                t.Definition = Console.ReadLine();
                dictionary.AddTerm(t);
                Console.WriteLine("Would you like to add another term? yes or no.");
                done = Console.ReadLine();
            }
            if (done != "yes")
            {
                Console.WriteLine("Press any key to search for a definition.");
                Console.ReadKey();
            }
        }

        private void SearchDictionary()
        {
            Console.WriteLine("Please enter the word you would like to define.");
            string word = Console.ReadLine();
            Console.WriteLine("The definition of {0} is {1}", word, dictionary.Search(word));
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
