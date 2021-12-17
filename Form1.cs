using Pictures.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictures
{
    public partial class F_Picture : Form
    {
        public string path
        {
            get
            {
                return Settings.Default.path;
            }
            set
            {
                Settings.Default.path = value;
            }
        }
        public bool IsPicture
        {
            get
            {
                return Settings.Default.IsPicture;
            }
            set
            {
                Settings.Default.IsPicture = value;
            }
        }
        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        public F_Picture()
        {
            InitializeComponent();
            //pb_Picture1.ImageLocation = path;
            if (IsPicture)
            {
                pb_Picture1.ImageLocation = path;
                bt_Remove.Enabled = true;
            }
               else
            {
                bt_Remove.Enabled = false;
            }

            if (IsMaximize)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void F_Picture_Load(object sender, EventArgs e)
        {

        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            ofd_picture.InitialDirectory = "c:\\";
            ofd_picture.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd_picture.RestoreDirectory = true;
            if (ofd_picture.ShowDialog() == DialogResult.OK)
            {
                pb_Picture1.ImageLocation = ofd_picture.FileName;
                //path = ofd_picture.FileName;
                //pb_Picture1.ImageLocation = path;
                bt_Remove.Enabled = true;
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            pb_Picture1.Image = null;
            bt_Remove.Enabled = false;
            //path = null;
            pb_Picture1.ImageLocation = null;
        }

        private void F_Picture_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            //path = pb_Picture1.ImageLocation;
            if (pb_Picture1.Image == null)
                IsPicture = false;
            else
            {
                IsPicture = true;
                path = pb_Picture1.ImageLocation;
            }
                

            Settings.Default.Save();
        }
    }
}
