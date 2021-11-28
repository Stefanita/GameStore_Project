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
    public partial class FormStoteLogin : Form
    {
        public FormStoteLogin()
        {
            InitializeComponent();
        }

        private void searchAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm newForm = new SearchForm();
            newForm.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormGamesLogin newForm = new FormGamesLogin();
            newForm.ShowDialog(this);
        }
    }
}
