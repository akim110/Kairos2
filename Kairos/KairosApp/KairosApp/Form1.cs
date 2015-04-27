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

namespace KairosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            calendarForm calForm = new calendarForm();

            calForm.Show();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addBlockButton_Click(object sender, EventArgs e)
        {

        }

        private void addVerseButton_Click(object sender, EventArgs e)
        {

        }

        ImageList imageList1;

        public void ExtractAssociatedIconEx(string filepath)
        {
            // Initialize the ListView, ImageList and Form.
            imageList1 = new ImageList();
            listView1.SmallImageList = imageList1;
            listView1.View = View.SmallIcon;

            // Get the c:\ directory.
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@filepath);

            ListViewItem item;
            listView1.BeginUpdate();

            // For each file in the c:\ directory, create a ListViewItem 
            // and set the icon to the icon extracted from the file. 
            foreach (System.IO.FileInfo file in dir.GetFiles())
            {
                // Set a default icon for the file.
                Icon iconForFile = SystemIcons.WinLogo;

                item = new ListViewItem(file.Name, 1);
                iconForFile = Icon.ExtractAssociatedIcon(file.FullName);

                // Check to see if the image collection contains an image 
                // for this extension, using the extension as a key. 
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item.ImageKey = file.Extension;
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            ExtractAssociatedIconEx(searchBox.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
