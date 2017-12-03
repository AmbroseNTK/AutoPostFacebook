using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mmosoft.Facebook.Sdk.Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listGroup;
        int elapsedTime = 0;
        int maxTime = 0;
        int curIndex = 0;
        FacebookClient facebookClient;
        private void button1_Click(object sender, EventArgs e)
        {
            
            facebookClient.PostToWall(txtContent.Text);
            MessageBox.Show("Đăng thành công!", "Thông Báo");
        }
        private void btnPostGroup_Click(object sender, EventArgs e)
        {

            timer1.Start();
            numSecond.Enabled = false;
            btnPostGroup.Enabled = false;
            comboGroupList.Enabled = false;
            processPost.Maximum = listGroup.Count;
        }

        private void comboGroupList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listGroup.Add(comboGroupList.Text);
                comboGroupList.Refresh();
                comboGroupList.DataSource = null;
                comboGroupList.DataSource = listGroup;
                comboGroupList.Text = "";
            }
            else if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    listGroup.Remove(comboGroupList.Text);
                    comboGroupList.Refresh();
                    comboGroupList.DataSource = null;
                    comboGroupList.DataSource = listGroup;
                    comboGroupList.Text = "";
                }
                catch { }
            }
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listGroup = new List<string>();
            timer1.Interval = 1000;
            maxTime = (int)numSecond.Value;
            progressBar1.Maximum = maxTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            if (elapsedTime > maxTime)
            {
                if (curIndex < listGroup.Count)
                {
                    try
                    {
                        facebookClient.PostToGroup(txtContent.Text, listGroup[curIndex]);
                        curIndex++;
                        processPost.Value = curIndex;
                    }
                    catch
                    {

                    }
                }
                else
                {
                    curIndex = 0;
                    numSecond.Enabled = true;
                    btnPostGroup.Enabled = true;
                    comboGroupList.Enabled = true;
                    MessageBox.Show("Đăng tin lên Group Facebook thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Stop();
                    elapsedTime = 0;
                    
                }
                
            }
            else
            {
                progressBar1.Value = elapsedTime;
            }
        }

        private void btLoadGroupList_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open Group list file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string data = File.ReadAllText(openFileDialog.FileName);
                        string[] lines = data.Split('\n');
                        foreach (string line in lines)
                        {
                            listGroup.Add(line);
                        }
                    }
                    catch { }
                }
                comboGroupList.DataSource = null;
                comboGroupList.DataSource = listGroup;
            }
        }

        private void numSecond_ValueChanged(object sender, EventArgs e)
        {
            
            maxTime = (int)numSecond.Value;
            progressBar1.Maximum = maxTime+1;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            try
            {
                facebookClient = new FacebookClient(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Đăng nhập thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể đăng nhập\n"+ex.Message, "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveListGroup_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach(string group in listGroup)
            {
                data += group + "\n";
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file to";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, data);
            }
        }
    }
}
