﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GameStoreV2
{
    public partial class FormStoteLogin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True");
        public FormStoteLogin()
        {
            InitializeComponent();
        }

        private void searchAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm newForm = new SearchForm();
            newForm.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSteam newForm = new FormSteam();
            newForm.ShowDialog(this);
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormGamesLogin newForm = new FormGamesLogin();
            newForm.ShowDialog(this);
        }
    }
}
