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

        public Form4()
        {
            InitializeComponent();

            dateTimePicker2.Format = DateTimePickerFormat.Short;


            listView3.View = View.Details;
            listView3.Columns.Add("月");
            listView3.Columns.Add("金額合計");

            listView2.View = View.Details;
            listView2.CheckBoxes = true;

            listView2.Columns.Add("□", 25, HorizontalAlignment.Left);
            listView2.Columns.Add("重要度", 0, HorizontalAlignment.Left);
            listView2.Columns.Add("品名", 110, HorizontalAlignment.Left);
            listView2.Columns.Add("分類", 50, HorizontalAlignment.Left);
            listView2.Columns.Add("金額", 60, HorizontalAlignment.Right);
            listView2.Columns.Add("日付", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("備考", 100, HorizontalAlignment.Left);

            // 分類のコンボボックスを初期化する
            categories = new List<Category>();
            using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
            {
                con.Open();

                string sql = "SELECT id, name FROM category;";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while(reader.Read()){
                    var tmp = new Category { Id = reader.GetInt32(0), Name = reader.GetString(1) };
                    categories.Add(tmp);
                    comboBox1.Items.Add(tmp.Name);
                }
            }


            // 必要な変数を宣言する
            DateTime dtNow = DateTime.Now;

            // 月 (Month) を取得する
            int iMonth = dtNow.Month;
            label7.Text = iMonth.ToString() + "月の予算";


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //リストビューをリセット
            foreach (ListViewItem item in this.listView2.Items)
            {
                listView2.Items.Remove(item);
            }

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
            sql.AppendLine("SELECT * FROM content co JOIN category ca ON co.category_id = ca.id ORDER BY date ASC;");



            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

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
                itemx1.Name = id;
                itemx1.Text = id;
                itemx1.SubItems.Add(importance);
                itemx1.SubItems.Add(content);
                itemx1.SubItems.Add(category);
                itemx1.SubItems.Add(price);
                itemx1.SubItems.Add(strdate);
                itemx1.SubItems.Add(remarks);


                listView2.Items.Add(itemx1);
            }

            //最後にとじる
            con.Close();
        }


        private void tabPage3_Click(object sender, EventArgs e)
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

            //接続する
            button1_Click(sender, e);

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

            //接続する
            button1_Click(sender, e);

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            try
            {
                //----1.データを作る為にリストビューから値を取得

                Correction cn = new Correction();

                //----2.値を詰め込む

                //cn.id = this.savedidList[this.listView2.CheckedItems[0].Index];
                cn.id = int.Parse(this.listView2.CheckedItems[0].SubItems[0].Text);
                // cn.importance = this.listView2.CheckedItems[0].SubItems[1].Text;
                cn.content = this.listView2.CheckedItems[0].SubItems[2].Text;
                //cn.category_id = int.Parse(this.listView2.CheckedItems[3].SubItems[0].Text);
                cn.category = this.listView2.CheckedItems[0].SubItems[3].Text;
                cn.price = this.listView2.CheckedItems[0].SubItems[4].Text;
                cn.date = DateTime.Parse(this.listView2.CheckedItems[0].SubItems[5].Text);
                cn.remarks = this.listView2.CheckedItems[0].SubItems[6].Text;


                //MessageBox.Show(cn.importance);

                //----3.詰め込んだ物を渡す

                Form3 main = new Form3(cn, this);

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



            string id_string = se.id.ToString();
            var target_item = this.listView2.Items.Find(id_string, false);
            

            target_item[0].SubItems[0].Text = se.id.ToString();
            target_item[0].SubItems[2].Text = se.content;
            target_item[0].SubItems[3].Text = se.category;
            target_item[0].SubItems[4].Text = se.price;
            target_item[0].SubItems[5].Text = se.date.ToString("yyyy/MM/dd");
            target_item[0].SubItems[6].Text = se.remarks;
          


            string sql = string.Format("UPDATE content SET content = '{0}', category_id = (SELECT id FROM category WHERE name = '{1}'), price = '{2}', date = '{3}', remarks = '{4}' WHERE id = '{5}'",
              se.content, se.category, se.price, se.date.ToString("yyyy-MM-dd hh:mm:ss"), se.remarks, se.id);

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
                writer.WriteHeader("ID, importance, content, category_id, price, date, remarks");
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
            //sql.AppendLine("SELECT SUM(price) AS total FROM content");
            sql.AppendLine("SELECT DATE_FORMAT(date, '%Y-%m') as date, SUM(price) AS total FROM content GROUP BY DATE_FORMAT(date, '%Y%m')");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
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

         



            //最後にとじる
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
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
                    double iRsult = iTotal / iBudget * 100;
                    //double iRsult = int Rsult;
                    int Rsult = (int)iRsult;

                    if (Rsult <= 100)
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = Rsult;
                        label12.Text = Rsult.ToString() + "%";
                    }

                    else if (Rsult > 100)
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 100;
                        label12.Text = Rsult.ToString() + "%";
                        MessageBox.Show("予算額を超えました！");
                        //Color foreColor = Color.Red;
                    }

                }
            }
            catch (Exception)
            {

            }

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color foreColor = Color.Red;
        }
    }
}
