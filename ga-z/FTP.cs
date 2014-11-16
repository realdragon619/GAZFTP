using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BytesRoad.Net.Ftp;
using System.IO;
using System.Windows.Forms;

namespace ga_z
{
    class FTP
    {
        FtpClient client = new FtpClient();
        FtpItem[] ftpitem;
        
  
        public bool Connected(int Timeout, string FtpServer, string Username, string Password, string port, ListView listview)
        {
              
            client.PassiveMode = true;

            try
            {
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
        public void DoubleClick(ListView listview, string path,string type)
        {
            if (type == "폴더")
            {
                listview.Items.Clear();
                client.ChangeDirectory(0, path);
                ftpitem = client.GetDirectoryList(0);
                showItem(listview);
                
            }
        }
        public void Upload(string localpath)
        {
            string target = Path.Combine(client.GetWorkingDirectory(0),
            Path.GetFileName(localpath)).Replace("\\", "/");
            MessageBox.Show(target);
            client.PutFile(0,target,localpath);
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
    }
    
}