﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

            FormCart newform = new FormCart();
            newform.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
