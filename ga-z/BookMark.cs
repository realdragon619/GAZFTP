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
        [Serializable]
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
        public ArrayList getBooklist()
        {
            return list;   
        }
        public void removeBookMark(int index)
        {
            list.RemoveAt(index);
        }

    }
    [Serializable]
    public class FtpUser
    {
        
        [Serializable]
        public struct myUser
        {
            public String title;
            public String host;
            public String name;
            public String pass;
            public String protocol;
            public myUser(String title, String host, String name, String pass, String protocol)
            {
                this.title = title;
                this.host = host;
                this.name = name;
                this.pass = pass;
                this.protocol = protocol;
            }
        }        
        private ArrayList list;
        private myUser store;

        public FtpUser()
        {
            list = new ArrayList();
        }        
        public void setFtpUser(String title, String host, String name, String pass, String protocol)
        {
            store = new myUser(title, host, name, pass, protocol);
            list.Add(store);
        }
        public ArrayList getUserlist()
        {
            return list;
        }
        public void removeFtpUser(int index)
        {
            list.RemoveAt(index);
        }
    }
}
