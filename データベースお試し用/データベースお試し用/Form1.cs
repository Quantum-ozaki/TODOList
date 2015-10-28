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
        private Correction correction;

        private List<int> savedidList = new List<int>();


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

        
        public Form1(Correction se)
        {
            InitializeComponent();
            this.correction = se;


            string strID = se.ID.ToString();
            label10.Text = strID;
            label11.Text = se.Important;
            label12.Text = se.Content;
            label13.Text = se.Remarks;


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

                string id = reader.GetString("id");
                string important = reader.GetString("importance");
                string Content = reader.GetString("content");
                string Remarks = reader.GetString("remarks");
                DateTime Dated = reader.GetDateTime("date");
                string date = Dated.ToString("yyyy/MM/dd (ddd)");

                ListViewItem itemx1 = new ListViewItem();
                itemx1.Name = id;
                itemx1.Text = id;         //重要度
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
            string strTime = nowtime.ToString("yyyy/MM/dd (ddd)");

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
                sql.AppendLine("DELETE FROM content WHERE id = '" + msg + "'");

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
                    string seticontent = textBox4.Text;
                    string setiremarks = textBox3.Text;

                    //MessageBox.Show(msg + setiImportant + seticontent + setiremarks);

                    if (comboBox2.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("重要度と内容は入力してください");
                    }

                    else if (comboBox2.Text != "" || textBox4.Text != "")
                    {
                        // UPDATE文出す
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + seticontent + "' , remarks = '" + setiremarks + "' WHERE id = '" + msg + "'");

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
                sql.AppendLine("SELECT id, importance, content, remarks, date  FROM content where importance LIKE '" + strImportant + "'");

            // よみこむやつ
            MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string id = reader.GetString("id");
                string important = reader.GetString("importance");
                string content = reader.GetString("content");
                string remarks = reader.GetString("remarks");
                string dated = reader.GetString("date");

                ListViewItem itemx1 = new ListViewItem();
                itemx1.Text = id;         //重要度
                itemx1.SubItems.Add(important);         //重要度
                itemx1.SubItems.Add(content);  //内容
                itemx1.SubItems.Add(remarks);  //備考
                itemx1.SubItems.Add(dated);  //日付

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

            //----1.データを作る為にリストビューから値を取得

            Correction cn = new Correction();

            //----2.値を詰め込む
            //cn.ID = this.savedidList[this.listView1.CheckedItems[0].Index];
            cn.ID = int.Parse(this.listView1.CheckedItems[0].SubItems[0].Text);
            cn.Important = this.listView1.CheckedItems[0].SubItems[1].Text;
            cn.Content = this.listView1.CheckedItems[0].SubItems[2].Text;
            cn.Remarks = this.listView1.CheckedItems[0].SubItems[3].Text;
            cn.Dated = DateTime.Parse(this.listView1.CheckedItems[0].SubItems[4].Text);

            //MessageBox.Show(cn.Important);

            //----3.詰め込んだ物を渡す

            Form2 main = new Form2(cn, this);

            //----4.渡した状態で画面起動
            main.ShowDialog(this);
            main.Dispose();
            //this.dataLoad();


            using (Form2 sub = new Form2())
            {
                Correction se = new Correction();
                // プロパティに値を設定して子フォームを開く

                // 子フォームで設定されたプロパティから値を反映する
                string strID = se.ID.ToString();
                this.label10.Text = strID;
                this.label11.Text = se.Important;
                this.label12.Text = se.Content;
                this.label13.Text = se.Remarks;

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

                if (label10.Text != "")
                {


                    string msg = label10.Text;
                    string setiImportant = label11.Text;
                    string seticontent = label12.Text;
                    string setiremarks = label13.Text;


                    // UPDATE文出す
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + seticontent + "' , remarks = '" + setiremarks + "' WHERE id = '" + msg + "'");

                    // よみこむやつ
                    MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                    cmd.ExecuteNonQuery();


                }
                //最後にとじる
                con.Close();

                //接続する
                button1_Click(sender, e);


            }



        }


        private void dataLoad()
        {
            throw new NotImplementedException();
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
                sql.AppendLine("SELECT importance FROM content WHERE id LIKE '" + msg + "'");

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                MySqlDataReader reader = cmd.ExecuteReader();







                while (reader.Read())
            {

                string important = reader.GetString("importance");
   

                ListViewItem itemx1 = new ListViewItem();

                itemx1.SubItems.Add(important);         //重要度
   

                    string txtImportant = itemx1.ToString();

                    textBox4.Text = important;
           
              

                }

            }

            //最後にとじる
            con.Close();
        }

        //private void dataLoad()
        //{
        //    throw new NotImplementedException();
        //}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
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

            if (listView1.CheckedItems.Count == 0)
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
                    string seticontent = textBox4.Text;
                    string setiremarks = textBox3.Text;

                    //MessageBox.Show(msg + setiImportant + seticontent + setiremarks);

                    if (comboBox2.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("重要度と内容は入力してください");
                    }

                    else if (comboBox2.Text != "" || textBox4.Text != "")
                    {
                        // UPDATE文出す
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + seticontent + "' , remarks = '" + setiremarks + "' WHERE id = '" + msg + "'");

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

        private void button8_Click_2(object sender, EventArgs e)
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

            if (label10.Text != "")
            {
              

                    string msg = label10.Text;
                    string setiImportant = label11.Text;
                    string seticontent = label12.Text;
                    string setiremarks = label13.Text;

     
                        // UPDATE文出す
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + seticontent + "' , remarks = '" + setiremarks + "' WHERE id = '" + msg + "'");

                        // よみこむやつ
                        MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                        cmd.ExecuteNonQuery();


            }
            //最後にとじる
            con.Close();

            //接続する
            button1_Click(sender, e);


        }

        private void button7_Click_1(object sender, EventArgs e)
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

            if (label10.Text != "")
            {


                string msg = label10.Text;
                string setiImportant = label11.Text;
                string seticontent = label12.Text;
                string setiremarks = label13.Text;


                // UPDATE文出す
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE content SET importance = '" + setiImportant + "' , content = '" + seticontent + "' , remarks = '" + setiremarks + "' WHERE id = '" + msg + "'");

                // よみこむやつ
                MySqlCommand cmd = new MySqlCommand(sql.ToString(), con);
                cmd.ExecuteNonQuery();


            }
            //最後にとじる
            con.Close();

            //接続する
            button1_Click(sender, e);
        }

        public void SetContentItems(Correction correction)
        {
            string id_string = correction.ID.ToString();
            var target_item = this.listView1.Items.Find(id_string, false);
            target_item[0].SubItems[0].Text = correction.Important;
            target_item[0].SubItems[1].Text = correction.Content;
            target_item[0].SubItems[2].Text = correction.Remarks;
            target_item[0].SubItems[3].Text = correction.Dated.ToString("yyyy/MM/dd (ddd)");

            string sql = string.Format("UPDATE content SET importance = '{0}', content = '{1}', remarks = '{2}', date = '{3}' WHERE id = '{4}'",
                correction.Important, correction.Content, correction.Remarks, correction.Dated.ToString("yyyy-MM-dd hh:mm:ss"), correction.ID);

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
    }

}

