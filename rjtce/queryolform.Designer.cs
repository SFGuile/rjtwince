namespace rjtce
{
    partial class queryolform
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
            this.labbarcode = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.btnscan = new System.Windows.Forms.Button();
            this.labprodno = new System.Windows.Forms.Label();
            this.txtprodno = new System.Windows.Forms.TextBox();
            this.labbatchno = new System.Windows.Forms.Label();
            this.txtbatch = new System.Windows.Forms.TextBox();
            this.labprodname = new System.Windows.Forms.Label();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.btnquery = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labbarcode
            // 
            this.labbarcode.Location = new System.Drawing.Point(3, 18);
            this.labbarcode.Name = "labbarcode";
            this.labbarcode.Size = new System.Drawing.Size(56, 20);
            this.labbarcode.Text = "条型码";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(65, 15);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(170, 23);
            this.txtbarcode.TabIndex = 1;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // btnscan
            // 
            this.btnscan.Location = new System.Drawing.Point(18, 44);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(72, 20);
            this.btnscan.TabIndex = 2;
            this.btnscan.Text = "自动扫描";
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // labprodno
            // 
            this.labprodno.Location = new System.Drawing.Point(3, 73);
            this.labprodno.Name = "labprodno";
            this.labprodno.Size = new System.Drawing.Size(73, 20);
            this.labprodno.Text = "药品编码";
            // 
            // txtprodno
            // 
            this.txtprodno.Location = new System.Drawing.Point(82, 70);
            this.txtprodno.Name = "txtprodno";
            this.txtprodno.Size = new System.Drawing.Size(142, 23);
            this.txtprodno.TabIndex = 4;
            // 
            // labbatchno
            // 
            this.labbatchno.Location = new System.Drawing.Point(3, 102);
            this.labbatchno.Name = "labbatchno";
            this.labbatchno.Size = new System.Drawing.Size(50, 20);
            this.labbatchno.Text = "批号";
            // 
            // txtbatch
            // 
            this.txtbatch.Location = new System.Drawing.Point(82, 99);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(142, 23);
            this.txtbatch.TabIndex = 6;
            // 
            // labprodname
            // 
            this.labprodname.Location = new System.Drawing.Point(3, 125);
            this.labprodname.Name = "labprodname";
            this.labprodname.Size = new System.Drawing.Size(100, 20);
            this.labprodname.Text = "药品名称";
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(3, 148);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.Size = new System.Drawing.Size(221, 23);
            this.txtprodname.TabIndex = 8;
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(3, 194);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(72, 20);
            this.btnquery.TabIndex = 9;
            this.btnquery.Text = "查询";
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(82, 194);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(72, 20);
            this.btnclean.TabIndex = 10;
            this.btnclean.Text = "清空";
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(163, 194);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(72, 20);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "返回";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(122, 44);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(84, 20);
            this.btnreset.TabIndex = 16;
            this.btnreset.Text = "扫描枪重置";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // queryolform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.labprodname);
            this.Controls.Add(this.txtbatch);
            this.Controls.Add(this.labbatchno);
            this.Controls.Add(this.txtprodno);
            this.Controls.Add(this.labprodno);
            this.Controls.Add(this.btnscan);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.labbarcode);
            this.Name = "queryolform";
            this.Text = "药品查询";
            this.Load += new System.EventHandler(this.queryolform_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.queryolform_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labbarcode;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Button btnscan;
        private System.Windows.Forms.Label labprodno;
        private System.Windows.Forms.TextBox txtprodno;
        private System.Windows.Forms.Label labbatchno;
        private System.Windows.Forms.TextBox txtbatch;
        private System.Windows.Forms.Label labprodname;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
    }
}