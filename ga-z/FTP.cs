using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BytesRoad.Net.Ftp;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace ga_z
{
    class FTP
    {
        FtpClient client = new FtpClient();
        load_bar bar_form = new load_bar();
        ListView listview;           
        FtpItem[] ftpitem;        
        Thread Th_Connect;
        Thread Th_Putfile;
        String localpath;
        int filesize;
        string local_filename;

        public FTP()
        {
            client.DataTransfered += new FtpClient.DataTransferedEventHandler(client_DataTransfered);
        }
                     

        public bool Connected(int Timeout, string FtpServer, string Username, string Password, string port, ListView listview)
        {

            client.PassiveMode = true;

            try
            {
                this.listview = listview;
                client.Connect(Timeout, FtpServer, 21);
                client.Login(Timeout, Username, Password);
                ftpitem = client.GetDirectoryList(0);
                showItem(listview);

            }
            catch (FtpErrorException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        public bool DisConnenct(ListView listview)
        {
            client.Disconnect(0);
            listview.Items.Clear();
            return false;
        }
        public void DoubleClick(ListView listview, string path, string type)
        {
            if (type == "폴더")
            {
                listview.Items.Clear();
                client.ChangeDirectory(0, path);
                ftpitem = client.GetDirectoryList(0);
                showItem(listview);

            }
        }
        private void putfile()
        {
            string target = Path.Combine(client.GetWorkingDirectory(0),
            Path.GetFileName(localpath)).Replace("\\", "/");
            client.PutFile(0, target, localpath);
            Thread.Sleep(1000);
            bar_form.close();
            refresh();
            
            
        }
        public void Upload(string localpath,int size,string filename)
        {
            this.localpath = localpath;
            this.filesize = size;
            this.local_filename = filename;
            bar_form.load_file_size(size);
            bar_form.load_file_name(local_filename);
            Th_Connect = new Thread(bar_form.show);
            Th_Putfile = new Thread(putfile);
            Th_Connect.Start();
            Th_Putfile.Start();       
           
                       
                        
        }
        public void refresh()
        {
            listview.Items.Clear();
            ftpitem = client.GetDirectoryList(0);
            showItem(this.listview);
        }
        public void showItem(ListView listview)
        {

            foreach (FtpItem f in ftpitem)
            {
                if (f.ItemType.ToString() != "Directory")
                {
                    continue;
                }
                ListViewItem lvi = new ListViewItem(f.Name, 0);
                lvi.SubItems.Add(f.Size.ToString());
                lvi.SubItems.Add(f.Date.ToString());
                lvi.SubItems.Add("폴더");
                listview.Items.Add(lvi);

            }
            foreach (FtpItem f in ftpitem)
            {
                if (f.ItemType.ToString() == "Directory")
                {
                    continue;
                }
                ListViewItem lvi = new ListViewItem(f.Name, 1);
                lvi.SubItems.Add(f.Size.ToString());
                lvi.SubItems.Add(f.Date.ToString());
                lvi.SubItems.Add("파일");
                listview.Items.Add(lvi);
            }
            

        }
        private void client_DataTransfered(object sender, DataTransferedEventArgs e)
        {
            bar_form.set_bar(e.WholeTransfered);
        }

    }
    
}