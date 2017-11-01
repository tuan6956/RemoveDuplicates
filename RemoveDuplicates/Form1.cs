using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveDuplicates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        string[] output = null;
        private void btnOpenFileMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileMain.Text = open.FileName;
            }
            else
                MessageBox.Show("Không thành công, vui lòng thực hiện lại");
        }

        private void btnOpenFileCheck_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFileCheck.Text = open.FileName;
            }
            else
                MessageBox.Show("Không thành công, vui lòng thực hiện lại");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;
            save.Title = "Save Account Live";
            if (save.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(save.FileName, output);
            else
                MessageBox.Show("Không thành công, vui lòng thực hiện lại");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            new Thread(() =>
            {
                string Main = File.ReadAllText(txtFileMain.Text);
                string[] Check = File.ReadAllLines(txtFileCheck.Text);
                output = Check.Where(linecheck => !Main.Contains(linecheck.Split('|')[Convert.ToInt32(txtIndex.Text) - 1].Trim())).ToArray();
                MessageBox.Show($"Duplicates {Check.Length - output.Length}/{Check.Length}");
                btnRemove.Enabled = true;
            }).Start();
        }
    }
}
