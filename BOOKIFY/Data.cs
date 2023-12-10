using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKIFY
{
    internal class Data
    {

    }

    public class bookList
    {
        private ArrayList books;

        public bookList() 
        {
            books = new ArrayList();
   
        }
    }

    public class bookCategories
    {
        private ArrayList categories;

        public bookCategories()
        {
            categories = new ArrayList { "Fictional", "Non-Fictional", "Academic" };
        }

        public ArrayList getBookCategories()
        {
            return categories;
        }

    }
}
