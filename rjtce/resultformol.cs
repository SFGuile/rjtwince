using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Text.RegularExpressions;


namespace rjtce
{
    public partial class resultformol : Form
    {
        public resultformol()
        {
            InitializeComponent();
        }

        QueryRsult[] qresul = new QueryRsult[5];
        Int32 thecurrpage = new Int32();

        public resultformol(QueryRsult[] qarr)
        {
            InitializeComponent();
            this.qresul = qarr;
            resultformol_Load(this, null);
           
        }
        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           
                Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (thecurrpage != globalvar.pagecount)
            {
                int myreuslt = gettheresult(globalvar.pagecount);

                if (myreuslt == 0)
                {
                    thecurrpage = globalvar.pagecount;
                    showthemessage();
                    buildthegridview();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thecurrpage + 1 <= globalvar.pagecount)
            {
                int gopage = thecurrpage + 1;
                int myreuslt = gettheresult(gopage);

                if (myreuslt == 0)
                {
                    thecurrpage = gopage;
                    showthemessage();
                    buildthegridview();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (thecurrpage- 1 > 0)
            {
                int gopage = thecurrpage - 1;
                int myreuslt = gettheresult(gopage);

                if (myreuslt == 0)
                {
                    thecurrpage = gopage;
                    showthemessage();
                    buildthegridview();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thecurrpage != 1)
            {
                int myreuslt = gettheresult(1);

                if (myreuslt == 0)
                {
                    thecurrpage = 1;
                    showthemessage();
                    buildthegridview();
                }
            }
        }

        private void resultformol_Load(object sender, EventArgs e)
        {
            thecurrpage = 1;      
            showthemessage();
            buildthegridview();
        }

        public void showthemessage()
        {
           
            labresult.Text =  "共查到" + globalvar.recount.ToString() + "条记录，共" + globalvar.pagecount.ToString() + "页";
            lab_page.Text = thecurrpage.ToString() + "/" + globalvar.pagecount.ToString();
        }


        public int gettheresult(int thepageindex)
        {
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            EndpointAddress EndPtAddr = new EndpointAddress(new Uri("http://192.168.0.242/service1.svc"));
            Service1Client m_proxy = new Service1Client(binding, EndPtAddr);
            QueryArgs qargs = new QueryArgs{
            prodno = globalvar.prodnoq,
            prodname = globalvar.prodnameq,
            batchno = globalvar.batchnoq,
            barcode = globalvar.barcodeq};
            int pageSize = 5;
            int pageCount = 0;
            int Counts = 0;

            QueryRsult[] theresult = new QueryRsult[5];
            try
            {
                theresult = m_proxy.getquery(qargs, pageSize, thepageindex, globalvar.un, globalvar.pwd, out pageCount, out  Counts);
                globalvar.recount = Counts;
                globalvar.pagecount = pageCount;
                qresul = theresult;
                return 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("发生错误" + ex.ToString());
                return -1;
            }

            

        }


        public void  buildthegridview()
        {
            resultgirdview.DataSource = null;
            resultgirdview.DataBindings.Clear();
            resultgirdview.Refresh();

            DataTable dt = new DataTable();
            string ColumnName = "序列";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "堆位1";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "堆位2";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "药品编码";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "药品名称";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "散件批号";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "散件库存";
            dt.Columns.Add(ColumnName, typeof(double));
            ColumnName = "整件批号";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "整件库存";
            dt.Columns.Add(ColumnName, typeof(double));
            ColumnName = "规格";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "单位";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "批准文号";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "仓库编号";
            dt.Columns.Add(ColumnName, typeof(string));
            ColumnName = "楼层";
            dt.Columns.Add(ColumnName, typeof(string));

            ///这里如果改显示行数这里要改
            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrEmpty(qresul[i].prodno))
                {
                    DataRow dr = dt.NewRow();
                    dr["序列"] = (i + 1).ToString();
                    dr["堆位1"] = qresul[i].deppos;
                    dr["堆位2"] = qresul[i].permemo;
                    dr["药品编码"] =qresul[i].prodno;
                    dr["药品名称"] = qresul[i].prodname;
                    dr["整件批号"] = qresul[i].batchnozj ;
                    dr["整件库存"] = qresul[i].lestnumzj ;
                    dr["散件批号"] = qresul[i].batchno;
                    dr["散件库存"] = qresul[i].lestnum;
                    dr["规格"] = qresul[i].prodsize;
                    dr["单位"] = qresul[i].monad;
                    dr["批准文号"] = qresul[i].prodpzwh; 
                    dr["仓库编号"] =qresul[i].wareno;
                    dr["楼层"] = qresul[i].floorno;

                    dt.Rows.Add(dr);
                }
            }


            resultgirdview.TableStyles.Clear();
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = dt.TableName;
            foreach (DataColumn item in dt.Columns)
            {
                DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();
                if (item.ColumnName == "序列")
                {
                    tbcName.Width = 20;
                }
                else
                {
                    tbcName.Width = 100;
                }
                tbcName.MappingName = item.ColumnName;
                tbcName.HeaderText = item.ColumnName;
                tableStyle.GridColumnStyles.Add(tbcName);
            }
            resultgirdview.TableStyles.Add(tableStyle);


            resultgirdview.DataSource = dt;
           


        }

        private void btn_jumpage_Click(object sender, EventArgs e)
        {
               
            bool isNumeric = Regex.IsMatch(txtbox_page.Text.Trim(), @"^\d+$");

            if (!isNumeric)
            {
                MessageBox.Show("错误，你输入的不是整数!");
            }
            else
            {
                int gopage=Convert.ToInt32(txtbox_page.Text.Trim());
                if (gopage <= 0 || gopage > globalvar.pagecount)
                {
                    MessageBox.Show("错误，你输入页数超范围!");
                }
                else
                {
                    if (gopage != thecurrpage)
                    {
                        int myreuslt = gettheresult(gopage);

                       if (myreuslt==0)
                       {
                           showthemessage();
                            thecurrpage = gopage;
                           buildthegridview();
                       }
                       
                    }
                }
            }


        }
    }
}