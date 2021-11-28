using System;
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
    public partial class FormStore : Form
    {
        public FormStore()
        {
            InitializeComponent();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gamesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGames newForm = new FormGames();
            newForm.ShowDialog(this);
        }

        private void searchAGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchForm newForm = new SearchForm();
            newForm.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGames newForm = new FormGames();
            newForm.ShowDialog(this);
        }

        private void searchAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm newForm = new SearchForm();
            newForm.ShowDialog(this);
        }*/
    }
}
