using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    public partial class CategoryDialog : Form
    {
        private List<Category> categories;

        public CategoryDialog(List<Category> categories)
        {
            this.categories = categories;

            InitializeComponent();
            foreach (var category in categories)
            {
                this.listView1.DataBindings.Add("Text", category, "Name");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.listView1.DataBindings.Add("Text", new Category(), "Name");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
