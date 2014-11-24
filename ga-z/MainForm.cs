using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace ga_z
{
    public partial class MainForm : Form 
    {
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        String []dirs;
        FTP ftp = new FTP();
        bool Conn = false;
        Thread Th_Connect;
        String start_path = "C:\\";
        
        public MainForm()
        {
            InitializeComponent();
            Port.SelectedIndex = 0;
            FBD.SelectedPath = start_path;
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


                
    }
}
