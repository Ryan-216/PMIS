﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_MS2
{
    public partial class UserIndex : Form
    {
        public UserIndex()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UName}登录!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
