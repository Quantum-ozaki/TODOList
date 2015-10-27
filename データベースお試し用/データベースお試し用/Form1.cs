using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace データベースお試し用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;

            //ヘッダーを追加する（ヘッダー名、幅、アライメント）
            listView1.CheckBoxes = true;
            listView1.CheckBoxes = true;
            listView1.Columns.Add("□", 25, HorizontalAlignment.Left);
            listView1.Columns.Add("重要度", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("内容", 190, HorizontalAlignment.Left);
            listView1.Columns.Add("備考", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("記入日", 80, HorizontalAlignment.Left);

            comboBox1.Items.Add("Ａ");
            comboBox1.Items.Add("Ｂ");
            comboBox1.Items.Add("Ｃ");
            comboBox1.Items.Add("Ｄ");
            comboBox2.Items.Add("Ａ");
            comboBox2.Items.Add("Ｂ");
            comboBox2.Items.Add("Ｃ");
            comboBox2.Items.Add("Ｄ");
            comboBox3.Items.Add("Ａ");
            comboBox3.Items.Add("Ｂ");
            comboBox3.Items.Add("Ｃ");
            comboBox3.Items.Add("Ｄ");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //接続
        private void button1_Click(object sender, EventArgs e)
        {
            //リストビューをリセット
            foreach (ListViewItem item in this.listView1.Items)
            {
                listView1.Items.Remove(item);
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
            sql.AppendLine("SELECT * FROM content");



            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

            // 結果を表示します。
            while (reader.Read())
            {

                string ID = reader.GetString("id");
                string important = reader.GetString("importance");
                string Content = reader.GetString("content");
                string Remarks = reader.GetString("remarks");
                DateTime Dated = reader.GetDateTime("date");
                string date = Dated.ToString("mm/dd (ddd)");

                ListViewItem itemx1 = new ListViewItem();
                itemx1.Text = ID;         //重要度
                itemx1.SubItems.Add(important);         //重要度
                itemx1.SubItems.Add(Content);  //内容
                itemx1.SubItems.Add(Remarks);  //備考
                itemx1.SubItems.Add(date);  //日付

                listView1.Items.Add(itemx1);
            }

            //最後にとじる
            con.Close();
        }

        //登録
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
            string strcomboBox1 = comboBox1.Text;
            string strBox1 = textBox1.Text;
            string strBox2 = textBox2.Text;
            DateTime nowtime = DateTime.Now;
            string strTime = nowtime.ToString("MM/dd (ddd)");

            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("重要度と内容は入力してください");
            }

            else if (comboBox1.Text != "" || textBox1.Text != "")
            {
                // INSERT文出す
                StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO content(id, importance, content, category, price, date, remarks) VALUES('" + strcomboBox1 + "','" + strBox1 + "','" + strBox2 + "','" + strTime + "')");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            cmd.ExecuteNonQuery();
            }

            //最後にとじる
            con.Close();

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            //接続する
            button1_Click(sender, e);

        }

        //削除
        private void button3_Click(object sender, EventArgs e)
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



            foreach (ListViewItem itemx in listView1.CheckedItems)
            {
                string msg = itemx.Text;
                //MessageBox.Show("チェックが付いている項目は" + msg);


                // DELETE文出す
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE FROM todolist WHERE ID = '" + msg + "'");

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                cmd.ExecuteNonQuery();
            }


            //最後にとじる
            con.Close();

            //接続する
            button1_Click(sender, e);
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

                // Form2 form2 = new Form2();
                //form2.Show();

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

            if(listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("修正したい行をチェックしてください(´・ω・｀)");
                return;
            }

            else if (listView1.CheckedItems.Count > 1)
            {
                MessageBox.Show("1つだけチェックしてください（´∀｀）");
                return;
            }

            else if (listView1.CheckedItems.Count == 1)
            {


                foreach (ListViewItem itemx in listView1.CheckedItems)
                {
                    string msg = itemx.Text;

                    string setiImportant = comboBox2.Text;
                    string setiContent = textBox4.Text;
                    string setiRemarks = textBox3.Text;

                    //MessageBox.Show(msg + setiImportant + setiContent + setiRemarks);

                    if (comboBox2.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("重要度と内容は入力してください");
                    }

                    else if (comboBox2.Text != "" || textBox4.Text != "")
                    {
                        // UPDATE文出す
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + setiContent + "' , remarks = '" + setiRemarks + "' WHERE id = '" + msg + "'");

                        // よみこむやつ
                        MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                        cmd.ExecuteNonQuery();
                       
                    }

                }


            }
            //最後にとじる
            con.Close();

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            //接続する
            button1_Click(sender, e);

    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //リストビューをリセット
            foreach (ListViewItem item in this.listView1.Items)
            {
                listView1.Items.Remove(item);
            }

            //SELECT 列名 FROM テーブル名 where 列名 LIKE '探索文字';

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


            string strImportant = comboBox3.Text;

            // SELECT文出す
            StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT ID, important, Content, Remarks, Dated  FROM todolist where important LIKE '" + strImportant + "'");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string ID = reader.GetString("ID");
                string important = reader.GetString("important");
                string Content = reader.GetString("Content");
                string Remarks = reader.GetString("Remarks");
                string Dated = reader.GetString("Dated");

                ListViewItem itemx1 = new ListViewItem();
                itemx1.Text = ID;         //重要度
                itemx1.SubItems.Add(important);         //重要度
                itemx1.SubItems.Add(Content);  //内容
                itemx1.SubItems.Add(Remarks);  //備考
                itemx1.SubItems.Add(Dated);  //日付

                listView1.Items.Add(itemx1);

            }

            //最後にとじる
            con.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            //SELECT 列名 FROM テーブル名 where 列名 LIKE '探索文字';

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

            foreach (ListViewItem itemx in listView1.CheckedItems)
            {
                string msg = itemx.Text;
                //MessageBox.Show("チェックが付いている項目は" + msg);

                // SELECT文出す
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT important FROM todolist WHERE ID LIKE '" + msg + "'");

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                MySqlDataReader reader = cmd.ExecuteReader();







                while (reader.Read())
            {

                string important = reader.GetString("important");
   

                ListViewItem itemx1 = new ListViewItem();

                itemx1.SubItems.Add(important);         //重要度
   

                    string aaaaa = itemx1.ToString();

                    textBox4.Text = important;
                    MessageBox.Show(important);
               

                }

            }

            //最後にとじる
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }

}

