using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rjtce
{
    public partial class MainFormol : Form
    {
        public MainFormol()
        {
            InitializeComponent();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var lv = (ListView)sender;
            if (lv.SelectedIndices.Count > 0)
            {
                ListViewItem item = lv.Items[lv.SelectedIndices[0]];
                var tag = item.Tag as string;
                if (!string.IsNullOrEmpty(tag))
                {
                    switch (tag)
                    {
                        case "1":
                            var frm = new queryolform();
                            frm.ShowDialog();
                            break;
                        case "2":
                            Application.Exit();
                            break;
                      
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}