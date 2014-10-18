using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ga_z
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        string[] files;
        string[] dirs;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void FolderOpen_Click(object sender, EventArgs e)
        {         

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                FolderFileList.Items.Clear();                 
                files= Directory.GetFiles(FBD.SelectedPath);
                dirs = Directory.GetDirectories(FBD.SelectedPath);
                if (FBD.SelectedPath != "C:\\")
                {
                    FolderFileList.Items.Add("..", 0);
                }
                foreach (string file in files)
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(file),1);
                    lvi.SubItems.Add(Path.GetDirectoryName(file));
                    FolderFileList.Items.Add(lvi);
                }
                foreach (string dir in dirs)
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(dir),0);
                    lvi.SubItems.Add(Path.GetDirectoryName(dir));
                    FolderFileList.Items.Add(lvi);
                }
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
                        string path = FolderFileList.FocusedItem.SubItems[1].Text;
                        FBD.SelectedPath = path + "\\" + ClickFile;
                    }
                    
                    FolderFileList.Items.Clear();                 
                    files= Directory.GetFiles(FBD.SelectedPath);
                    dirs = Directory.GetDirectories(FBD.SelectedPath);
                    if (FBD.SelectedPath != "C:\\")
                    {
                        FolderFileList.Items.Add("..", 0);
                    }
                   
                foreach (string file in files)
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(file),1);
                    lvi.SubItems.Add(Path.GetDirectoryName(file));
                    FolderFileList.Items.Add(lvi);
                }
                foreach (string dir in dirs)
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(dir),0);
                    lvi.SubItems.Add(Path.GetDirectoryName(dir));
                    FolderFileList.Items.Add(lvi);
                }
            
                }
            
        }

       

        
    }
}
