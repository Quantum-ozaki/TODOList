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

            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Value = DateTime.Now;


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
            DateTime now = DateTime.Now;

            // 月 (Month) を取得する
            int month = now.Month;
            ThismonthLbl.Text = month.ToString() + "月の予算";

            InitializeTab();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        public void Budgetcomment()
        {
            //予算表示
            //オブジェクト指向パラダイム
            MySqlConnection con = new MySqlConnection();
            string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            con.ConnectionString = conString;

            con.Open();

            // セレクト文出す
            //StringBuilder sql = new StringBuilder();
          //  sql.AppendLine("SELECT * FROM goal WHERE id = '0'");
            //sql.AppendLine("SELECT price FROM goal WHERE id LIKE '0'");
            string sql = "SELECT price FROM goal WHERE id LIKE '0';";

            //string setprice = textBox11.Text;
            //sql.AppendLine("UPDATE goal SET price = '" + setprice + "' ,WHERE id = '0'");
            //sql.AppendLine("INSERT INTO goal(price, comment) VALUES(1000,'aaaaaaa')");
            //sql.AppendLine("SELECT * FROM content WHERE id = '3'");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();
          
            while (reader.Read())
            {
               string price = reader.GetString("price");
               //string comment = reader.GetString("comment");
               budgetTextBox.Text = price;
               //CommenTxt.Text = comment;
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

        /// <summary>
        /// 登録ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerBtn_Click(object sender, EventArgs e)
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
            string strCategory = catergoryComboBox.Text;
            string strContent = nameTextBox.Text;
            string strPrice = priceTextBox.Text;
            string strRemarks = noteTextBox.Text;
            //string strData = dateTimePicker2.Text;

            string strData = dateTimePicker.Text;
            //文字列をDateTime値に変換する
            DateTime dtData = DateTime.Parse(strData);


            // INSERT文出す
            //StringBuilder sql = new StringBuilder();

            //sql.AppendLine("INSERT INTO content (id, importance, content, category, price, date, remarks) VALUES('" + strCategory + "','" + strContent + "','" + strPrice + "','" + strRemarks + "','" + strData + "')");
            //sql.AppendLine("INSERT INTO content (user_id, importance, content, category_id, price, date, remarks ) VALUES(0,'0','" + strContent + "',(SELECT id FROM category WHERE name = '" + strCategory + "'),'" + strPrice + "','" + dtData + "','" + strRemarks + "')");
            string sql = string.Format("INSERT INTO content (importance, content, category_id, price, date, remarks, user_id) VALUES ('0', '{0}', (SELECT id FROM category WHERE name = '{1}'), '{2}', '{3}', '{4}', 1)", strContent, strCategory, strPrice, dtData, strRemarks);

            // よみこむやつ
            //MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();


            //最後にとじる
            con.Close();

            catergoryComboBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            noteTextBox.Text = "";

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

        /// <summary>
        /// 削除ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //StringBuilder sql = new StringBuilder();
                //sql.AppendLine("DELETE FROM content WHERE id = '" + msg + "'");
                string sql = string.Format("DELETE FROM content WHERE id = '{0}';", msg);
                //MessageBox.Show(msg);

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }


            //最後にとじる
            con.Close();

            //リストビューの中身を更新する
            FetchMainContents();

        }

        /// <summary>
        /// 変更ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// モデルクラスをやりとりして変更内容を反映する
        /// </summary>
        /// <param name="se"></param>
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

                var cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        /// <summary>
        /// CSV出力ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvOutBtn_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 月別集計ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            Budgetcomment();

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
                //MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
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

                if (!budgetTextBox.Text.Any())
                {
                    return;
                }

                int total_price = 0;
                int budget = int.Parse(budgetTextBox.Text);
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

            using(MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                //オブジェクト指向パラダイム
                con.Open();


                // 必要な変数を宣言する
                //DateTime dtNow = DateTime.Now;
                DateTime now = DateTime.Now;
                // 月 (Month) を取得する
                //int iMonth = now.Month;
                //int iYear = now.Year;
                int month = now.Month;
                int year = now.Year;

                // セレクト文出す
                //StringBuilder sql = new StringBuilder();
                //sql.AppendLine("SELECT SUM(price) AS total FROM content");
                //sql.AppendLine("SELECT SUM(price) AS total FROM content WHERE DATE_FORMAT(date, '%Y%m')= '" + iYear + iMonth + "'");
                string sql = string.Format("SELECT SUM(price) AS total FROM content WHERE DATE_FORMAT(date, '%Y%m') = '{0}{1}';", year, month);

                // よみこむやつ
                //MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 結果を表示します。
                while (reader.Read())
                {
                    string total = reader.GetString("total");

                    //MessageBox.Show(total);
                    //double iBudget = double.Parse(budgetTextBox.Text);
                    //double iTotal = double.Parse(total);
                    //double iResult = iTotal / iBudget * 100;
                    double budget = double.Parse(budgetTextBox.Text);
                    double total_amt = double.Parse(total);
                    double tmp_result = total_amt / budget * 100.0;
                    //double iRsult = int Rsult;
                    //int Result = (int)iResult;
                    int result = (int)tmp_result;

                    if (result <= 100)
                    {
                        userateBar.Minimum = 0;
                        userateBar.Maximum = 100;

                        userateBar.Value = result;
                        PercentageLbl.Text = result.ToString() + "%";



                    }

                    else if (result > 100)
                    {
                        userateBar.Minimum = 0;
                        userateBar.Maximum = 100;
                        userateBar.Value = 100;

                        PercentageLbl.Text = result.ToString() + "%";
                        MessageBox.Show("予算額を超えました！");
                        //Color foreColor = Color.Red;

                        if (listView2.SelectedIndices.Count > 0 && listView2.SelectedIndices[0] > 0)
                        {
                            // 下記のように記述すると、コントロールの色を変更できます
                            listView2.SelectedItems[0].UseItemStyleForSubItems = false;
                            listView2.SelectedItems[0].BackColor = Color.Red;
                        }
                    }

                }
            }


        }

        /// <summary>
        /// 集計表示タブの登録ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void budgetBtn_Click(object sender, EventArgs e)
        {
            string price = budgetTextBox.Text;
            string comment = CommenTxt.Text;
            string cmd_name;
            string exist_sql = "SELECT COUNT(id) FROM goal;";
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(exist_sql, con);
                object obj = cmd.ExecuteScalar();
                long count = (long)obj;
                cmd_name = (count > 0) ? "UPDATE goal SET price = {0}, comment = '{1}' WHERE id = 1" : "INSERT INTO goal(price, comment) VALUES ({0}, '{1}')";
            }

            string sql = string.Format(cmd_name, price, comment);

            using (MySqlConnection con2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con2.Open();

                MySqlCommand cmd2 = new MySqlCommand(sql, con2);
                cmd2.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 分類管理ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryDialogBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new CategoryDialog())
            {
                dialog.ShowDialog(this);
            }

            UpdateCategories();
        }

        /// <summary>
        /// 分類コンボボックスの中身を更新するプライベートメソッド
        /// </summary>
        private void UpdateCategories()
        {
            categories = new List<Category>();
            catergoryComboBox.Items.Clear();

            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                string sql = "SELECT id, name FROM category";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var tmp = new Category { Id = reader.GetInt32(0), Name = reader.GetString(1) };
                    categories.Add(tmp);
                    catergoryComboBox.Items.Add(tmp.Name);
                }
            }
        }

        /// <summary>
        /// 終了ボタンのクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            /*if (userateBar.Value ==100)
            {



                if (listView2.SelectedIndices.Count > 0 && listView2.SelectedIndices[0] > 0)
                {
                    // 下記のように記述すると、コントロールの色を変更できます
                    listView2.SelectedItems[0].UseItemStyleForSubItems = false;
                    listView2.SelectedItems[0].BackColor = Color.Red;
                }

            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// TODOリストの中身を更新するプライベートメソッド
        /// </summary>
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

        /// <summary>
        /// TODOリストの中身をコントロールにセットするプライベートメソッド
        /// </summary>
        /// <param name="items"></param>
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

        /// <summary>
        /// メインコンテンツの列をクリックしたときに呼び出されるクリックハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            main_content_comparer.ColumnNumber = e.Column;
            listView2.Sort();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InitializeTab()
        {
            using (var con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                int user_id = 1;
                string sql = string.Format("SELECT * FROM goal WHERE id = {0};", user_id);

                var cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int price = reader.GetInt32("price");
                    string comment = reader.GetString("comment");

                    budgetTextBox.Text = price.ToString();
                    CommenTxt.Text = comment;
                }
            }
        }

        private void csvInBtn_Click(object sender, EventArgs e)
        {
            string open_path = "";
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "CSVファイルの読み込み";
                dialog.AddExtension = true;
                dialog.DefaultExt = "csv";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    open_path = dialog.FileName;
                }
                else
                {
                    return;
                }
            }

            using (CSVReader reader = new CSVReader(open_path))
            {
                reader.ReadHeader();
                ListViewItem item;
                while (reader.Read(out item))
                {
                    this.listView2.Items.Add(item);
                }
            }
        }
    }
}
