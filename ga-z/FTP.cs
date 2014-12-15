using System;
using System.Collections.Generic;
using System.Collections;
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
        Backup upload_backup;   
        FtpItem[] ftpitem;        
        Thread Th_Connect;
        Thread Th_File;
        FtpItem backupitem;
        String path;        
        String filename;       
        String backup_local_path;
        String backup_filename;

        int filesize;
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
            filename).Replace("\\", "/");
            client.PutFile(0, target,path);
            Thread.Sleep(1000);
            bar_form.close();
            refresh();      
            
        }
        private void getfile()
        {         
            string target = Path.Combine(path,filename);
            string ftp_target = Path.Combine(client.GetWorkingDirectory(0),
            filename).Replace("\\", "/");                        
            client.GetFile(0,target,ftp_target);           
            Thread.Sleep(1000);
            bar_form.close();
            
        }
        private void backupfile()
        {            
            string version = backup_filename;
            string[] split = version.Split('.');
            string time = DateTime.Now.ToString("yyyy년MM월dd일HH시mm분ss초");
            string new_version = split[0] + time + "." +split[1];
            string target = Path.Combine(backup_local_path, new_version);
            string ftp_target = Path.Combine(client.GetWorkingDirectory(0),
            backup_filename).Replace("\\", "/");
            client.GetFile(0, target, ftp_target);
            FileInfo file = new FileInfo(backup_local_path + "\\" + new_version);
            upload_backup.setBackup(file,backup_filename, backup_local_path, time);
        }
        public void Upload(string localpath,int size,string filename)
        {            
            this.path = localpath;
            this.filesize = size;
            this.filename = filename;
            bar_form.load_file_size(size);
            bar_form.load_file_name(filename);
            Th_Connect = new Thread(bar_form.show);
            Th_File = new Thread(putfile);
            Th_Connect.Start();
            Th_File.Start();                
                        
        }
        public void Download(string localpath, int size, string filename)
        {
            this.path = localpath;
            this.filesize = size;
            this.filename = filename ;
            bar_form.load_file_size(size);
            bar_form.load_file_name(filename);
            Th_Connect = new Thread(bar_form.show);
            Th_File = new Thread(getfile);
            Th_Connect.Start();
            Th_File.Start();      
        }
        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }
        public void Backup(Backup backup)
        {
            upload_backup = backup;
            this.backup_local_path = ProgramFilesx86() + "\\GazFTP\\backup";
                //ProgramFilesx86() + "\\GazFTP\\backup";
            this.backup_filename = backupitem.Name;          
            backupfile();
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
        public string getPath()
        {
            return client.GetWorkingDirectory(0);
        }
        public void Delete(string filename)
        {
            string ftp_target = Path.Combine(client.GetWorkingDirectory(0),
            filename).Replace("\\", "/");
            client.DeleteFile(0, ftp_target);
            refresh();
        }
        public Boolean compare(String filename)
        {            
            foreach (FtpItem f in ftpitem)
            {
                if (f.ItemType.ToString() == "Directory")
                {
                    continue;
                }
                if (f.Name == filename)
                {
                    backupitem = f;
                    return true;
                }
            }
            return false;
        }
    }
    [Serializable]
    class Backup
    {
        [Serializable]
        public struct myBackup
        {
            public FileInfo file;
            public String name;
            public String path;
            public String time;
            public myBackup(FileInfo file, String name, String path, String time)
            {
                this.file = file;
                this.name = name;
                this.path = path;
                this.time = time;
            }
        }
        private ArrayList list;
        private myBackup backup;

        public Backup()
        {
            list = new ArrayList();
        }
        public ArrayList getBackupList()
        {
            return list;
        }
        public void deleteList(int index)
        {
            list.RemoveAt(index);
        }
        public void setBackup(FileInfo file, String name,String path, String time)
        {            
            backup = new myBackup(file, name, path, time);
            list.Add(backup);
        }      
    }
}
