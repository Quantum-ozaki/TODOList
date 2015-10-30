using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace データベースお試し用
{
    public partial class Form4 : Form
    {
        private List<Category> categories;
        private MainContentComparer main_content_comparer;


        public Form4()
        {
            InitializeComponent();

            main_content_comparer = new MainContentComparer();

            dateTimePicker2.Format = DateTimePickerFormat.Short;


            listView3.View = View.Details;
            listView3.Columns.Add("月");
            listView3.Columns.Add("金額合計");

            listView2.View = View.Details;
            listView2.CheckBoxes = true;
            listView2.FullRowSelect = true;
            listView2.ListViewItemSorter = main_content_comparer;

            listView2.Columns.Add("□", 25, HorizontalAlignment.Left);
            listView2.Columns.Add("重要度", 0, HorizontalAlignment.Left);
            listView2.Columns.Add("品名", 110, HorizontalAlignment.Left);
            listView2.Columns.Add("分類", 50, HorizontalAlignment.Left);
            listView2.Columns.Add("金額", 60, HorizontalAlignment.Right);
            listView2.Columns.Add("日付", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("備考", 100, HorizontalAlignment.Left);

            // 分類のコンボボックスを初期化する
            UpdateCategories();


            // 必要な変数を宣言する
            DateTime dtNow = DateTime.Now;

            // 月 (Month) を取得する
            int iMonth = dtNow.Month;
            ThismonthLbl.Text = iMonth.ToString() + "月の予算";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //予算表示
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;
            try
            {
                con.Open();
                // MessageBox.Show("接続成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            // セレクト文出す
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM goal");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

            // 結果を表示します。
            while (reader.Read())
            {

                
                string id = reader.GetString("id");
                string price = reader.GetString("price");
                string comment = reader.GetString("comment");
                MessageBox.Show(id+price+comment);
                textBox11.Text = price;
                CommenTxt.Text = comment;
            }

            //最後にとじる
            con.Close();
        }

        public void Budgetcomment()
        {
            //予算表示
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;
            try
            {
                con.Open();
                // MessageBox.Show("接続成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            // セレクト文出す
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM goal");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

            // 結果を表示します。
            while (reader.Read())
            {


                string id = reader.GetString("id");
                string price = reader.GetString("price");
                string comment = reader.GetString("comment");
                MessageBox.Show(id + price + comment);
                textBox11.Text = price;
                CommenTxt.Text = comment;
            }

            //最後にとじる
            con.Close();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            //リストビューをリセット
            listView2.Items.Clear();
            //foreach (ListViewItem item in this.listView2.Items)
            //{
            //    listView2.Items.Remove(item);
            //}

            FetchMainContents();
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void Budget()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;

            try
            {
                con.Open();
                //MessageBox.Show("接続成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

            // フォームの内容
            string strCategory = comboBox1.Text;
            string strContent = textBox1.Text;
            string strPrice = textBox2.Text;
            string strRemarks = textBox3.Text;
            //string strData = dateTimePicker2.Text;

            string strData = dateTimePicker2.Text;
            //文字列をDateTime値に変換する
            DateTime dtData = DateTime.Parse(strData);


            // INSERT文出す
            StringBuilder sql = new StringBuilder();

            //sql.AppendLine("INSERT INTO content (id, importance, content, category, price, date, remarks) VALUES('" + strCategory + "','" + strContent + "','" + strPrice + "','" + strRemarks + "','" + strData + "')");
            sql.AppendLine("INSERT INTO content (user_id, importance, content, category_id, price, date, remarks ) VALUES(0,'0','" + strContent + "',(SELECT id FROM category WHERE name = '" + strCategory + "'),'" + strPrice + "','" + dtData + "','" + strRemarks + "')");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();


            //最後にとじる
            con.Close();

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            //リストビューの中身を更新する
            FetchMainContents();

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;

            try
            {
                con.Open();
                //MessageBox.Show("接続成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

            foreach (ListViewItem itemx in listView2.CheckedItems)
            {
                string msg = itemx.Text;
                //MessageBox.Show("チェックが付いている項目は" + msg);


                // DELETE文出す
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE FROM content WHERE id = '" + msg + "'");
                //MessageBox.Show(msg);

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                cmd.ExecuteNonQuery();
            }


            //最後にとじる
            con.Close();

            //リストビューの中身を更新する
            FetchMainContents();

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            try
            {
                //----1.データを作る為にリストビューから値を取得

                Correction cn = new Correction();

                //----2.値を詰め込む

                //cn.id = this.savedidList[this.listView2.CheckedItems[0].Index];
                cn.Id = int.Parse(this.listView2.CheckedItems[0].SubItems[0].Text);
                // cn.importance = this.listView2.CheckedItems[0].SubItems[1].Text;
                cn.Content = this.listView2.CheckedItems[0].SubItems[2].Text;
                //cn.category_id = int.Parse(this.listView2.CheckedItems[3].SubItems[0].Text);
                cn.Category = this.listView2.CheckedItems[0].SubItems[3].Text;
                cn.Price = this.listView2.CheckedItems[0].SubItems[4].Text;
                cn.Date = DateTime.Parse(this.listView2.CheckedItems[0].SubItems[5].Text);
                cn.Remarks = this.listView2.CheckedItems[0].SubItems[6].Text;

                //MessageBox.Show(cn.importance);

                //----3.詰め込んだ物を渡す

                Form3 main = new Form3(cn, this, categories);

                //----4.渡した状態で画面起動
                main.ShowDialog(this);
                main.Dispose();
                //this.dataLoad();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void SetcontentItems(Correction se)
        {



            string id_string = se.Id.ToString();
            var target_item = this.listView2.Items.Find(id_string, false);


            target_item[0].SubItems[0].Text = se.Id.ToString();
            target_item[0].SubItems[2].Text = se.Content;
            target_item[0].SubItems[3].Text = se.Category;
            target_item[0].SubItems[4].Text = se.Price;
            target_item[0].SubItems[5].Text = se.Date.ToString("yyyy/MM/dd");
            target_item[0].SubItems[6].Text = se.Remarks;



            string sql = string.Format("UPDATE content SET content = '{0}', category_id = (SELECT id FROM category WHERE name = '{1}'), price = '{2}', date = '{3}', remarks = '{4}' WHERE id = '{5}'",
              se.Content, se.Category, se.Price, se.Date.ToString("yyyy-MM-dd hh:mm:ss"), se.Remarks, se.Id);

            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;

            try
            {
                con.Open();

                var cmd = new MySqlCommand(sql.ToString(), con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void csvBtn_Click(object sender, EventArgs e)
        {
            string save_path = "";
            using (FileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "CSVファイルの保存";
                dialog.AddExtension = true;
                dialog.DefaultExt = "csv";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    save_path = dialog.FileName;
                }
                else
                {
                    return;
                }
            }

            using (CSVWriter writer = new CSVWriter(save_path))
            {
                writer.WriteHeader("ID,importance,content,category,price,date,remarks");
                foreach (var item in this.listView2.Items)
                {
                    writer.Write((ListViewItem)item);
                }
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
  

            //リストビューをリセット
            foreach (ListViewItem item in this.listView3.Items)
            {
                listView3.Items.Remove(item);
            }

            //オブジェクト指向パラダイム
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                // セレクト文出す
                //StringBuilder sql = new StringBuilder();
                //sql.AppendLine("SELECT SUM(price) AS total FROM content");
                string sql = "SELECT DATE_FORMAT(date, '%Y-%m') as date, SUM(price) AS total FROM content GROUP BY DATE_FORMAT(date, '%Y%m')";

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 結果を表示します。
                while (reader.Read())
                {
                    string date = reader.GetString("date");
                    string total = reader.GetString("total");

                    ListViewItem itemx2 = new ListViewItem();
                    itemx2.Text = date;
                    itemx2.SubItems.Add(total);
                    listView3.Items.Add(itemx2);
                }
            }

            using(MySqlConnection con2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con2.Open();

                // セレクト文出す
                string sql2 = "SELECT * FROM content co JOIN category ca ON co.category_id = ca.id ORDER BY date ASC;";

                // よみこむやつ
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                var reader2 = cmd2.ExecuteReader();

                Font f = new Font(FontFamily.GenericSansSerif, 9);

                int total_price = 0;
                int budget = int.Parse(textBox11.Text);
                List<ListViewItem> items = new List<ListViewItem>();
                Color color;
                // 結果を表示します。
                while (reader2.Read())
                {
                    string id = reader2.GetString("id");
                    string importance = reader2.GetString("importance");
                    string content = reader2.GetString("content");
                    string category_id = reader2.GetString("category_id");
                    string category = reader2.GetString("name");
                    int price = reader2.GetInt32("price");
                    DateTime date = reader2.GetDateTime("date");
                    string remarks = reader2.GetString("remarks");

                    string strdate = date.ToString("yyyy/MM/dd");

                    var now = DateTime.Now;
                    if (date.Month == now.Month)
                    {
                        total_price += price;
                        if (total_price > budget)
                        {
                            color = Color.Red;
                        }
                        else
                        {
                            color = Color.Blue;
                        }
                    }
                    else
                    {
                        color = Color.Black;
                    }

                    ListViewItem itemx1 = new ListViewItem();
                    itemx1.UseItemStyleForSubItems = false;
                    itemx1.Name = id;
                    itemx1.Text = id;
                    itemx1.ToolTipText = "今月の予算を累計でオーバーしている品目は、上から順に赤文字で表示されます";
                    itemx1.SubItems.Add(importance);
                    itemx1.SubItems.Add(content);
                    itemx1.SubItems.Add(category);
                    itemx1.SubItems.Add(price.ToString(), color, Color.LightGray, f);
                    itemx1.SubItems.Add(strdate);
                    itemx1.SubItems.Add(remarks);

                    items.Add(itemx1);
                }

                UpdateMainContents(items);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Budgetcomment();

            try
            {
                //オブジェクト指向パラダイム
                MySqlConnection con = new MySqlConnection();
                string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                con.ConnectionString = conString;

                try
                {
                    con.Open();
                    // MessageBox.Show("接続成功");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }


                // 必要な変数を宣言する
                DateTime dtNow = DateTime.Now;
                // 月 (Month) を取得する
                int iMonth = dtNow.Month;
                int iYear = dtNow.Year;

                // セレクト文出す
                StringBuilder sql = new StringBuilder();
                //sql.AppendLine("SELECT SUM(price) AS total FROM content");
                sql.AppendLine("SELECT SUM(price) AS total FROM content WHERE DATE_FORMAT(date, '%Y%m')= '" + iYear + iMonth + "'");

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 結果を表示します。
                while (reader.Read())
                {
                    string total = reader.GetString("total");

                    //MessageBox.Show(total);
                    double iBudget = double.Parse(textBox11.Text);
                    double iTotal = double.Parse(total);
                    double iResult = iTotal / iBudget * 100;
                    //double iRsult = int Rsult;
                    int Result = (int)iResult;

                    if (Result <= 100)
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;

                        progressBar1.Value = Result;
                        PercentageLbl.Text = Result.ToString() + "%";
                    }

                    else if (Result > 100)
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 100;

                        PercentageLbl.Text = Result.ToString() + "%";
                        MessageBox.Show("予算額を超えました！");
                        //Color foreColor = Color.Red;
                    }

                }
            }
            catch (Exception)
            {

            }

        }

        private void categoryDialogBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new CategoryDialog())
            {
                dialog.ShowDialog(this);
            }

            UpdateCategories();
        }

        private void UpdateCategories()
        {
            categories = new List<Category>();
            comboBox1.Items.Clear();

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                string sql = "SELECT id, name FROM category WHERE id = '1'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var tmp = new Category { Id = reader.GetInt32(0), Name = reader.GetString(1) };
                    categories.Add(tmp);
                    comboBox1.Items.Add(tmp.Name);
                }
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            if (listView2.SelectedIndices.Count > 0 && listView2.SelectedIndices[0] > 0)
            {
                // 下記のように記述すると、コントロールの色を変更できます
                listView2.SelectedItems[0].UseItemStyleForSubItems = false;
                listView2.SelectedItems[0].BackColor = Color.Red;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //予算表示
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;
            try
            {
                con.Open();
                // MessageBox.Show("接続成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            // セレクト文出す
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT id, price, comment FROM goal");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            // 結果を表示します。
            while (reader.Read())
            {
                string id = reader.GetString("id");
                string price = reader.GetString("price");
                string comment = reader.GetString("comment");
                MessageBox.Show(id);
                textBox11.Text = price;
                CommenTxt.Text = comment;
            }

            //最後にとじる
            con.Close();
        }

        private void FetchMainContents()
        {
            //オブジェクト指向パラダイム
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                // セレクト文出す
                string sql = "SELECT * FROM content co JOIN category ca ON co.category_id = ca.id ORDER BY date ASC;";

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                Font f = new Font(FontFamily.GenericSansSerif, 9);
                var items = new List<ListViewItem>();
                // 結果を表示します。
                while (reader.Read())
                {


                    string id = reader.GetString("id");
                    string importance = reader.GetString("importance");
                    string content = reader.GetString("content");
                    string category_id = reader.GetString("category_id");
                    string category = reader.GetString("name");
                    string price = reader.GetString("price");
                    DateTime date = reader.GetDateTime("date");
                    string remarks = reader.GetString("remarks");

                    string strdate = date.ToString("yyyy/MM/dd");

                    ListViewItem itemx1 = new ListViewItem();
                    itemx1.UseItemStyleForSubItems = false;
                    itemx1.Name = id;
                    itemx1.Text = id;
                    itemx1.SubItems.Add(importance);
                    itemx1.SubItems.Add(content);
                    itemx1.SubItems.Add(category);
                    itemx1.SubItems.Add(price, Color.Black, Color.LightGray, f);
                    itemx1.SubItems.Add(strdate);
                    itemx1.SubItems.Add(remarks);

                    items.Add(itemx1);
                }

                UpdateMainContents(items);
            }
        }

        private void UpdateMainContents(List<ListViewItem> items)
        {
            listView2.Items.Clear();

            foreach (var item in items)
            {
                listView2.Items.Add(item);
            }
            //foreach (ListViewItem item in this.listView2.Items)
            //{
            //    listView2.Items.Remove(item);
            //}

            
        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            main_content_comparer.ColumnNumber = e.Column;
            listView2.Sort();
        }
    }
}
