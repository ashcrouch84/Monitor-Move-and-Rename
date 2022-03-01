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

namespace Monitor_Move_and_Rename
{
    public partial class Form1 : Form
    {
        string strBarcode;
        int i;
        string path1;
        string strTemp;
        string path2;
        string path3;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            path3 = Properties.Settings.Default.savedTouch.ToString();
            path2 = Properties.Settings.Default.savedSent.ToString();
            path1 = Properties.Settings.Default.savedOrigin.ToString();
            string destination = Properties.Settings.Default.savedOrigin;
            string[] files =  Directory.GetFiles(destination);
            if (files.Length > 0)
            {
                read_Barcode();
                //move the file to the directory
                strTemp = files.Length.ToString() + " new files found";
                lstMonitor.Items.Add(strTemp);
                i= 0;
                foreach (string file in files)
                {
                    if (Ready(file) == true)
                    {
                        //find extension
                        var strext = file.ToString().Split('.');
                        string strTime = DateTime.Now.ToString("hhmmss");
                        string strGrotto = Properties.Settings.Default.savedGrotto.ToString();
                        string strNew = Path.Combine(path2, strBarcode + " G" + strGrotto+ " " + strTime +" "+ i + "." + strext[1].ToString());
                        string strTouch = Path.Combine(path3, strBarcode + " G" + strGrotto + " " + strTime + " " + i + "." + strext[1].ToString());
                        strTemp = "Moving " + strNew.ToString();
                        lstMonitor.Items.Add(strTemp);
                        try
                        {
                            File.Copy(file, strTouch);
                        }
                        catch { }
                        try
                        {
                            File.Move(file, strNew);
                        }
                        catch
                        { }
                            i = i + 1;
                    }
                }
                
            }
        }

        public static bool Ready(string filename)
        {
            try
            {
                using (FileStream inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                    return inputStream.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            strTemp = Properties.Settings.Default.savedGrotto.ToString() + " grotto selected";
            lstMonitor.Items.Add(strTemp);
            lstMonitor.Items.Add("Monitoring Folder for new files");
            cmdstop.Enabled = true;
            cmdStart.Enabled = false;
            groupBox3.Visible = false;
            cmdBarcode.Enabled = false;
            cmdBrowse.Enabled = false;
            cmdBrowse2.Enabled = false;
            cmdsave.Enabled = false;
            cmdTouch.Enabled = false;
        }

        public void read_Barcode()
        {
            var list = new List<string>();
            try
            {
                string strread = Properties.Settings.Default.savedBarcode.ToString();
                strread = strread + "//Cam" + cboGrottos.SelectedItem.ToString() + ".txt";

                var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();
                strBarcode = list[2].ToString();
                string strmessage = "Barcode is " + strBarcode.ToString();
                lstMonitor.Items.Add(strmessage);
            }
            catch
            {
                System.Threading.Thread.Sleep(3000);
                try
                {
                    string strread = Properties.Settings.Default.savedBarcode.ToString();
                    strread = strread + "//Cam" + cboGrottos.SelectedItem.ToString() + ".txt";
                    var fileStream = new FileStream(strread, FileMode.Open, System.IO.FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            list.Add(line);
                        }
                    }
                    fileStream.Close();
                    strBarcode = list[2].ToString();
                    string strmessage = "Barcode is " + strBarcode.ToString();
                    lstMonitor.Items.Add(strmessage);
                }
                catch
                { }
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtBrowse.Text)) GrottoCamBrowser.SelectedPath = txtBrowse.Text;
                if (GrottoCamBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtBrowse.Text = GrottoCamBrowser.SelectedPath;
                    Properties.Settings.Default.savedOrigin = txtBrowse.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch
            {
            }
        }

        private void cmdBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtBrowse2.Text)) GrottoCamBrowser.SelectedPath = txtBrowse2.Text;
                if (GrottoCamBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtBrowse2.Text = GrottoCamBrowser.SelectedPath;
                    Properties.Settings.Default.savedSent = txtBrowse2.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch
            {
            }
        }

        private void cmdBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtBarcode.Text)) GrottoCamBrowser.SelectedPath = txtBarcode.Text;
                if (GrottoCamBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtBarcode.Text = GrottoCamBrowser.SelectedPath;
                    Properties.Settings.Default.savedBarcode = txtBarcode.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch
            {
            }
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.savedInterval = Int32.Parse(txtInterval.Text);
                Properties.Settings.Default.Save();
                timer1.Interval = Properties.Settings.Default.savedInterval;
                lstMonitor.Items.Add("Updated interval time");
            }
            catch
            {
                MessageBox.Show("Please ensure that the interval is a whole number", "Interval Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInterval.Text = Properties.Settings.Default.savedInterval.ToString();
            }
        }

        private void rbG1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedGrotto = 1;
            Properties.Settings.Default.Save();
        }

        private void rbG3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedGrotto = 3;
            Properties.Settings.Default.Save();
        }

        private void rbG2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedGrotto = 2;
            Properties.Settings.Default.Save();
        }

        private void rbG4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedGrotto = 4;
            Properties.Settings.Default.Save();
        }

        private void cmdstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lstMonitor.Items.Add("Stopping file monitoring");
            cmdstop.Enabled = false;
            cmdStart.Enabled = true;
            groupBox3.Visible = true;
            cmdBarcode.Enabled = true;
            cmdBrowse.Enabled = true;
            cmdBrowse2.Enabled = true;
            cmdsave.Enabled = true;
            cmdTouch.Enabled = true;
        }

        public void Load_Settings()
        {
            txtBarcode.Text = Properties.Settings.Default.savedBarcode.ToString();
            txtBrowse.Text = Properties.Settings.Default.savedOrigin.ToString();
            txtBrowse2.Text = Properties.Settings.Default.savedSent.ToString();
            txtInterval.Text = Properties.Settings.Default.savedInterval.ToString();
            txtTouchLoc.Text = Properties.Settings.Default.savedTouch.ToString();
            i = 1;
            while (i<13)
            {
                cboGrottos.Items.Add(i);
                i = i + 1;
            }
            cboGrottos.SelectedIndex = Properties.Settings.Default.savedGrotto - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Settings();
        }

        private void cmdTouch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtBrowse.Text)) GrottoCamBrowser.SelectedPath = txtTouchLoc.Text;
                if (GrottoCamBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtTouchLoc.Text = GrottoCamBrowser.SelectedPath;
                    Properties.Settings.Default.savedTouch = txtTouchLoc.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch
            {
            }
        }

        private void cboGrottos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedGrotto = Int32.Parse(cboGrottos.SelectedItem.ToString());
            Properties.Settings.Default.Save();
        }
    }
}
