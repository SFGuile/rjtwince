using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace rjtce
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            globalvar.errcount = 0;
        }

      
        private void comfirmbtn_Click(object sender, EventArgs e)
        {
            string usertxt = txtuser.Text;
            string passtxt = txtPass.Text;
            
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            EndpointAddress EndPtAddr = new EndpointAddress(new Uri("http://192.168.0.242/service1.svc"));
            Service1Client m_proxy = new Service1Client(binding, EndPtAddr);
            try
            {
                int result=m_proxy.getindenty(usertxt, passtxt);
                if (result == 0)
                {
                    globalvar.un = usertxt;
                    globalvar.pwd = passtxt;
                    MainFormol form2 = new MainFormol();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    globalvar.errcount++;
                    if (globalvar.errcount < 3)
                    {
                        MessageBox.Show("密码错误");
                    }
                    else
                    {
                        MessageBox.Show("密码错误超过次数，程序退出");
                        Application.Exit();
                    }

                    

                }


            }
            catch (Exception ex)
            {
              
                MessageBox.Show("发生错误" + ex.ToString());
            }

            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}