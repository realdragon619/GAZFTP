﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
namespace ga_z
{
    public partial class MainForm : Form 
    {       
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        String []dirs;
        FTP ftp = new FTP();
        bool Conn = false;
        BookMarkForm bookform;
        FtpUserForm ftpuserform;
        BookMark bookmark;
        FtpUser ftpuser;
        Storage storage;
        Backup backup;
        Thread Th_Connect;
        String start_path = "C:\\";
        
        public MainForm()
        {
            InitializeComponent();
            Port.SelectedIndex = 0;
            FBD.SelectedPath = start_path;

            bookmark = new BookMark();
            bookform = new BookMarkForm();
            ftpuser = new FtpUser();
            ftpuserform = new FtpUserForm();
            storage = new Storage();
            backup = new Backup();
            Load_Data();
            PrintDir();
            showBookMark();
            showFtpUser();
            showStorage();

        } 
        public void PrintDir(){
            FolderFileList.Items.Clear();
            FileAttributes attributes = File.GetAttributes(FBD.SelectedPath);
            DirectoryInfo di = new DirectoryInfo(FBD.SelectedPath);
            FileInfo[] fiArr = di.GetFiles();
            dirs = Directory.GetDirectories(FBD.SelectedPath);
            if (FBD.SelectedPath != "C:\\")
            {
                ListViewItem lvi = new ListViewItem("..", 0);
                lvi.SubItems.Add("상위폴더");
                lvi.SubItems.Add("폴더");
                FolderFileList.Items.Add(lvi);
            }

            foreach (string dir in dirs)
            {
                ListViewItem lvi = new ListViewItem(Path.GetFileName(dir), 0);
                lvi.SubItems.Add(Path.GetDirectoryName(dir));
                lvi.SubItems.Add("폴더");
                FolderFileList.Items.Add(lvi);
            }
            foreach (FileInfo f in fiArr)
            {
                ListViewItem lvi;
               
                Icon iconForFile = SystemIcons.WinLogo;
                lvi = new ListViewItem(f.Name, 1);
                iconForFile = Icon.ExtractAssociatedIcon(f.FullName);
                if (!FileImageList.Images.ContainsKey(f.Extension))
                {
                    
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.FullName);
                    FileImageList.Images.Add(f.Extension, iconForFile);
                }
                lvi.ImageKey = f.Extension;                      
                lvi.SubItems.Add(f.DirectoryName);
                lvi.SubItems.Add("파일");
                lvi.SubItems.Add(f.Length.ToString());
                lvi.SubItems.Add(f.Extension);
                FolderFileList.Items.Add(lvi);
            }
            
        }
             
        private void FolderFileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
                if (FolderFileList.SelectedItems.Count == 1)
                {
                    string ClickFile = FolderFileList.FocusedItem.SubItems[0].Text;
                                        
                    if (ClickFile == "..")
                    {
                        
                        string temp = FBD.SelectedPath;
                        string [] temp_path = temp.Split('\\');
                        temp = "";
                        for (int i = 0; i < temp_path.Count() - 2; i++)
                        {                            
                            temp = temp + temp_path[i] + "\\";
                        }
                        if (temp_path.Count() != 2)
                        {
                            temp = temp + temp_path[temp_path.Count() - 2];
                        }
                        else if (temp_path.Count() == 2)
                        {
                            temp = "C:\\";
                        }
                        FBD.SelectedPath=temp;
                       
                    }
                    else
                    {
                        string Clicktype = FolderFileList.FocusedItem.SubItems[2].Text;
                        if (Clicktype == "폴더")
                        {
                            string path = FolderFileList.FocusedItem.SubItems[1].Text;
                            FBD.SelectedPath = path + "\\" + ClickFile;
                        }
                        else if (Clicktype == "파일")
                        {
                            if (FolderFileList.SelectedItems.Count == 1)
                            {
                                string localpath = FolderFileList.FocusedItem.SubItems[1].Text + "\\" + FolderFileList.FocusedItem.SubItems[0].Text;
                                Process.Start(localpath);
                            }
                        }                           
                    }
                    
                    FolderFileList.Items.Clear();
                    dirs = Directory.GetDirectories(FBD.SelectedPath);
                    DirectoryInfo di = new DirectoryInfo(FBD.SelectedPath);
                    FileInfo[] fiArr = di.GetFiles();

                    if (FBD.SelectedPath != "C:\\")
                    {
                        FolderFileList.Items.Add("..", 0);
                    }                   
                    
                    foreach (string dir in dirs)
                    {
                        ListViewItem lvi = new ListViewItem(Path.GetFileName(dir),0);
                        lvi.SubItems.Add(Path.GetDirectoryName(dir));
                        lvi.SubItems.Add("폴더");
                        lvi.SubItems.Add(Path.GetExtension(dir));
                        FolderFileList.Items.Add(lvi);
                    }
                    foreach (FileInfo f in fiArr)
                    {
                        ListViewItem lvi;
                        Icon iconForFile = SystemIcons.WinLogo;
                        lvi = new ListViewItem(f.Name, 1);
                        iconForFile = Icon.ExtractAssociatedIcon(f.FullName);
                        if (!FileImageList.Images.ContainsKey(f.Extension))
                        {
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.FullName);
                            FileImageList.Images.Add(f.Extension, iconForFile);
                        }
                        lvi.ImageKey = f.Extension;
                        lvi.SubItems.Add(f.DirectoryName);
                        lvi.SubItems.Add("파일");
                        lvi.SubItems.Add(f.Length.ToString());
                        lvi.SubItems.Add(f.Extension);
                        FolderFileList.Items.Add(lvi);
                    }            
                }            
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string port="";
            if (Port.Text == "FTP")
            {
                port = "21";
            }
            else if(Port.Text == "SFTP")
            {
                port = "22";
            }
            
            if (Conn == false)
            {
                Th_Connect = new Thread(connectForm.show);
                Th_Connect.Start();
                Conn = ftp.Connected(0, Host.Text, User.Text, Password.Text, port, FTPListview);
                connectForm.close();
                Connect.Text = "접속끊기"; 
            }
            else if (Conn == true)
            {
                Conn = ftp.DisConnenct(FTPListview);
                Connect.Text = "접속"; 
            }            
            
        }

        private void FTPListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FTPListview.SelectedItems.Count == 1)
            {
                ftp.DoubleClick(FTPListview,FTPListview.FocusedItem.SubItems[0].Text,FTPListview.FocusedItem.SubItems[3].Text);
            }
        }

        private void 업로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderFileList.SelectedItems.Count == 1 && Conn == true)
            {
                string localpath = FolderFileList.FocusedItem.SubItems[1].Text + "\\" + FolderFileList.FocusedItem.SubItems[0].Text;
                string filename = FolderFileList.FocusedItem.SubItems[0].Text;
                int size = int.Parse(FolderFileList.FocusedItem.SubItems[3].Text);
                if (ftp.compare(filename))
                {
                    ftp.Backup(backup);
                }
                ftp.Upload(localpath,size,filename);           

            }
        }

        private void 열기ToolStripButton_Click(object sender, EventArgs e)
        {

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                FolderFileList.Items.Clear();
                FileAttributes attributes = File.GetAttributes(FBD.SelectedPath);

                DirectoryInfo di = new DirectoryInfo(FBD.SelectedPath);
                FileInfo[] fiArr = di.GetFiles();

                dirs = Directory.GetDirectories(FBD.SelectedPath);


                if (FBD.SelectedPath != "C:\\")
                {
                    ListViewItem lvi = new ListViewItem("..", 0);
                    lvi.SubItems.Add("상위폴더");
                    lvi.SubItems.Add("폴더");
                    FolderFileList.Items.Add(lvi);
                }

                foreach (string dir in dirs)
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(dir), 0);
                    lvi.SubItems.Add(Path.GetDirectoryName(dir));
                    lvi.SubItems.Add("폴더");
                    FolderFileList.Items.Add(lvi);
                }
                foreach (FileInfo f in fiArr)
                {
                    ListViewItem lvi;

                    Icon iconForFile = SystemIcons.WinLogo;
                    lvi = new ListViewItem(f.Name, 1);
                    iconForFile = Icon.ExtractAssociatedIcon(f.FullName);
                    if (!FileImageList.Images.ContainsKey(f.Extension))
                    {

                        iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.FullName);
                        FileImageList.Images.Add(f.Extension, iconForFile);
                    }
                    lvi.ImageKey = f.Extension;
                    lvi.SubItems.Add(f.DirectoryName);
                    lvi.SubItems.Add("파일");
                    lvi.SubItems.Add(f.Length.ToString());
                    lvi.SubItems.Add(f.Extension);
                    FolderFileList.Items.Add(lvi);
                }
            }
        }

        private void 다운로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FTPListview.SelectedItems.Count == 1 && Conn == true)
            {
                string filename = FTPListview.FocusedItem.SubItems[0].Text;
                int size = int.Parse(FTPListview.FocusedItem.SubItems[1].Text);
                ftp.Download(FBD.SelectedPath, size, filename);
            }   
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FTPListview.SelectedItems.Count == 1 && Conn == true)
            {
                string filename = FTPListview.FocusedItem.SubItems[0].Text;
                ftp.Delete(filename);
            }   
        }

        private void file_download_Click(object sender, EventArgs e)
        {
            if (FTPListview.SelectedItems.Count == 1 && Conn == true)
            {
                string filename = FTPListview.FocusedItem.SubItems[0].Text;
                int size = int.Parse(FTPListview.FocusedItem.SubItems[1].Text);
                ftp.Download(FBD.SelectedPath, size, filename);
            }   
        }

        private void file_upload_Click(object sender, EventArgs e)
        {
            if (FolderFileList.SelectedItems.Count == 1 && Conn == true)
            {
                string localpath = FolderFileList.FocusedItem.SubItems[1].Text + "\\" + FolderFileList.FocusedItem.SubItems[0].Text;
                string filename = FolderFileList.FocusedItem.SubItems[0].Text;
                int size = int.Parse(FolderFileList.FocusedItem.SubItems[3].Text);
                ftp.Upload(localpath, size, filename);

            }
        }        

        private void book_mark_Click_1(object sender, EventArgs e)
        {
            bookform.show(bookmark,BookListview);         
            
        }    

        public void showBookMark(){
            BookListview.Items.Clear();
            ArrayList arr = bookmark.getBooklist();
            foreach (BookMark.myBook store in arr)
            {
                ListViewItem lvi = new ListViewItem(store.bookname, 0);
                lvi.SubItems.Add(store.bookpath);
                BookListview.Items.Add(lvi);
            }
        }

        public void showFtpUser()
        {
            userListview.Items.Clear();
            ArrayList arr = ftpuser.getUserlist();
            foreach (FtpUser.myUser store in arr)
            {                
                ListViewItem lvi = new ListViewItem(store.title, 1);
                lvi.SubItems.Add(store.host);
                lvi.SubItems.Add(store.name);
                lvi.SubItems.Add(store.pass);
                lvi.SubItems.Add(store.protocol);
                userListview.Items.Add(lvi);
            }
        }

        public void showStorage()
        {
            ArrayList arr = storage.getStorage();
            storeListview.Items.Clear();
            foreach (FileInfo f in arr)
            {
                ListViewItem lvi;

                Icon iconForFile = SystemIcons.WinLogo;
                lvi = new ListViewItem(f.Name, 1);
                iconForFile = Icon.ExtractAssociatedIcon(f.FullName);
                if (!FileImageList.Images.ContainsKey(f.Extension))
                {

                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.FullName);
                    FileImageList.Images.Add(f.Extension, iconForFile);
                }
                lvi.ImageKey = f.Extension;
                lvi.SubItems.Add(f.DirectoryName);
                lvi.SubItems.Add("파일");
                lvi.SubItems.Add(f.Length.ToString());
                lvi.SubItems.Add(f.Extension);
                storeListview.Items.Add(lvi);

            }
        }

        private void BookListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(BookListview.SelectedItems.Count == 1){
                FBD.SelectedPath = BookListview.FocusedItem.SubItems[1].Text;
                PrintDir();
            }        
        }

        public void Load_Data()
        {
            bookmark = new BookMark();
            ftpuser = new FtpUser();
            using (Stream input = File.OpenRead("ftp_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                bookmark = (BookMark)formatter.Deserialize(input);                
            }
            using (Stream input = File.OpenRead("user_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();                
                ftpuser = (FtpUser)formatter.Deserialize(input);
            }
            using (Stream input = File.OpenRead("storage_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                storage = (Storage)formatter.Deserialize(input);
            }
            using (Stream input = File.OpenRead("backup_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                backup = (Backup)formatter.Deserialize(input);
            }
        }

        public void Save_Data()
        {
            using (Stream output = File.Create("ftp_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, bookmark);              
            }
            using (Stream output = File.Create("user_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();              
                formatter.Serialize(output, ftpuser);
            }
            using (Stream output = File.Create("storage_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, storage);
            }
            using (Stream output = File.Create("backup_data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, backup);
            }
        }       

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Data();
        }

        private void 삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BookListview.SelectedItems.Count == 1)
            {
                bookmark.removeBookMark(BookListview.FocusedItem.Index);
                showBookMark();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ftpuserform.show(ftpuser, userListview);
        }

        private void userListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (userListview.SelectedItems.Count == 1)
            {
                string port = "21";
                String host = userListview.FocusedItem.SubItems[1].Text;
                String user = userListview.FocusedItem.SubItems[2].Text;
                String pass = userListview.FocusedItem.SubItems[3].Text;
                Host.Text = host;
                User.Text = user;
                Password.Text = pass;                
                if (Conn == true)
                {
                    Conn = ftp.DisConnenct(FTPListview);                    
                }
                Connect.Text = "접속끊기";
                Th_Connect = new Thread(connectForm.show);
                Th_Connect.Start();
                Conn = ftp.Connected(0, host, user, pass, port, FTPListview);
                connectForm.close();               
                
            }

        }

        private void 삭제ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (userListview.SelectedItems.Count == 1)
            {
                ftpuser.removeFtpUser(userListview.FocusedItem.Index);
                showFtpUser();
            }
        }

        private void 저장소로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderFileList.SelectedItems.Count == 1 && (FolderFileList.SelectedItems[0].SubItems[2].Text=="파일"))
            {
                tab1.SelectTab(0);
                string localpath = FolderFileList.FocusedItem.SubItems[1].Text + "\\" + FolderFileList.FocusedItem.SubItems[0].Text;
                storage.setFileLocation(localpath);
                showStorage();
            }
        }

        private void 삭제ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (storeListview.SelectedItems.Count == 1)
            {
                storage.deleteFile(storeListview.FocusedItem.Index);                
                showStorage();
            }
        }

        private void 업로드ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (storeListview.SelectedItems.Count == 1 && Conn == true)
            {
                string localpath = storeListview.FocusedItem.SubItems[1].Text + "\\" + storeListview.FocusedItem.SubItems[0].Text;
                string filename = storeListview.FocusedItem.SubItems[0].Text;
                int size = int.Parse(storeListview.FocusedItem.SubItems[3].Text);
                if (ftp.compare(filename))
                {
                    ftp.Backup(backup);
                }
                ftp.Upload(localpath, size, filename);

            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderFileList.SelectedItems.Count == 1)
            {
                string localpath = FolderFileList.FocusedItem.SubItems[1].Text + "\\" + FolderFileList.FocusedItem.SubItems[0].Text;
                Process.Start(localpath);
            }
        }

        private void 열기ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (storeListview.SelectedItems.Count == 1)
            {
                string localpath = storeListview.FocusedItem.SubItems[1].Text + "\\" + storeListview.FocusedItem.SubItems[0].Text;
                Process.Start(localpath);
            }
        }

        private void storeListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (storeListview.SelectedItems.Count == 1)
            {
                string localpath = storeListview.FocusedItem.SubItems[1].Text + "\\" + storeListview.FocusedItem.SubItems[0].Text;
                Process.Start(localpath);
            }
        }

        private void 백업목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (FTPListview.SelectedItems.Count == 1)
            {
                tab1.SelectTab(1);
                String ftp_file_name = FTPListview.FocusedItem.SubItems[0].Text;
                ArrayList arr = backup.getBackupList();
                BackupListview.Items.Clear();
                int count = 0;
                foreach (Backup.myBackup f in arr)
                {
                    if (f.name == ftp_file_name)
                    {
                        count++;
                        ListViewItem lvi;
                        Icon iconForFile = SystemIcons.WinLogo;
                        lvi = new ListViewItem(f.name);
                        iconForFile = Icon.ExtractAssociatedIcon(f.file.FullName);
                        if (!FileImageList.Images.ContainsKey(f.file.Extension))
                        {
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.file.FullName);
                            FileImageList.Images.Add(f.file.Extension, iconForFile);
                        }
                        lvi.ImageKey = f.file.Extension;
                        lvi.SubItems.Add(f.path);
                        lvi.SubItems.Add(f.time);
                        BackupListview.Items.Add(lvi);
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("백업목록이 없습니다.");
                }
            }
        }

        private void BackupListview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BackupListview.SelectedItems.Count == 1)
            {
                string version = BackupListview.FocusedItem.SubItems[0].Text;
                string[] split = version.Split('.');
                string new_version = split[0] + BackupListview.FocusedItem.SubItems[2].Text + "." + split[1];
                string localpath = BackupListview.FocusedItem.SubItems[1].Text + "\\" + new_version;
                Process.Start(localpath);
            }
        }

        private void 열기ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (BackupListview.SelectedItems.Count == 1)
            {
                string version = BackupListview.FocusedItem.SubItems[0].Text;
                string[] split = version.Split('.');
                string new_version = split[0] + BackupListview.FocusedItem.SubItems[2].Text + "." + split[1];
                string localpath = BackupListview.FocusedItem.SubItems[1].Text + "\\" + new_version;
                Process.Start(localpath);
            }
        }

        private void 업로드ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BackupListview.SelectedItems.Count == 1 && Conn == true)
            {
                string version = BackupListview.FocusedItem.SubItems[0].Text;
                string[] split = version.Split('.');
                string new_version = split[0] + BackupListview.FocusedItem.SubItems[2].Text + "." + split[1];
                string localpath = BackupListview.FocusedItem.SubItems[1].Text + "\\" + new_version;
                string filename = BackupListview.FocusedItem.SubItems[0].Text;
                FileInfo file = new FileInfo(localpath);
                int size = int.Parse(file.Length.ToString());                
                ftp.Upload(localpath, size, filename);
            }
        }

        private void 삭제ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (BackupListview.SelectedItems.Count == 1)
            {
                string version = BackupListview.FocusedItem.SubItems[0].Text;
                string[] split = version.Split('.');
                string new_version = split[0] + BackupListview.FocusedItem.SubItems[2].Text + "." + split[1];
                ArrayList arr = backup.getBackupList();
                int index = 0;
                foreach (Backup.myBackup f in arr)
                {
                    if (f.file.Name == new_version)
                    {
                        backup.deleteList(index);
                        f.file.Delete();
                        break;
                    }
                    index++;
                }
                BackupListview.Items.Clear();
                foreach (Backup.myBackup f in arr)
                {
                    if (f.name == version)
                    {
                        ListViewItem lvi;
                        Icon iconForFile = SystemIcons.WinLogo;
                        lvi = new ListViewItem(f.name);
                        iconForFile = Icon.ExtractAssociatedIcon(f.file.FullName);
                        if (!FileImageList.Images.ContainsKey(f.file.Extension))
                        {
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(f.file.FullName);
                            FileImageList.Images.Add(f.file.Extension, iconForFile);
                        }
                        lvi.ImageKey = f.file.Extension;
                        lvi.SubItems.Add(f.path);
                        lvi.SubItems.Add(f.time);
                        BackupListview.Items.Add(lvi);
                    }
                }
            }
        }
    }
}
