﻿using Party_MS2.User;
using System;
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
    public partial class UserReports : Form
    {
        public UserReports()
        {
            InitializeComponent();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            UserAddReports userAddReports = new UserAddReports();
            userAddReports.Show();
        }
    }
}
