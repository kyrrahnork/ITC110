using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorkPeerExClasses
{
    public class TDictionary
    {
        private List<Term> terms;


        public TDictionary()
        {
            terms = new List<Term>();
        }

        public void AddTerm(Term t)
        {
            terms.Add(t);
        }

        public string Search(string word)
        {
            //string def = null;
            //foreach (Term t in terms)
            //{
            //    if (t.Word.Equals(word))
            //    {
            //        def = t.Definition;
            //    }
            //}
            Term tmp = terms.FirstOrDefault(t => t.Word.Equals(word));

            if (tmp != null)
                return tmp.Definition;
               return "definition not found";
        }
    }
}
