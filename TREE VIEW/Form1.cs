using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREE_VIEW
{
    public partial class MyTreeView1 : Form
    {
        public MyTreeView1()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblSelected.Text = TreeView1.SelectedNode.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyTreeView2.Nodes.Add("لغات البرمجة");
            MyTreeView2.Nodes.Add("تصميم الويب");
            MyTreeView2.Nodes.Add(" الكمبيوتر ");

            MyTreeView2.Nodes[0].Nodes.Add("سي شارب");
            MyTreeView2.Nodes[0].Nodes.Add("جافا");
            MyTreeView2.Nodes[0].Nodes[1].Nodes.Add("جافا اس اي ");
            MyTreeView2.Nodes[0].Nodes[1].Nodes.Add("جافا اي اي ");
            MyTreeView2.Nodes[0].Nodes.Add("بايثون");

            MyTreeView2.Nodes[1].Nodes.Add("اتش تي ام ال");
            MyTreeView2.Nodes[1].Nodes.Add("سي اس اس ");
            MyTreeView2.Nodes[1].Nodes.Add("جافا سكريبت");

            MyTreeView2.Nodes[2].Nodes.Add("اش بي ");
            MyTreeView2.Nodes[2].Nodes.Add("دال");

        }

        private void MyTreeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblSelected.Text = MyTreeView2.SelectedNode.Text;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            MytreeView3.Nodes.Add("PL").Nodes.Add("JAVA").Parent.Nodes.Add("CSharp");
        }

        private void btnCopySelect_Click(object sender, EventArgs e)
        {
             foreach (TreeNode tn in TreeView1.Nodes)
             {
                tbSelected.Text += tn.Text + tbEnter.Text;
             }

        }

        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void CheckTreeViewNode(TreeNode node,Boolean isChecked)
        {
            foreach(TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count>0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }


        }
    }
}
