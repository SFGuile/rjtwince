using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Runtime.InteropServices;

namespace rjtce
{
    public partial class queryolform : Form
    {
        public queryolform()
        {
            InitializeComponent();
        }

        [DllImport("Coredll.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,
            int dwExtraInfo
        );


        Scanner scanner = new Scanner();
        
        private int scanCount = 0;
      
        
        QueryRsult[] qresult = new QueryRsult[5];

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要返回吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要清空吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                txtbarcode.Text = "";
                txtprodno.Text = "";
                txtbatch.Text = "";
                txtprodname.Text = "";
            }
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            EndpointAddress EndPtAddr = new EndpointAddress(new Uri("http://192.168.0.242/service1.svc"));
            Service1Client m_proxy = new Service1Client(binding, EndPtAddr);
            QueryArgs qargs = new QueryArgs{
            barcode  = txtbarcode.Text,
            prodno = txtprodno.Text,
            batchno = txtbatch.Text,
            prodname = txtprodname.Text};
            int pageSize = 5;
            int  pageIndex=1;
            int pageCount = 0;
            int Counts = 0;

            try
            {
                qresult=m_proxy.getquery(qargs, pageSize,  pageIndex, globalvar.un, globalvar.pwd , out pageCount, out  Counts);
                if (Counts == 0)
                {
                    MessageBox.Show("没有查到任何记录");
                }
                else
                {
                    globalvar.recount = Counts;
                    globalvar.pagecount = pageCount;
                    globalvar.prodnoq = qargs.prodno;
                    globalvar.prodnameq = qargs.prodname;
                    globalvar.batchnoq = qargs.batchno;
                    globalvar.barcodeq = qargs.barcode;

                    var frm = new resultformol(qresult);
                    frm.ShowDialog();
                 ////this.Hide();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误" + ex.ToString());
            }

        }

        private void btnscan_Click(object sender, EventArgs e)
        {

            if (btnscan.Text == "自动扫描")
            {



                if (!scanner.IsContinuousMode)
                {
                    if (scanner.SwitchTriggerMode())
                    {
                        timer1.Enabled = true;
                        btnscan.Text = "手动扫描";
                    }
                    else
                    {
                        MessageBox.Show("自动扫描模式打开失败");
                    }
                }
                
                   

            }
            else
            {
                
                if (scanner.IsContinuousMode)
                {
                    if (scanner.SwitchTriggerMode())
                    {
                        btnscan.Text = "自动扫描";
                        timer1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("自动扫描模式关闭失败");
                    }
                }

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //10秒没扫到东西则关闭扫描头
            if (scanner.IsContinuousMode && (++scanCount >= 10))
            {
                if (scanner.SwitchTriggerMode())
                {
                    scanCount = 0;
                    btnscan.Text = "自动扫描";
                    timer1.Enabled = false;
                }
            }
        }
        

        void scanner_DecodeEvent(object sender, DecodeEventArgs e)
        {


            Invoke((Action<string>)delegate(string barcode)
            {
                txtbarcode.Text = barcode;
                Scan(barcode);
                if (!string.IsNullOrEmpty(barcode))
                {
                    btnquery_Click(sender, e);
                }

            }, e.Barcode.Trim('\0', '\t', '\n', '\r'));

            

        }

        private void queryolform_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.timer1.Interval = 1000;
            scanner.DecodeEvent += new EventHandler<DecodeEventArgs>(scanner_DecodeEvent);
            scanner.Start();

            if (scanner.IsContinuousMode)
            {
                if (scanner.SwitchTriggerMode())
                {
                    btnscan.Text = "自动扫描";
                    timer1.Enabled = false;
                }
                else
                {
                    btnscan.Text = "手动扫描";
                    timer1.Enabled = true;
                }
                
            }
            
        }

        private void queryolform_Closing(object sender, CancelEventArgs e)
        {
           
             scanner.Stop();
             scanner.DecodeEvent -= scanner_DecodeEvent;
        }

        public void Scan(string barcode)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要重置吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                scanner.Stop();
                scanner.Start();
            }
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//ENTER键
            {
                if (txtbarcode.Text.Trim() != "" && !scanner.IsContinuousMode)
                {
                    btnquery_Click(sender, e);
                }
               
            }
        }
             
    }
}