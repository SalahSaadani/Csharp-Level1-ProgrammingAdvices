using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASKED_TEXT_BOX
{
    public partial class frmMaskedTextBox : Form
    {
        public frmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (maskedTextBox1.MaskFull)
           {
                MessageBox.Show("True Input ", "Correct");
           }
           else
            MessageBox.Show("False Input", "incorrect");
        }
    }
}
