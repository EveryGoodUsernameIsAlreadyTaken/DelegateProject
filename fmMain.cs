using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateProject
{
    public partial class fmMain : Form
    {
        Publisher pubMain;
        Subscriber sub1;
        Subscriber sub2;

        public fmMain()
        {
            InitializeComponent();
            pubMain = new Publisher(this);
            btnUnsub1.Enabled = false;
            btnUnsub2.Enabled = false;
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            btnSub1.Enabled = false;
            btnUnsub1.Enabled = true;

            sub1 = new Subscriber(this);
            pubMain.Subscribe(sub1.Subscriber1);
        }

        private void btnUnsub1_Click(object sender, EventArgs e)
        {
            btnSub1.Enabled = true;
            btnUnsub1.Enabled = false;

            pubMain.Unsubscribe(sub1.Subscriber1);
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            btnSub2.Enabled = false;
            btnUnsub2.Enabled = true;

            sub2 = new Subscriber(this);
            pubMain.Subscribe(sub2.Subscriber2);
        }

        private void btnUnsub2_Click(object sender, EventArgs e)
        {
            btnSub2.Enabled = true;
            btnUnsub2.Enabled = false;

            pubMain.Unsubscribe(sub2.Subscriber2);
        }

        private void btnPubSpread_Click(object sender, EventArgs e)
        {
            pubMain.Spread();
        }

        public void DisplaySub(string szAlert)
        {
            lbSubNotify.Items.Add(szAlert);
        }

        public void DisplaySpread(string szName)
        {
            lbSpread.Items.Add(szName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbSubNotify.Items.Clear();
        }
    }
}
