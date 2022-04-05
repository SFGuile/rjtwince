namespace rjtce
{
    partial class loginform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbol = new System.Windows.Forms.RadioButton();
            this.rbofl = new System.Windows.Forms.RadioButton();
            this.comfirmbtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.Text = "用户名";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(78, 53);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(147, 23);
            this.txtuser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.Text = "密码";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(78, 104);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(147, 23);
            this.txtPass.TabIndex = 3;
            // 
            // rbol
            // 
            this.rbol.Checked = true;
            this.rbol.Location = new System.Drawing.Point(51, 150);
            this.rbol.Name = "rbol";
            this.rbol.Size = new System.Drawing.Size(141, 20);
            this.rbol.TabIndex = 4;
            this.rbol.Text = "在线版（推荐）";
            // 
            // rbofl
            // 
            this.rbofl.Location = new System.Drawing.Point(51, 176);
            this.rbofl.Name = "rbofl";
            this.rbofl.Size = new System.Drawing.Size(162, 20);
            this.rbofl.TabIndex = 5;
            this.rbofl.Text = "离线版（在建中）";
            // 
            // comfirmbtn
            // 
            this.comfirmbtn.Location = new System.Drawing.Point(25, 233);
            this.comfirmbtn.Name = "comfirmbtn";
            this.comfirmbtn.Size = new System.Drawing.Size(72, 20);
            this.comfirmbtn.TabIndex = 6;
            this.comfirmbtn.Text = "确认";
            this.comfirmbtn.Click += new System.EventHandler(this.comfirmbtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(129, 233);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(72, 20);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "退出";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(90, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.Text = "版本号：1.0.0.5";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.comfirmbtn);
            this.Controls.Add(this.rbofl);
            this.Controls.Add(this.rbol);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "loginform";
            this.Text = "登陆";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton rbol;
        private System.Windows.Forms.RadioButton rbofl;
        private System.Windows.Forms.Button comfirmbtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
    }
}

