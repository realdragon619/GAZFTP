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
    public partial class FtpUserForm : Form
    {
        FtpUserForm FtpUser;
        static FtpUser refuser;
        static ListView listview;

        public FtpUserForm()
        {
            refuser = new FtpUser();
            InitializeComponent();
        }
        public void show(FtpUser ftpuser, ListView Userlist)
        {
            listview = new ListView();        
            FtpUser = new FtpUserForm();
            refuser = ftpuser;
            listview = Userlist;
            FtpUser.ShowDialog();
        }
        public void close()
        {
            FtpUser.Close();
        }
        private void book_submit_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();
            refuser.setFtpUser(titleBox.Text,HostBox.Text, UserBox.Text, PassBox.Text, PortBox.Text);
            ArrayList arr = refuser.getUserlist();
            foreach (FtpUser.myUser store in arr)
            {
                ListViewItem lvi = new ListViewItem(store.title, 1);
                lvi.SubItems.Add(store.host);
                lvi.SubItems.Add(store.name);
                lvi.SubItems.Add(store.pass);
                lvi.SubItems.Add(store.protocol);
                listview.Items.Add(lvi);
            }
            Close();
        }
    }
}
