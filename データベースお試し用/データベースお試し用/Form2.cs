using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;


namespace データベースお試し用
{

    public partial class Form2 : Form
    {
        /// <summary>
        /// データ保持用
        /// </summary>
        private Correction correction;
        private Form1 form;


        public Form2()
        {
            /*
            comboBoxS.Items.Add("Ａ");
            comboBoxS.Items.Add("Ｂ");
            comboBoxS.Items.Add("Ｃ");
            comboBoxS.Items.Add("Ｄ");
            */
            InitializeComponent();
            /*
            string msg = itemx.Text;
        
            comboBoxS.Text =;
            textBoxS.Text = listView1.CheckedItems[0].Index;
            textBoxS2.Text =;
            */
        }



        public string importance { get; internal set; }
        public string content { get; internal set; }
        public string Category { get; internal set; }
        public string Price { get; internal set; }
        public string date { get; internal set; }
        public string remarks { get; internal set; }

        /// <summary>
        /// 引数ありコンストラクタ
        /// </summary>
        /// <param name="cn"></param>
        public Form2(Correction cn, Form1 form)
        {
            this.form = form;

            InitializeComponent();
            this.correction = cn;

            string strid = cn.id.ToString();

            label1.Text = strid;
            comboBoxS.Text = cn.importance;
            textBoxS.Text = cn.content;
            textBoxS2.Text = cn.remarks;
        }



        private void test()
        {
            //何もしない
        }

        private void testB(int naibukazu)
        {
            //何もしない
            int z = naibukazu / 2;
        }



        private void button5_Click(object sender, EventArgs e)
        {

            //----1.データを作る為にリストビューから値を取得

            Correction se = new Correction();

            //----2.値を詰め込む

            string strid = se.id.ToString();
            se.id = int.Parse(this.label1.Text);
            se.importance = this.comboBoxS.Text;
            se.content = this.textBoxS.Text;
            se.remarks = this.textBoxS2.Text;
            se.date = this.correction.date;

            form.SetcontentItems(se);

            //----3.詰め込んだ物を渡す

            //Form1 sub = new Form1(se);

            //----4.渡した状態で画面起動
            //sub.ShowDialog(this);
            //sub.Dispose();


            this.Close();
            //this.Dispose();
            //this.dataLoad();

        }

        private void dataLoad()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
