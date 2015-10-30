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
    public partial class Form3 : Form
    {

        private Correction correction;
        private Form4 form;

        public Form3(Correction cn, Form4 form, List<Category> categories)
        {
            InitializeComponent();
            this.form = form;


            this.correction = cn;

            string strid = cn.Id.ToString();
            string strData = cn.Date.ToString();

            dateTimePicker2.Text = strData;
            label6.Text = strid;
            comboBox1.Text = cn.Category;
            textBox1.Text = cn.Content;
            textBox2.Text = cn.Price;
            textBox3.Text = cn.Remarks;

            foreach (var category in categories)
            {
                comboBox1.Items.Add(category.Name);
            }
        }

        // このようにプロパティを使用する場合は単語の先頭大文字の名前をつけるようにしましょう
        public string Importance { get; internal set; }
        //public string importance { get; internal set; }
        public string Content { get; internal set; }
        //public string content { get; internal set; }
        public string CategoryId { get; internal set; }
        //public string catgory_id { get; internal set; }
        public string Price { get; internal set; }
        //public string price { get; internal set; }
        public string Date { get; internal set; }
        //public string date { get; internal set; }
        public string Remarks { get; internal set; }
        //public string remarks { get; internal set; }

        private void button2_Click(object sender, EventArgs e)
        {

            //----1.データを作る為にリストビューから値を取得

            Correction se = new Correction();

            //----2.値を詰め込む

            string strid = se.Id.ToString();
            se.Id = int.Parse(this.label6.Text);
            se.Category = this.comboBox1.Text;
            se.Content = this.textBox1.Text;
            se.Price = this.textBox2.Text;
            se.Remarks = this.textBox3.Text;

            string strData = this.dateTimePicker2.Text;
            se.Date = DateTime.Parse(strData);


            form.SetcontentItems(se);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
