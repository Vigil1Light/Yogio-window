﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gosub
{
    public partial class Order_Detail_frm : Form
    {
        public Order_Detail_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(riderRequest.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(orderNumber.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(customerPhone.Text);
        }
    }
}
