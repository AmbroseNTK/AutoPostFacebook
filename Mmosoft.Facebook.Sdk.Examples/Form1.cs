using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mmosoft.Facebook.Sdk.Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(txtUsername.Text, txtPassword.Text);
            fb.PostToWall(txtContent.Text);
            MessageBox.Show("Đăng thành công!", "Thông Báo");
        }
        private void btnPostGroup_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(txtUsername.Text, txtPassword.Text);

            fb.PostToGroup(txtContent.Text, txtIDgroup.Text);

            MessageBox.Show("Đăng tin lên Group Facebook thành công!", "Thông Báo");
        }
    }
}
