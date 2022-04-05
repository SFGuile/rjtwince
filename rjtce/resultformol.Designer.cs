namespace rjtce
{
    partial class resultformol
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
            this.resultgirdview = new System.Windows.Forms.DataGrid();
            this.btnclose = new System.Windows.Forms.Button();
            this.labrecordcount = new System.Windows.Forms.Label();
            this.btn_jump1st = new System.Windows.Forms.Button();
            this.btn_jumppre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_page = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_jumpage = new System.Windows.Forms.Button();
            this.lab_page = new System.Windows.Forms.Label();
            this.labresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultgirdview
            // 
            this.resultgirdview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resultgirdview.Location = new System.Drawing.Point(3, 29);
            this.resultgirdview.Name = "resultgirdview";
            this.resultgirdview.Size = new System.Drawing.Size(232, 163);
            this.resultgirdview.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(185, 198);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(53, 20);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "关闭";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labrecordcount
            // 
            this.labrecordcount.Location = new System.Drawing.Point(3, 6);
            this.labrecordcount.Name = "labrecordcount";
            this.labrecordcount.Size = new System.Drawing.Size(232, 20);
            this.labrecordcount.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // btn_jump1st
            // 
            this.btn_jump1st.Location = new System.Drawing.Point(3, 198);
            this.btn_jump1st.Name = "btn_jump1st";
            this.btn_jump1st.Size = new System.Drawing.Size(37, 20);
            this.btn_jump1st.TabIndex = 2;
            this.btn_jump1st.Text = "|<";
            this.btn_jump1st.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_jumppre
            // 
            this.btn_jumppre.Location = new System.Drawing.Point(46, 198);
            this.btn_jumppre.Name = "btn_jumppre";
            this.btn_jumppre.Size = new System.Drawing.Size(38, 20);
            this.btn_jumppre.TabIndex = 3;
            this.btn_jumppre.Text = "<";
            this.btn_jumppre.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(90, 198);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(35, 20);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = ">";
            this.btn_next.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(132, 198);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(44, 20);
            this.btn_last.TabIndex = 5;
            this.btn_last.Text = ">|";
            this.btn_last.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.Text = "跳去";
            // 
            // txtbox_page
            // 
            this.txtbox_page.Location = new System.Drawing.Point(46, 221);
            this.txtbox_page.Name = "txtbox_page";
            this.txtbox_page.Size = new System.Drawing.Size(58, 23);
            this.txtbox_page.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(111, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.Text = "页";
            // 
            // btn_jumpage
            // 
            this.btn_jumpage.Location = new System.Drawing.Point(132, 221);
            this.btn_jumpage.Name = "btn_jumpage";
            this.btn_jumpage.Size = new System.Drawing.Size(59, 20);
            this.btn_jumpage.TabIndex = 9;
            this.btn_jumpage.Text = "跳去";
            this.btn_jumpage.Click += new System.EventHandler(this.btn_jumpage_Click);
            // 
            // lab_page
            // 
            this.lab_page.Location = new System.Drawing.Point(197, 221);
            this.lab_page.Name = "lab_page";
            this.lab_page.Size = new System.Drawing.Size(38, 20);
            // 
            // labresult
            // 
            this.labresult.Location = new System.Drawing.Point(4, 4);
            this.labresult.Name = "labresult";
            this.labresult.Size = new System.Drawing.Size(218, 20);
            // 
            // resultformol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.labresult);
            this.Controls.Add(this.lab_page);
            this.Controls.Add(this.btn_jumpage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_page);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_jumppre);
            this.Controls.Add(this.btn_jump1st);
            this.Controls.Add(this.labrecordcount);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.resultgirdview);
            this.Name = "resultformol";
            this.Text = "查询结果";
            this.Load += new System.EventHandler(this.resultformol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid resultgirdview;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label labrecordcount;
        private System.Windows.Forms.Button btn_jump1st;
        private System.Windows.Forms.Button btn_jumppre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_page;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_jumpage;
        private System.Windows.Forms.Label lab_page;
        private System.Windows.Forms.Label labresult;
    }
}