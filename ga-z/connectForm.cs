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
    public partial class connectForm : Form
    {
        int num_dot = 0;
        
        public connectForm()
        {
            InitializeComponent();
        }
        static connectForm connForm;
        public static void show(){
            connForm = new connectForm();
            connForm.ShowDialog();
        }
        public static void close()
        {
            connForm.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num_dot <= 5)
            {
                connLabel.Text += ".";
                num_dot++;
            }
            else
            {
                connLabel.Text = "Connecting.";
                num_dot = 0;
            }
            timer1.Interval = 500;
        }
    }
}
