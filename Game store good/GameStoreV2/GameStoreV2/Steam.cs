﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreV2
{
    public partial class FormSteam : Form
    {
        public FormSteam()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormStore newForm = new FormStore();
            newForm.ShowDialog(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            LoginForm newForm = new LoginForm();
            newForm.ShowDialog(this);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
