using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ga_z
{
    public partial class load_bar : Form
    {
        static int bar_value = 0;
        static int bar_max_value = 0;
        static string current_file_name = "";
        public load_bar load;
       
        
        public load_bar()
        {
            InitializeComponent();
            byte_bar.Maximum = bar_max_value;
              
        }
        public void show()
        {
            load = new load_bar();
            load.ShowDialog();
            
        }
        public void close()
        {
            load.Close();
            timer1.Stop();
        }
        public void set_bar(int value){
            bar_value = value;
                
        }
        public void load_file_size(int value)
        {
            bar_max_value = value;
        }
        public void load_file_name(string name)
        {
            current_file_name = name;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            byte_bar.Value = bar_value;
            byte_label.Text = "현재 파일 " + current_file_name + " " + bar_value.ToString() + "/" + bar_max_value;
            if (byte_bar.Value == byte_bar.Maximum)
            {                
                bar_value = 0;
                timer1.Stop();               
            }
                                
        }

        private void load_bar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void load_bar_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
        
    }
}
