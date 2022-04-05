namespace rjtce
{
    partial class MainFormol
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormol));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            // 
            // listView1
            // 
            listViewItem1.ImageIndex = 0;
            listViewItem1.Tag = "1";
            listViewItem1.Text = "查询库存";
            listViewItem2.ImageIndex = 1;
            listViewItem2.Tag = "2";
            listViewItem2.Text = "退出";
            this.listView1.Items.Add(listViewItem1);
            this.listView1.Items.Add(listViewItem2);
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 243);
            this.listView1.TabIndex = 0;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.Text = "仁济堂WINCE程序";
            // 
            // MainFormol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "MainFormol";
            this.Text = "主页";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}