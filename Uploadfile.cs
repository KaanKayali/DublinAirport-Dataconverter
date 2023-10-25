using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DublinAirport_Prototype
{
    public partial class Uploadfile : Form
    {
        //Variables
        public List<string> filepath = new List<string>();

        public Uploadfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        //Upload file
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "CSV or Excel (*.csv, *.xlsx)|*.csv;*.xlsx|Excel files (*.xlsx)|*.xlsx|CSV files (*.csv)|*.csv";
            v1.Multiselect = true;

            if (v1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in v1.FileNames)
                {
                    String onlyFileName = System.IO.Path.GetFileName(s);
                    fileList.Items.Add(onlyFileName);
                    filepath.Add(s);

                }
                updateFilecount();
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeFileBtn.Enabled = (fileList.SelectedIndex == -1) ? false : true;
        }

        //Update filecount
        private void updateFilecount()
        {
            filelistLbl.Text = (fileList.Items.Count == 1) ? fileList.Items.Count.ToString() + " File uploaded" : fileList.Items.Count.ToString() + " Files uploaded";
        }

        //Remove file
        private void removeFileBtn_Click(object sender, EventArgs e)
        {
            if (fileList.SelectedIndex != -1)
            {
                filepath.RemoveAt(fileList.SelectedIndex);
                fileList.Items.RemoveAt(fileList.SelectedIndex);
                updateFilecount();

            }

        }

        //Debug
        private void nextBtn_Click(object sender, EventArgs e)
        {
            LoadingGif.Visible = true;
            string[] filepaths = filepath.ToArray();
            for(int i = 0; i < filepaths.Length; i++)
            {
                Readfile readfile = new Readfile(filepaths[i]);
                readfile.Show();
                
            }
            LoadingGif.Visible = false;
            //this.Hide();

        }

    }
}
