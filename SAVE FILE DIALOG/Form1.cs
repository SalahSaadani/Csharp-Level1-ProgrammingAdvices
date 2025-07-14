using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAVE_FILE_DIALOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Title = "Save us ";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt| All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Open file ";
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt| All files (*.*)|*.*|pdf files (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 3;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt| All files (*.*)|*.*|pdf files (*.pdf)|*.pdf";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames )
                {
                    MessageBox.Show(file);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
