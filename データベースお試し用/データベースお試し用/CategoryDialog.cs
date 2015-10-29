using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace データベースお試し用
{
    public partial class CategoryDialog : Form
    {
        private List<Category> categories;
        private int? last_selected_index;

        public CategoryDialog()
        {
            this.categories = new List<Category>();

            InitializeComponent();

            listView1.View = View.Details;
            listView1.MultiSelect = false;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("分類名", 100, HorizontalAlignment.Left);

            UpdateRows();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!last_selected_index.HasValue)
            {
                last_selected_index = listView1.SelectedIndices[0];
                return;
            }

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                var selected_item = listView1.Items[last_selected_index.Value];
                string sql = string.Format("UPDATE category SET name = '{0}', create_user_id = 1, created_date = CURRENT_TIMESTAMP WHERE id = {1}", selected_item.SubItems[1].Text, selected_item.SubItems[0].Text);
                
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

            UpdateRows();

            last_selected_index = listView1.SelectedIndices[0];
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                string sql = "INSERT INTO category(name, create_user_id, created_date) VALUES ('', 1, CURRENT_TIMESTAMP);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                string sql2 = "SELECT id FROM category ORDER BY id DESC LIMIT 1";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                int id = (int)cmd2.ExecuteScalar();
                this.listView1.DataBindings.Add("Text", new Category { Id = id, Name = "" }, "Name");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                foreach(var item in ((ListView)sender).SelectedItems){
                    var sub_item = ((ListViewItem)item).SubItems[0];
                    string sql = string.Format("DELETE FROM category WHERE id = {0}", sub_item.Text);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateRows()
        {
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                string sql = "SELECT * FROM category;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                categories.Clear();
                while (reader.Read())
                {
                    var tmp = new Category { Id = reader.GetInt32(0), Name = reader.GetString(1) };
                    var item = new ListViewItem();
                    item.Name = tmp.Id.ToString();
                    item.Text = tmp.Id.ToString();
                    item.SubItems.Add(tmp.Name);

                    listView1.Items.Add(item);
                    categories.Add(tmp);
                }
            }
        }
    }
}
