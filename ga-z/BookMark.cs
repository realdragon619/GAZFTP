using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
namespace ga_z
{
    [Serializable]
    public class BookMark
    {
        public struct myBook
        {
            public String bookname ;
            public String bookpath;
            public myBook(String bookname, String bookpath)
            {
                this.bookname = bookname;
                this.bookpath = bookpath;
            }
        }
        private ArrayList list;
        private myBook store;


        public BookMark()
        {
            list = new ArrayList();
        }
        public void setBookMark(String BookName, String BookPath)
        {
            store = new myBook(BookName, BookPath);
            list.Add(store);
        }
        public void addbook(String temp){
            list.Add(temp);
        }        
        public ArrayList getBooklist()
        {
            return list;   
        }
    }
}
