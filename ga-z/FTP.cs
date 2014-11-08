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


                foreach (FtpItem f in ftpitem)
                {
                    ListViewItem lvi = new ListViewItem(f.Name);
                    lvi.SubItems.Add(f.Size.ToString());
                    lvi.SubItems.Add(f.Date.ToString());
                    lvi.SubItems.Add(f.ItemType.ToString());
                    listview.Items.Add(lvi);
                }

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
        
    }
}