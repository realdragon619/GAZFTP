using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ga_z
{
    public partial class BookMarkForm : Form
    {
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        BookMarkForm bookmark;
        static BookMark refbook;
        static ListView listview;
        public BookMarkForm()
        {
            refbook = new BookMark();
            InitializeComponent();            
        }
        
        public void show(BookMark book , ListView booklist)
        {
            listview = new ListView();
            bookmark = new BookMarkForm();
            refbook = book;
            listview = booklist;
            bookmark.ShowDialog();         
            
        }        
        
        public void close()
        {
            bookmark.Close();
        }
       
        public void setText(String t){
            
        }
        
        private void search_path_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text=FBD.SelectedPath;
            }
        }

        private void book_submit_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();
            refbook.setBookMark(titleBox.Text, pathBox.Text);
            ArrayList arr = refbook.getBooklist();
            foreach (BookMark.myBook store in arr)
            {
                ListViewItem lvi = new ListViewItem(store.bookname, 0);
                lvi.SubItems.Add(store.bookpath);                
                listview.Items.Add(lvi);
            }
            Close();
        }                
    }
}
