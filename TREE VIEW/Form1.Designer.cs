
namespace TREE_VIEW
{
    partial class MyTreeView1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C Sharp");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Jave SE");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Java EE");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Java", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Programming Language", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Html");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("CSS");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("JavaScript");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Web Design", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HP");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("DELL");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Computer", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Java", 6, 6);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("CSharp", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Python", 8, 8);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("C++", 2, 2);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Programming Languages", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("HP", 5, 5);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Dell", 4, 4);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Apple", 0, 0);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Computer", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTreeView1));
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.MyTreeView2 = new System.Windows.Forms.TreeView();
            this.MytreeView3 = new System.Windows.Forms.TreeView();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.tbSelected = new System.Windows.Forms.TextBox();
            this.btnCopySelect = new System.Windows.Forms.Button();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.MytreeView4 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TreeView1
            // 
            this.TreeView1.CheckBoxes = true;
            this.TreeView1.Location = new System.Drawing.Point(336, 75);
            this.TreeView1.Name = "TreeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "C Sharp";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Jave SE";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Java EE";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Java";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Programming Language";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Html";
            treeNode7.Name = "Node8";
            treeNode7.Text = "CSS";
            treeNode8.Name = "Node9";
            treeNode8.Text = "JavaScript";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Web Design";
            treeNode10.Name = "Node10";
            treeNode10.Text = "HP";
            treeNode11.Name = "Node11";
            treeNode11.Text = "DELL";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Computer";
            this.TreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12});
            this.TreeView1.Size = new System.Drawing.Size(202, 271);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterCheck);
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(333, 34);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(47, 15);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(802, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MyTreeView2
            // 
            this.MyTreeView2.Location = new System.Drawing.Point(769, 75);
            this.MyTreeView2.Name = "MyTreeView2";
            this.MyTreeView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyTreeView2.RightToLeftLayout = true;
            this.MyTreeView2.Size = new System.Drawing.Size(148, 262);
            this.MyTreeView2.TabIndex = 4;
            this.MyTreeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MyTreeView2_AfterSelect);
            // 
            // MytreeView3
            // 
            this.MytreeView3.Location = new System.Drawing.Point(947, 75);
            this.MytreeView3.Name = "MytreeView3";
            this.MytreeView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MytreeView3.Size = new System.Drawing.Size(148, 262);
            this.MytreeView3.TabIndex = 6;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(979, 34);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 35);
            this.btnAdd2.TabIndex = 5;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // tbSelected
            // 
            this.tbSelected.Location = new System.Drawing.Point(545, 75);
            this.tbSelected.Multiline = true;
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.Size = new System.Drawing.Size(186, 262);
            this.tbSelected.TabIndex = 7;
            // 
            // btnCopySelect
            // 
            this.btnCopySelect.Location = new System.Drawing.Point(497, 27);
            this.btnCopySelect.Name = "btnCopySelect";
            this.btnCopySelect.Size = new System.Drawing.Size(75, 35);
            this.btnCopySelect.TabIndex = 8;
            this.btnCopySelect.Text = ">>";
            this.btnCopySelect.UseVisualStyleBackColor = true;
            this.btnCopySelect.Click += new System.EventHandler(this.btnCopySelect_Click);
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(596, 41);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(100, 21);
            this.tbEnter.TabIndex = 9;
            this.tbEnter.Text = "\r\n";
            this.tbEnter.Visible = false;
            // 
            // MytreeView4
            // 
            this.MytreeView4.ImageIndex = 0;
            this.MytreeView4.ImageList = this.imageList1;
            this.MytreeView4.Location = new System.Drawing.Point(47, 75);
            this.MytreeView4.Name = "MytreeView4";
            treeNode13.ImageIndex = 6;
            treeNode13.Name = "Node2";
            treeNode13.SelectedImageIndex = 6;
            treeNode13.Text = "Java";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Node3";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "CSharp";
            treeNode15.ImageIndex = 8;
            treeNode15.Name = "Node4";
            treeNode15.SelectedImageIndex = 8;
            treeNode15.Text = "Python";
            treeNode16.ImageIndex = 2;
            treeNode16.Name = "Node5";
            treeNode16.SelectedImageIndex = 2;
            treeNode16.Text = "C++";
            treeNode17.ImageIndex = 7;
            treeNode17.Name = "Node0";
            treeNode17.SelectedImageIndex = 7;
            treeNode17.Text = "Programming Languages";
            treeNode18.ImageIndex = 5;
            treeNode18.Name = "Node6";
            treeNode18.SelectedImageIndex = 5;
            treeNode18.Text = "HP";
            treeNode19.ImageIndex = 4;
            treeNode19.Name = "Node7";
            treeNode19.SelectedImageIndex = 4;
            treeNode19.Text = "Dell";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "Node8";
            treeNode20.SelectedImageIndex = 0;
            treeNode20.Text = "Apple";
            treeNode21.ImageIndex = 3;
            treeNode21.Name = "Node1";
            treeNode21.SelectedImageIndex = 3;
            treeNode21.Text = "Computer";
            this.MytreeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21});
            this.MytreeView4.SelectedImageIndex = 0;
            this.MytreeView4.Size = new System.Drawing.Size(217, 271);
            this.MytreeView4.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apple.png");
            this.imageList1.Images.SetKeyName(1, "C Sharp.png");
            this.imageList1.Images.SetKeyName(2, "C++.png");
            this.imageList1.Images.SetKeyName(3, "Computer.png");
            this.imageList1.Images.SetKeyName(4, "Dell.png");
            this.imageList1.Images.SetKeyName(5, "HP.png");
            this.imageList1.Images.SetKeyName(6, "Java.png");
            this.imageList1.Images.SetKeyName(7, "Programming Languages.png");
            this.imageList1.Images.SetKeyName(8, "Python.png");
            // 
            // MyTreeView1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 467);
            this.Controls.Add(this.MytreeView4);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.btnCopySelect);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.MytreeView3);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.MyTreeView2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.TreeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyTreeView1";
            this.Text = "frmTreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView MyTreeView2;
        private System.Windows.Forms.TreeView MytreeView3;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox tbSelected;
        private System.Windows.Forms.Button btnCopySelect;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.TreeView MytreeView4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

